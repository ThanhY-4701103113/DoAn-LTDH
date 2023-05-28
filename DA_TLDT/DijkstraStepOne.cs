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
    public partial class DijkstraStepOne : Form
    {
        Data dt = new Data();
        Dijkstra dtr = new Dijkstra();
        bool[] Drawcolor = new bool[100];
        int dinhxuatphat = 0;
        int dinhketthuc = 0;
        int ChayTungBuoc = 0;
        public DijkstraStepOne(Data data, int Start, int End)
        {
            InitializeComponent();
            dt = data;
            dinhxuatphat = Start;
            dinhketthuc = End;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Functions.Ve(dt, g, Drawcolor, Font,1);
        }

        private void DijkstraStepOne_Load(object sender, EventArgs e)
        {
            dtr.Reset();
            dtr.ReadMatix(dt.maTran, dt.lst_Diem.Count);
            dtr.AdjacencyList();
            dtr.DijkstraAlgorithm(dinhxuatphat - 1, dinhketthuc - 1);
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            if (ChayTungBuoc > 0)
            {
                ChayTungBuoc--;
                Drawcolor[dtr.lstKQ[ChayTungBuoc]] = false;
                pnlMain.Refresh();
            }
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            if (ChayTungBuoc < dtr.lstKQ.Count)
            {
                Drawcolor[dtr.lstKQ[ChayTungBuoc]] = true;
                ChayTungBuoc++;
                pnlMain.Refresh();
            }
        }
    }
}
