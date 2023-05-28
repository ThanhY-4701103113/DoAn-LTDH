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
    public partial class DijkstraAuto : Form
    {
        Data dt = new Data();
        Dijkstra dtr = new Dijkstra();
        bool[] Drawcolor = new bool[100];
        int dinhxuatphat = 0;
        int dinhketthuc = 0;
        int ChayAuto = 0;

        public DijkstraAuto(Data data, int Start,int End)
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
            Auto();
        }
        private void Auto()
        {
            if (ChayAuto < dtr.lstKQ.Count)
            {
                Drawcolor[dtr.lstKQ[ChayAuto]] = true;
                ChayAuto++;
                Thread.Sleep(1000);
                pnlMain.Refresh();
            }
        }
        private void DijkstraAuto_Load(object sender, EventArgs e)
        {
            dtr.Reset();
            dtr.ReadMatix(dt.maTran, dt.lst_Diem.Count);
            dtr.AdjacencyList();
            dtr.DijkstraAlgorithm(dinhxuatphat - 1, dinhketthuc - 1);
        }
    }
}
