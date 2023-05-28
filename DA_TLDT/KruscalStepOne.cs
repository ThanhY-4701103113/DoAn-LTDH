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
    public partial class KruscalStepOne : Form
    {
        Data dt = new Data();
        Kruscal kcal = new Kruscal();
        bool[] Drawcolor = new bool[100];
        int ChayTungBuoc = 0;
        public KruscalStepOne(Data data)
        {
            InitializeComponent();
            dt = data;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Functions.Ve(dt, g, Drawcolor, Font,1);
        }

        private void KruscalStepOne_Load(object sender, EventArgs e)
        {
            kcal.Reset();
            kcal.ReadMatrix(dt.maTran, dt.lst_Diem.Count);
            kcal.Kruskal();
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            if (ChayTungBuoc < kcal.mst.Count)
            {
                Drawcolor[kcal.mst[ChayTungBuoc].Item1] = true;
                Drawcolor[kcal.mst[ChayTungBuoc].Item2] = true;
                ChayTungBuoc++;
                pnlMain.Refresh();
            }
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            if (ChayTungBuoc > 0)
            {
                ChayTungBuoc--;
                Drawcolor[kcal.mst[ChayTungBuoc].Item1] = false;
                Drawcolor[kcal.mst[ChayTungBuoc].Item2] = false;
                pnlMain.Refresh();
            }
        }
    }
}
