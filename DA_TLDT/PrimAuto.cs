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
    public partial class PrimAuto : Form
    {
        Data dt = new Data();
        Prim prim = new Prim();
        bool[] Drawcolor = new bool[100];
        int ChayAuto = 0;
        int dinhxuatphat = 0;
        public PrimAuto(Data data, int Start)
        {
            InitializeComponent();
            dt = data;  
            dinhxuatphat=Start; 
        }
        private void Auto()
        {
            if (ChayAuto < prim.mst.Count)
            {
                Drawcolor[prim.mst[ChayAuto].Item1] = true;
                Drawcolor[prim.mst[ChayAuto].Item2] = true;
                ChayAuto++;
                Thread.Sleep(1000);
                pnlMain.Refresh();
            }
        }
        private void PrimAuto_Load(object sender, EventArgs e)
        {
            prim.Reset();
            prim.ReadMatran(dt.maTran, dt.lst_Diem.Count);
            prim.prim(dinhxuatphat - 1);
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
