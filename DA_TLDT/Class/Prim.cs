using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DA_TLDT.Class
{
    public class Prim
    {
        public int[,] Ma_tran = new int[1000, 1000];
        public int n_so_dinh;

        const int INT_MAX = int.MaxValue;
        public int T = 0;
        List<Tuple<int, int>>[] adj = new List<Tuple<int, int>>[100];
        List<bool> used = new List<bool>();
        public List<Tuple<int, int, int>> mst = new List<Tuple<int, int, int>>();
        public void Reset()
        {
            T = 0;
            used.Clear();
            mst.Clear();

        }
        public void ReadMatran(int[,] matran,int sl)
        {
            n_so_dinh = sl;
            for (int i = 0; i < n_so_dinh; i++)
            {
                for (int j = 0; j < n_so_dinh; j++)
                {
                    Ma_tran[i, j] = matran[i, j];
                }
            }
            for (int i = 0; i < n_so_dinh; i++)
            {
                adj[i] = new List<Tuple<int, int>>();
                used.Add(false);
            }
            for (int i = 0; i < n_so_dinh; i++)
            {
                for (int j = 0; j < n_so_dinh; j++)
                {
                    if (Ma_tran[i, j] != 0)
                    {
                        adj[i].Add(new Tuple<int, int>(j, Ma_tran[i, j]));
                        adj[j].Add(new Tuple<int, int>(i, Ma_tran[i, j]));
                    }
                }
            }
        }
        public void prim(int u)
        {
            used[u] = true;//dua dinh u vào tập V(MST)
            while (mst.Count() < n_so_dinh - 1)
            {
                //e=(x,y): cạnh ngắn nhất có x thuộc V và y thuộc V(MST)
                int min_w = INT_MAX;
                int X = -1, Y = -1; //lưu 2 đỉnh của cạnh e
                for (int i = 0; i < n_so_dinh; i++)
                {
                    //neu dinh i thuoc tập V(MST)
                    if (used[i])
                    {
                        //duyet danh sach ke cua dinh i
                        foreach (Tuple<int, int> it in adj[i])
                        {
                            int j = it.Item1; int w = it.Item2;
                            if (!used[j] && w < min_w)
                            {
                                min_w = w;
                                X = j; Y = i;
                            }
                        }
                    }
                }
                if (X != -1 && Y != -1)
                {
                    mst.Add(new Tuple<int, int, int>(X, Y, min_w));
                    T += min_w;
                    used[X] = true;
                }
            }

        }
    }
}
