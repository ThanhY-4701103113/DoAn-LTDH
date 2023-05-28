using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DA_TLDT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form FormChild;

        
        private void OpenFormChild(Form childFrom)
        {
            //nếu khởi tạo rồi thì đóng lại
            if (FormChild != null)
            {
                FormChild.Close();
            }
            FormChild = childFrom;
            childFrom.TopLevel = false; //Khi mà show lên thì vẫn thực hiện tiêp lên được form cha
            childFrom.FormBorderStyle = FormBorderStyle.None;//bỏ khung 
            childFrom.Dock = DockStyle.Fill;//Chèn đầy body
            pnalMain.Controls.Add(childFrom);//them vao
            pnalMain.Tag = childFrom; //chuyển dữ liệu 
            childFrom.BringToFront();//Mang đến phía trước
            childFrom.Show();//hiển thị form lên màn hình body pn
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmBFS());
            txtMain.Text = btnBFS.Text;
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmDFS());
            txtMain.Text = btnDFS.Text;
        }

        private void btnLT_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmLienThong());
            txtMain.Text = btnLT.Text;
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmDijkstra());
            txtMain.Text = btnDT.Text;
        }

        private void btnKR_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmKruscal());
            txtMain.Text = btnKR.Text;
        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FrmPrim());
            txtMain.Text = btnPR.Text;
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
            txtMain.Text = "Ứng dụng hỗ trợ lý thuyết đồ thị";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
