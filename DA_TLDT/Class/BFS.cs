using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_TLDT.Class
{
    public class BFS
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

        public void Method_BFS(int x)
        {
            Queue<int> q = new Queue<int>();
            if (!visited[x])
            {
                q.Enqueue(x);
                visited[x] = true;
                while (q.Count > 0)
                {
                    int v = q.Dequeue();
                    lstKQ.Add(v);
                    foreach (int k in lst[v])
                    {
                        if (!visited[k])
                        {
                            q.Enqueue(k);
                            visited[k] = true;
                        }
                    }
                }
            }
        }
    }
}
