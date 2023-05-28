using DA_TLDT.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DA_TLDT
{
    public partial class FrmLienThong : Form
    {
        public Data dt = new Data();
        public LienThong lt = new LienThong();
        string Path = "";
        public FrmLienThong()
        {
            InitializeComponent();
        }
        private void tsbLTOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Path = open.FileName;
                StreamReader read = new StreamReader(open.FileName);
                txtMatranke.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void tsbLTSaveFile_Click(object sender, EventArgs e)
        {
            string check = txtMatranke.Text;
            if (check[0].ToString() == "0" || check == "")
            {
                MessageBox.Show("Chưa có dữ liệu");
            }
            else if (txtMatranke.Text != "")
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "|*.txt";
                save.RestoreDirectory = true;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter write = new StreamWriter(save.FileName);
                    write.WriteLine(txtMatranke.Text);
                    write.Close();
                }
            }
        }

        private void tsbLTReadFile_Click(object sender, EventArgs e)
        {
            int sl = 0;
            if (txtMatranke.Text != "" && Path != "")
            {

                StreamReader read = new StreamReader(Path.Trim());
                string line = "";
                string[] str;
                line = read.ReadLine();
                bool check_n = int.TryParse(line, out sl);
                for (int i = 0; i < sl; i++)
                {
                    line = read.ReadLine();
                    str = line.Split(new char[] { ' ' });
                    for (int j = 0; j < sl; j++)
                    {
                        int _temp = 0;
                        string s = str[j];
                        bool check = int.TryParse(s, out _temp);
                        if (check) dt.maTran[i, j] = _temp;
                    }
                }
                lt.Reset();
                read.Close();
                //Path = "";
            }
            else
            {
                sl = dt.lst_Diem.Count;

            }


            if (Functions.kiem_Tra_Do_Thi_Vo_Huong(dt) && Functions.kiem_Tra_Tinh_Hop_Le_Cua_Ma_Tran(dt))
            {
                dt.lst_Diem = new List<Point>();

                Random rd = new Random();
                while (dt.lst_Diem.Count < sl)
                {
                    Point p = new Point();
                    p.X = rd.Next(50, ptbLienThong.Width - 50);
                    p.Y = rd.Next(50, ptbLienThong.Height - 50);

                    if (dt.lst_Diem.Count != 0)
                    {
                        if (Functions.Checkkhoangcach(p.X, p.Y, dt) == false) continue;
                    }
                    dt.lst_Diem.Add(p);
                }

            }
            ptbLienThong.Refresh();
        }

        private void tsddbDeleteEdge_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (string item in lb_Canh.SelectedItems) //Lấy chuỗi được chọn qua phương thức Selected item
            {
                str = item; //Chuỗi được chọn
            }
            if (str != "")
            {
                int dinh_dau = int.Parse(str[0].ToString());
                int dinh_cuoi = int.Parse(str[2].ToString());

                dt.maTran[dinh_dau - 1, dinh_cuoi - 1] = 0;
                dt.maTran[dinh_cuoi - 1, dinh_dau - 1] = 0;
                //Vẽ lại ma trận trên on_Paint
                ptbLienThong.Refresh();
            }
        }

        private void tsddbDeleteVertex_Click(object sender, EventArgs e)
        {
            lt = new LienThong();
            string str = "";
            int index = -1;
            foreach (string item in lb_Dinh.SelectedItems)
            {
                str = item;

            }
            index = lb_Dinh.Items.IndexOf(str);
            if (index != -1)
            {

                lb_Dinh.Items.Remove(str);
                dt.lst_Diem.RemoveAt(index);

                ptbLienThong.Refresh();
            }
        }
        private void ResetTextBox()
        {
            txtDinhCuoi.ResetText();
            txtDinhDau.ResetText();
            txtTrongSo.ResetText();
        }
        private bool CheckTextBox()
        {
            if (txtDinhDau.Text == "") { MessageBox.Show("Bạn chưa điền đỉnh đầu"); return false; }
            if (txtDinhCuoi.Text == "") { MessageBox.Show("Bạn chưa điền đỉnh cuối"); return false; }
            if (txtTrongSo.Text == "") { MessageBox.Show("Bạn chưa điền trọng số"); return false; }
            return true;
        }
        private void bttReset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            lt.n_Lien_Thong = 0;
            dt.lst_Diem = new List<Point>();
            dt.maTran = new int[100, 100];
            lb_Dinh.Items.Clear();
            lb_Canh.Items.Clear();
            txtKetQua.ResetText();
            dt.lst_Diem.Clear();
            txtMatranke.Clear();
            ptbLienThong.Refresh();
        }

        private void tsbLTSaveWeight_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                int dinh_dau = int.Parse(txtDinhDau.Text);
                int dinh_cuoi = int.Parse(txtDinhCuoi.Text);
                int trong_so = int.Parse(txtTrongSo.Text);


                dt.maTran[dinh_dau - 1, dinh_cuoi - 1] = trong_so;
                dt.maTran[dinh_cuoi - 1, dinh_dau - 1] = trong_so;
                ptbLienThong.Refresh();
                ResetTextBox();

            }
            else
            {
                //ResetTextBox();
            }
        }

        private void ptbLienThong_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Functions.VeMain(dt, g, Font, lb_Canh, lb_Dinh, txtMatranke);
            if (lt.n_Lien_Thong != 0)
            {

                int colorvariable = 0;
                for (int i = 1; i <= lt.n_Lien_Thong; i++)
                {
                    for (int j = 0; j < lt.lstKQ[i].Count; j++)
                    {
                        if (lt.lstKQ[i].Count == 1)
                        {
                            g.FillEllipse(Functions.colorsbrush[colorvariable], dt.lst_Diem[lt.lstKQ[i][j]].X - 10, dt.lst_Diem[lt.lstKQ[i][j]].Y - 10, 20, 20);
                            //Điền giá trị cho vòng tròn màu xanh tương ứng vs chỉ số index
                            g.DrawString((lt.lstKQ[i][j] + 1).ToString(), Font, Functions.br_MauTrang, dt.lst_Diem[lt.lstKQ[i][j]].X - 5, dt.lst_Diem[lt.lstKQ[i][j]].Y - 5);
                        }
                        else
                        {

                            int z = lt.lstKQ[i][j];
                            for (int d = z; d < dt.lst_Diem.Count; d++)
                            {
                                if (dt.maTran[z, d] != 0)
                                {
                                    //Dũng cảm :>> kiên cường như bác hồ
                                    g.DrawLine(Functions.colorspen[colorvariable], dt.lst_Diem[d], dt.lst_Diem[z]);

                                    g.FillEllipse(Functions.colorsbrush[colorvariable], dt.lst_Diem[d].X - 10, dt.lst_Diem[d].Y - 10, 20, 20);
                                    g.FillEllipse(Functions.colorsbrush[colorvariable], dt.lst_Diem[z].X - 10, dt.lst_Diem[z].Y - 10, 20, 20);
                                    g.FillEllipse(Functions.br_MauTrang, (dt.lst_Diem[d].X + dt.lst_Diem[z].X) / 2 - 10, (dt.lst_Diem[d].Y + dt.lst_Diem[z].Y) / 2 - 10, 20, 20);

                                    g.DrawString((d + 1).ToString(), Font, Functions.br_MauTrang, dt.lst_Diem[d].X - 5, dt.lst_Diem[d].Y - 5);
                                    g.DrawString((z + 1).ToString(), Font, Functions.br_MauTrang, dt.lst_Diem[z].X - 5, dt.lst_Diem[z].Y - 5);
                                    g.DrawString((dt.maTran[d, z]).ToString(), Font, Functions.br_MauDen, (dt.lst_Diem[d].X + dt.lst_Diem[z].X) / 2 - 5, (dt.lst_Diem[d].Y + dt.lst_Diem[z].Y) / 2 - 5);
                                }
                            }

                        }

                    }
                    colorvariable++;
                }


            }
        }

        private void bttChayTuDong_Click(object sender, EventArgs e)
        {
            lt = new LienThong();
            lt.Reset();
            lt.Docmatran(dt);
            lt.MTK_DSK();
            lt.ThanhPhanLienThong();
            //Hiển thị kết quả 
            string result = "";
            for (int i = 1; i <= lt.n_Lien_Thong; i++)
            {
                string rs = "Miền liên thông thứ " + i.ToString() + ": ";
                for (int j = 0; j < lt.lstKQ[i].Count; j++)
                {
                    rs += (lt.lstKQ[i][j] + 1).ToString() + " \n";
                }
                result += "\r\n" + rs;
            }
            txtKetQua.Text = result;
            ptbLienThong.Refresh();

        }

        private void bttKiemTraDoThi_Click(object sender, EventArgs e)
        {
            if (dt.lst_Diem.Count == 0)
            {
                txtKetQua.Text = "Chưa có đồ thị. Vui lòng kiểm tra lại !";
                return;
            }
            if (Functions.kiem_Tra_Do_Thi_Vo_Huong(dt) && Functions.kiem_Tra_Tinh_Hop_Le_Cua_Ma_Tran(dt))
            {
                txtKetQua.Text = "Đồ thị hợp lệ và là đồ thị vô hướng";
            }
        }

        private void FrmLienThong_Load(object sender, EventArgs e)
        {

        }

        private void ptbLienThong_MouseClick(object sender, MouseEventArgs e)
        {
            if(Functions.Checkkhoangcach(e.X, e.Y,dt))
            {
                dt.lst_Diem.Add(new Point(e.X, e.Y));

                ptbLienThong.Refresh();
            }
        }

        private void txtDinhDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true; // Ngăn không cho ký tự đó xuất hiện trong ô TextBox
            }
        }

        private void txtDinhCuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true; // Ngăn không cho ký tự đó xuất hiện trong ô TextBox
            }
        }

        private void txtTrongSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true; // Ngăn không cho ký tự đó xuất hiện trong ô TextBox
            }
        }
    }
}
