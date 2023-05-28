using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace DA_TLDT.Class
{
    public class Functions
    {
        public static SolidBrush br_MauTrang = new SolidBrush(Color.White);
        public static SolidBrush br_MauXanhDuong = new SolidBrush(Color.Blue);
        public static SolidBrush br_MauDen = new SolidBrush(Color.Black);
        public static SolidBrush br_MauVang = new SolidBrush(Color.Yellow);
        public static SolidBrush br_MauDo = new SolidBrush(Color.Red);
        public static SolidBrush br_MauTim = new SolidBrush(Color.Purple);
        public static List<SolidBrush> colorsbrush = new List<SolidBrush>() { new SolidBrush(Color.Red), new SolidBrush(Color.Blue), new SolidBrush(Color.Yellow), new SolidBrush(Color.Purple), new SolidBrush(Color.Green), new SolidBrush(Color.BurlyWood), new SolidBrush(Color.DarkCyan), new SolidBrush(Color.DarkOliveGreen), new SolidBrush(Color.DarkSlateBlue), new SolidBrush(Color.DarkKhaki), new SolidBrush(Color.CadetBlue), new SolidBrush(Color.Chocolate), new SolidBrush(Color.HotPink), new SolidBrush(Color.Indigo), new SolidBrush(Color.MediumSeaGreen), new SolidBrush(Color.PapayaWhip), new SolidBrush(Color.SkyBlue), new SolidBrush(Color.WhiteSmoke), new SolidBrush(Color.YellowGreen), new SolidBrush(Color.Tomato) };
        public static List<Pen> colorspen = new List<Pen>() { new Pen(Color.Red, 3), new Pen(Color.Blue, 3), new Pen(Color.Yellow, 3), new Pen(Color.Purple, 3), new Pen(Color.Green), new Pen(Color.BurlyWood), new Pen(Color.DarkCyan), new Pen(Color.DarkOliveGreen), new Pen(Color.DarkSlateBlue), new Pen(Color.DarkKhaki) };
        public static Pen pen_Black = new Pen(Color.Black, 2);
        public static Pen pen_Red = new Pen(Color.Red, 3);
        public static Pen pen_Yellow = new Pen(Color.Yellow, 3);
        public static Pen pen_Blue = new Pen(Color.Blue, 3);

        public static bool Kiem_Tra_Lien_Thong(Data dt)
        {
            LienThong lt = new LienThong();
            lt.Reset();
            lt.Docmatran(dt);
            lt.MTK_DSK();
            lt.ThanhPhanLienThong();
            if (lt.n_Lien_Thong == 1)
            {
                return true;
            }
            return false;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void VeMain(Data dt, Graphics g, Font Font, ListBox lb_Canh, ListBox lb_Dinh, TextBox txtMatranke)
        {
            lb_Canh.Items.Clear();
            for (int i = 0; i < dt.lst_Diem.Count; ++i)
            {
                for (int j = 0; j < dt.lst_Diem.Count; ++j)
                {

                    if (dt.maTran[i, j] != 0 && dt.maTran[i, j] == dt.maTran[j, i] && j > i) //ktra nếu như tại vị trí i j !=0 và nghịch đảo của chúng == nhau thì vẽ line vì là đồ thị vô hướng
                    {
                        //Vẽ cạnh cho 2 điềm
                        g.DrawLine(Functions.pen_Black, dt.lst_Diem[i], dt.lst_Diem[j]);
                        g.FillEllipse(Functions.br_MauTrang, (dt.lst_Diem[i].X + dt.lst_Diem[j].X) / 2 - 10, (dt.lst_Diem[i].Y + dt.lst_Diem[j].Y) / 2 - 10, 20, 20);
                        //Vẽ trọng số cho 2 điểm
                        g.DrawString(dt.maTran[i, j].ToString(), Font, Functions.br_MauDen, (dt.lst_Diem[i].X + dt.lst_Diem[j].X) / 2 - 5, (dt.lst_Diem[i].Y + dt.lst_Diem[j].Y) / 2 - 5);
                        //Add cạnh vừa vẽ vào ds cạnh
                        lb_Canh.Items.Add((i + 1).ToString() + "-" + (j + 1).ToString() + ": " + dt.maTran[i, j].ToString());
                    }

                }
            }
            lb_Dinh.Items.Clear();
            //Vẽ các điểm
            for (int i = 0; i < dt.lst_Diem.Count; i++)
            {

                //Vẽ vòng tròn màu xanh
                g.FillEllipse(Functions.br_MauXanhDuong, dt.lst_Diem[i].X - 10, dt.lst_Diem[i].Y - 10, 20, 20);
                //Điền giá trị cho vòng tròn màu xanh tương ứng vs chỉ số index
                g.DrawString((i + 1).ToString(), Font, Functions.br_MauTrang, dt.lst_Diem[i].X - 5, dt.lst_Diem[i].Y - 5);
                //Add đỉnh vừa tạo vào lb_DSDinh
                lb_Dinh.Items.Add("Đỉnh:" + (i + 1).ToString());
            }

            txtMatranke.Text = dt.lst_Diem.Count.ToString() + "\r\n";
            for (int i = 0; i < dt.lst_Diem.Count; ++i)
            {
                for (int j = 0; j < dt.lst_Diem.Count; ++j)
                {
                    if (j != 0) txtMatranke.Text += " "; // Nếu không phải là cột đầu tiên thì + thêm khoảng cách
                    txtMatranke.Text += dt.maTran[i, j].ToString(); //Thêm trọng số mặc định là 0 
                }
                if (i != dt.lst_Diem.Count - 1) txtMatranke.Text += "\r\n"; //Kiểm tra xem phải là dòng cuối chưa nếu chư thì xuống hàng
            }
        }
        public static void Ve(Data dt, Graphics g, bool[] Drawcolor, Font Font, int kieu)
        {
            for (int i = 0; i < dt.lst_Diem.Count; ++i)
            {
                for (int j = 0; j < dt.lst_Diem.Count; ++j)
                {

                    if (dt.maTran[i, j] != 0 && dt.maTran[i, j] == dt.maTran[j, i] && j > i) //ktra nếu như tại vị trí i j !=0 và nghịch đảo của chúng == nhau thì vẽ line vì là đồ thị vô hướng
                    {
                        //Vẽ cạnh cho 2 điềm
                        g.DrawLine(Functions.pen_Black, dt.lst_Diem[i], dt.lst_Diem[j]);
                        g.FillEllipse(Functions.br_MauTrang, (dt.lst_Diem[i].X + dt.lst_Diem[j].X) / 2 - 10, (dt.lst_Diem[i].Y + dt.lst_Diem[j].Y) / 2 - 10, 20, 20);
                        //Vẽ trọng số cho 2 điểm
                        g.DrawString(dt.maTran[i, j].ToString(), Font, Functions.br_MauDen, (dt.lst_Diem[i].X + dt.lst_Diem[j].X) / 2 - 5, (dt.lst_Diem[i].Y + dt.lst_Diem[j].Y) / 2 - 5);

                    }
                }


            }
            
            for (int z = 0; z < dt.lst_Diem.Count; z++)
            {
                int dem = 0;
                for (int i = 0; i < dt.lst_Diem.Count; i++)
                {
                    if (Drawcolor[i] == false)
                    {
                        //Vẽ vòng tròn màu xanh
                        g.FillEllipse(Functions.br_MauXanhDuong, dt.lst_Diem[i].X - 10, dt.lst_Diem[i].Y - 10, 20, 20);
                        //Điền giá trị cho vòng tròn màu xanh tương ứng vs chỉ số index
                        g.DrawString((i + 1).ToString(), Font, Functions.br_MauTrang, dt.lst_Diem[i].X - 5, dt.lst_Diem[i].Y - 5);


                    }
                    else
                    {
                        if (dt.maTran[z, i] != 0 && dt.maTran[z, i] == dt.maTran[i, z] && dem==0 && Drawcolor[z]==true && kieu==1)
                        { 
                            //Vẽ cạnh cho 2 điềm
                            g.DrawLine(Functions.pen_Blue, dt.lst_Diem[z], dt.lst_Diem[i]);
                            g.FillEllipse(Functions.br_MauTrang, (dt.lst_Diem[z].X + dt.lst_Diem[i].X) / 2 - 10, (dt.lst_Diem[z].Y + dt.lst_Diem[i].Y) / 2 - 10, 20, 20);
                            g.DrawString(dt.maTran[z, i].ToString(), Font, Functions.br_MauDen, (dt.lst_Diem[z].X + dt.lst_Diem[i].X) / 2 - 5, (dt.lst_Diem[z].Y + dt.lst_Diem[i].Y) / 2 - 5);
                            dem++;
                        }
                        g.FillEllipse(Functions.br_MauVang, dt.lst_Diem[i].X - 10, dt.lst_Diem[i].Y - 10, 20, 20);
                        //Điền giá trị cho vòng tròn màu xanh tương ứng vs chỉ số index
                        g.DrawString((i + 1).ToString(), Font, Functions.br_MauDen, dt.lst_Diem[i].X - 5, dt.lst_Diem[i].Y - 5);
                    }

                }
            }
        }
        public static bool Checkkhoangcach(int x, int y, Data dt)
        {
            if (dt.lst_Diem.Count != 0)
            {
                foreach (Point p in dt.lst_Diem)
                {
                    int kc = (int)Math.Sqrt(Math.Pow(Math.Abs(x - p.X), 2) + Math.Pow(Math.Abs(y - p.Y), 2));
                    if (kc < 60) return false;
                }
            }
            return true;
        }
        public static bool kiem_Tra_Do_Thi_Vo_Huong(Data dt)
        {
            for (int i = 0; i < dt.lst_Diem.Count; ++i)
            {
                for (int j = 0; j < dt.lst_Diem.Count; ++j)
                {
                    if (dt.maTran[i, j] != dt.maTran[j, i]) return false;
                }
            }
            return true;
        }
        public static bool kiem_Tra_Tinh_Hop_Le_Cua_Ma_Tran(Data dt)
        {
            for (int i = 0; i < dt.lst_Diem.Count; ++i)
            {
                if (dt.maTran[i, i] != 0) return false;
            }
            return true;
        }
    }
    
}
