﻿using DA_TLDT.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_TLDT
{
    public partial class FrmPrim : Form
    {
        public Data dt = new Data();
        public Prim prim = new Prim();
        string Path = "";
        public FrmPrim()
        {
            InitializeComponent();
        }

        private void tsbPrimOpenFile_Click(object sender, EventArgs e)
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

        private void tsbPrimReadFile_Click(object sender, EventArgs e)
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
                    p.X = rd.Next(50, ptbPrim.Width - 50);
                    p.Y = rd.Next(50, ptbPrim.Height - 50);

                    if (dt.lst_Diem.Count != 0)
                    {
                        if (Functions.Checkkhoangcach(p.X, p.Y, dt) == false) continue;
                    }
                    dt.lst_Diem.Add(p);
                }

            }
            ptbPrim.Refresh();
        }

        private void tsbPrimSaveFile_Click(object sender, EventArgs e)
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
                ptbPrim.Refresh();
            }
        }

        private void tsddbDeleteVertex_Click(object sender, EventArgs e)
        {
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

                ptbPrim.Refresh();
            }
        }

        private void tsbPrimSaveWeight_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                int dinh_dau = int.Parse(txtDinhDau.Text);
                int dinh_cuoi = int.Parse(txtDinhCuoi.Text);
                int trong_so = int.Parse(txtTrongSo.Text);


                dt.maTran[dinh_dau - 1, dinh_cuoi - 1] = trong_so;
                dt.maTran[dinh_cuoi - 1, dinh_dau - 1] = trong_so;
                ptbPrim.Refresh();
                ResetTextBox();

            }
            else
            {
                //ResetTextBox();
            }
        }
        private void ResetTextBox()
        {
            txtDinhCuoi.ResetText();
            txtDinhDau.ResetText();
            txtTrongSo.ResetText();
        }
        #region Kiểm tra textbox

        #endregion

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
            dt.lst_Diem = new List<Point>();
            dt.maTran = new int[100, 100];
            //dfs.lstKQ = null;
            lb_Dinh.Items.Clear();
            lb_Canh.Items.Clear();
            txtKetQua.ResetText();
            dt.lst_Diem.Clear();
            txtMatranke.Clear();
            ptbPrim.Refresh();
        }

        private void bttChayTuDong_Click(object sender, EventArgs e)
        {
            if (!Functions.Kiem_Tra_Lien_Thong(dt))
            {
                MessageBox.Show("Đồ thị không liên thông");
                return;
            }
            else
            {
                int dinhxuatphat = 1;
                if (txtDinhStart.Text != "")
                {
                    dinhxuatphat = int.Parse(txtDinhStart.Text);
                }
                if (dinhxuatphat > dt.lst_Diem.Count || dinhxuatphat < 1)
                {
                    MessageBox.Show("Đỉnh không hợp lệ"); txtDinhStart.ResetText();
                    return;
                }
                prim.Reset();
                prim.ReadMatran(dt.maTran, dt.lst_Diem.Count);
                prim.prim(dinhxuatphat - 1);

                string kq = "Chọn các cạnh lần lượt bắt đầu từ " + dinhxuatphat + ":\r\n";
                foreach (var i in prim.mst)
                {
                    kq += "Cạnh " + (i.Item1 + 1) + " - " + (i.Item2 + 1) + " Có trọng số là: " + i.Item3 + "\r\n";
                }
                txtT.Text = (prim.T).ToString();
                txtKetQua.Text = kq;

                ptbPrim.Refresh();

                PrimAuto frm = new PrimAuto(dt, dinhxuatphat);
                frm.ShowDialog();
            }
            
        }

        private void ptbPrim_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            Functions.VeMain(dt, g, Font, lb_Canh, lb_Dinh, txtMatranke);
        }

        private void bttKiemTraDoThi_Click(object sender, EventArgs e)
        {
            txtT.Text = "0";
            if (!Functions.Kiem_Tra_Lien_Thong(dt))
            {
                MessageBox.Show("Đồ thị không liên thông");
                return;
            }
            else
            {
                int dinhxuatphat = 1;
                if (txtDinhStart.Text != "")
                {
                    dinhxuatphat = int.Parse(txtDinhStart.Text);
                }
                if (dinhxuatphat > dt.lst_Diem.Count || dinhxuatphat < 1)
                {
                    MessageBox.Show("Đỉnh không hợp lệ"); txtDinhStart.ResetText();
                    return;
                }
                prim.Reset();
                prim.ReadMatran(dt.maTran, dt.lst_Diem.Count);
                prim.prim(dinhxuatphat - 1);

                string kq = "Chọn các cạnh lần lượt bắt đầu từ " + dinhxuatphat + ":\r\n";
                foreach (var i in prim.mst)
                {
                    kq += "Cạnh " + (i.Item1 + 1) + " - " + (i.Item2 + 1) + " Có trọng số là: " + i.Item3 + "\r\n";
                }
                txtT.Text= (prim.T).ToString();
                txtKetQua.Text = kq;

                ptbPrim.Refresh();

                PrimStepOne frm = new PrimStepOne(dt, dinhxuatphat);
                frm.ShowDialog();
            }
        }

        private void txtDinhStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\u007F')
            {
                e.Handled = true; // Ngăn không cho ký tự đó xuất hiện trong ô TextBox
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

        private void ptbPrim_MouseClick(object sender, MouseEventArgs e)
        {
            if (Functions.Checkkhoangcach(e.X, e.Y, dt))
            {
                dt.lst_Diem.Add(new Point(e.X, e.Y));
                //MessageBox.Show((e.X).ToString() +" "+ (e.Y).ToString());
                ptbPrim.Refresh();
            }
        }

        private void tsddbPrimDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
