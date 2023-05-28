using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DA_TLDT.Class
{
    public class Kruscal
    {
        public int[,] Ma_tran = new int[1000, 1000];
        public int n_so_dinh;
        List<Tuple<int, int, int>> edg = new List<Tuple<int, int, int>>();
        public List<Tuple<int, int, int>> mst = new List<Tuple<int, int, int>>();
        public int Z = 0;
        List<int> prarent = new List<int>();
        List<int> sz = new List<int>();
        public void Reset()
        {
            edg.Clear();
            mst.Clear();
            prarent.Clear();
            sz.Clear();
            Z = 0;
        }
        public void ReadMatrix(int[,] matran, int sl)
        {
            n_so_dinh = sl;
            for(int i = 0; i < n_so_dinh; i++)
            {
                for(int j = 0; j < n_so_dinh; j++)
                {
                    Ma_tran[i, j] = matran[i, j];
                }
            }
            for (int i = 0; i < n_so_dinh; i++)
            {
                for (int j = 0; j < n_so_dinh; j++)
                {
                    if (i == j || Ma_tran[i, j] == 0)
                    {
                        continue;
                    }
                    edg.Add(new Tuple<int, int, int>(i, j, Ma_tran[i, j]));

                }
            }
        }
        //Cấu trúc dữ liệu Disjont Set Union| Find Union
        public void make_set()
        {
            for (int i = 0; i < n_so_dinh; i++)
            {
                prarent.Add(i);
                sz.Add(1);
            }
        }
        public int find(int v)
        {
            if (v == prarent[v]) return v;
            return prarent[v] = find(prarent[v]);
        }
        public bool Union(int a, int b)
        {
            a = find(a);
            b = find(b);
            if (a == b) return false;
            if (sz[a] < sz[b]) Functions.Swap(ref a, ref b);
            prarent[b] = a;
            sz[a] += sz[b];
            return true;
        }
        public void Kruskal()
        {
            make_set();
            edg = edg.OrderBy(e => e.Item3).ToList(); //OrderBy() sắp xếp tăng dần ;
                                                      //ToList() được sử dụng để chuyển kết quả sắp xếp từ kiểu IOrderedEnumerable sang kiểu List.
            for (int i = 0; i < edg.Count(); i++)
            {
                if (mst.Count() == n_so_dinh - 1) break;
                Tuple<int, int, int> e = edg[i];
                if (Union(e.Item1, e.Item2))
                {
                    mst.Add(e);
                    Z += e.Item3;
                }
            }
        }
    }
}
