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

namespace DA_TLDT
{
    public partial class DFSStepOne : Form
    {
        Data dt = new Data();
        DFS dfs = new DFS();
        int dinh_dau = 0;
        bool[] Drawcolor = new bool[100];
        int indexcolor = 1;
        public DFSStepOne(Data data, int dinhdau = 0)
        {
            InitializeComponent();
            dt = data;
            dinh_dau = dinhdau;
        }

        private void DFSStepOne_Load(object sender, EventArgs e)
        {
            dfs.DocMatran(dt.maTran, dt.lst_Diem.Count);
            dfs.MTK_DSK();
            dfs.Method_DFS(dinh_dau);

            pnlMain.Refresh();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Functions.Ve(dt, g, Drawcolor, Font,0);
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            if (indexcolor < dfs.lstKQ.Count)
            {
                Drawcolor[dfs.lstKQ[indexcolor]] = true;
                indexcolor++;
                pnlMain.Refresh();
            }
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            if (indexcolor > 1)
            {
                indexcolor--;
                Drawcolor[dfs.lstKQ[indexcolor]] = false;
                pnlMain.Refresh();
            }
        }
    }
}
