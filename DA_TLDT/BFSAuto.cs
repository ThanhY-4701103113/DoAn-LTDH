using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_TLDT.Class;
namespace DA_TLDT
{
    public partial class BFSAuto : Form
    {
        Data dt = new Data();
        BFS bfs = new BFS();
        bool[] Drawcolor = new bool[100];
        int dinh_dau = 0;
        int ChayAuto = 1;

        public BFSAuto(Data data, int dinhdau = 0)
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
            Auto();
        }

        private void Auto()
        {
            if (ChayAuto < bfs.lstKQ.Count)
            {
                Drawcolor[bfs.lstKQ[ChayAuto]] = true;
                ChayAuto++;
                Thread.Sleep(1000);
                pnlMain.Refresh();
            }
        }
        private void BFSAuto_Load(object sender, EventArgs e)
        {
            bfs.DocMatran(dt.maTran, dt.lst_Diem.Count);
            bfs.MTK_DSK();
            bfs.Method_BFS(dinh_dau);

            pnlMain.Refresh();
        }
    }
}
