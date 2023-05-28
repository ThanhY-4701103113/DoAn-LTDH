using DA_TLDT.Class;
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

namespace DA_TLDT
{
    public partial class KruscalAuto : Form
    {
        Data dt = new Data();
        Kruscal kcal = new Kruscal();
        bool[] Drawcolor = new bool[100];
        int ChayAuto = 0;
        public KruscalAuto(Data data)
        {
            InitializeComponent();
            dt = data;
        }

        private void KruscalAuto_Load(object sender, EventArgs e)
        {
            kcal.Reset();
            kcal.ReadMatrix(dt.maTran, dt.lst_Diem.Count);
            kcal.Kruskal();
        }
        private void Auto()
        {
            if (ChayAuto < kcal.mst.Count)
            {
                Drawcolor[kcal.mst[ChayAuto].Item1] = true;
                Drawcolor[kcal.mst[ChayAuto].Item2] = true;
                ChayAuto++;
                Thread.Sleep(1000);
                pnlMain.Refresh();
            }
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Functions.Ve(dt, g, Drawcolor, Font,1);
            Auto();
        }
    }
}
