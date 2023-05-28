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
    public partial class PrimStepOne : Form
    {
        Data dt = new Data();
        Prim prim = new Prim();
        bool[] Drawcolor = new bool[100];
        int ChayTungBuoc = 0;
        int dinhxuatphat = 0;
        public PrimStepOne(Data data, int Start)
        {
            InitializeComponent();
            dt = data;
            dinhxuatphat = Start;
        }

        private void PrimStepOne_Load(object sender, EventArgs e)
        {
            prim.Reset();
            prim.ReadMatran(dt.maTran, dt.lst_Diem.Count);
            prim.prim(dinhxuatphat - 1);
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            if (ChayTungBuoc > 0)
            {
                ChayTungBuoc--;
                Drawcolor[prim.mst[ChayTungBuoc].Item1] = false;
                Drawcolor[prim.mst[ChayTungBuoc].Item2] = false;
                pnlMain.Refresh();
            }
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            if (ChayTungBuoc < prim.mst.Count)
            {
                Drawcolor[prim.mst[ChayTungBuoc].Item1] = true;
                Drawcolor[prim.mst[ChayTungBuoc].Item2] = true;
                ChayTungBuoc++;
                pnlMain.Refresh();
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Functions.Ve(dt, g, Drawcolor, Font, 1);
        }
    }
}
