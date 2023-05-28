using DA_TLDT.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace DA_TLDT
{
    public partial class DFSAuto : Form
    {
        Data dt = new Data();
        DFS dfs = new DFS();
        bool[] Drawcolor = new bool[100];
        int dinhdau = 0;
        int tgchay = 1000;
        int ChayAuto = 1;
        public DFSAuto(Data data, int dinh_dau = 0, int tg = 1000) 
        {
            InitializeComponent();
            this.dt = data;
            dinhdau = dinh_dau;
            tgchay = tg;
        }

        private void DFSAuto_Load(object sender, EventArgs e)
        {
            dfs.DocMatran(dt.maTran, dt.lst_Diem.Count);
            dfs.MTK_DSK();
            dfs.Method_DFS(dinhdau);

            pnlMain.Refresh();
        }
        private void Auto()
        {
            if (ChayAuto < dfs.lstKQ.Count)
            {
                Drawcolor[dfs.lstKQ[ChayAuto]] = true;
                ChayAuto++;
                Thread.Sleep(1000);
                pnlMain.Refresh();
            }
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Functions.Ve(dt, g, Drawcolor, Font,0);
            Auto();
        }
    }
}
