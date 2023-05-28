
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_TLDT.Class
{
    public class DFS
    {
        public int[,] Ma_tran = new int[1000, 1000];
        public int n_so_dinh;

        public List<int>[] lst = new List<int>[100];

        public bool[] visited = new bool[1001];

        public List<int> lstKQ = new List<int>() { 0 };
        public void DocMatran(int[,] matran, int sl)
        {

            for (int i = 0; i < 100; i++)
            {
                lst[i] = new List<int>();
            }

            n_so_dinh = sl;
            for (int i = 0; i < n_so_dinh; i++)
            {
                for (int j = 0; j < n_so_dinh; j++)
                {
                    Ma_tran[i, j] = matran[i, j];
                }
            }
        }
        public void MTK_DSK()
        {
            for (int i = 0; i < n_so_dinh; i++)
            {

                for (int j = 0; j < n_so_dinh; j++)
                {
                    if (Ma_tran[i, j] != 0)
                    {
                        lst[i].Add(j);
                    }
                }
            }

        }

        public void Method_DFS(int x)
        {
            if (!visited[x])
            {
                visited[x] = true;
                lstKQ.Add(x);
                foreach (int tmp in lst[x])
                {
                    if (!visited[tmp])
                    {
                        Method_DFS(tmp);
                    }
                }
            }
        }
    }
}
