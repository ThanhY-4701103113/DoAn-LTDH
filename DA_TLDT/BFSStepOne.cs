using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_TLDT.Class;
namespace DA_TLDT
{
    public partial class BFSStepOne : Form
    {
        Data dt = new Data();
        BFS bfs = new BFS();
        int dinh_dau = 0;
        bool[] Drawcolor = new bool[100];
        int indexcolor = 1;
        public BFSStepOne(Data data, int dinhdau =0)
        {
            InitializeComponent();
            dt = data;
            dinh_dau = dinhdau;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Functions.Ve(dt, g, Drawcolor, Font,0);
        }

        private void BFSStepOne_Load(object sender, EventArgs e)
        {
            bfs.DocMatran(dt.maTran, dt.lst_Diem.Count);
            bfs.MTK_DSK();
            bfs.Method_BFS(dinh_dau);
            pnlMain.Refresh();
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            if (indexcolor < bfs.lstKQ.Count)
            {
                Drawcolor[bfs.lstKQ[indexcolor]] = true;
                indexcolor++;
                pnlMain.Refresh();
            }
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            if (indexcolor > 1)
            {
                indexcolor--;
                Drawcolor[bfs.lstKQ[indexcolor]] = false;
                pnlMain.Refresh();
            }
        }
    }
}
