using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;


namespace DA_TLDT.Class
{
    public class Dijkstra
    {
        public int[,] Ma_tran = new int[1000, 1000];
        public int n_so_dinh;
        const int INF = 1_000_000_000; // vô cùng
        public List<int> lstKQ = new List<int>() { 0 };
        private List<Tuple<int, int>>[] adj = new List<Tuple<int, int>>[100];//mảng 100pt, mỗi pt là 1 lst
        public List<int> dist = new List<int>();
        List<bool> visited = new List<bool>();
        private int[] pre = new int[100];
        public int Tong = 0;
        public void Reset()
        {
            visited.Clear();
            dist.Clear();
            lstKQ.Clear();
            Tong = 0;
        }
        public void ReadMatix(int[,] matran, int sl)
        {
            n_so_dinh = sl;
            for (int i = 0; i < n_so_dinh ; i++)
            {
                adj[i] = new List<Tuple<int, int>>();
                dist.Add(INF);
                visited.Add(false);
            }
            for (int i = 0; i < n_so_dinh; i++){
                for(int j = 0; j < n_so_dinh; j++)
                {
                    Ma_tran[i, j] = matran[i, j];
                }
            }
        }
        public void AdjacencyList()
        {
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
        public void DijkstraAlgorithm(int start, int end)
        {
            dist[start] = 0;
            pre[start] = start;
            for (int i = 0; i < n_so_dinh; i++)
            {
                //Tìm đỉnh có khoảng cách nhỏ nhất và chưa được duyệt
                int u = -1;
                int minDist = INF;
                for (int j = 0; j < n_so_dinh; j++)
                {
                    if (!visited[j] && dist[j] < minDist)
                    {
                        u = j;
                        minDist = dist[j];
                    }
                }
                if(minDist == INF)
                {
                    break;
                }
                //Đánh dấu đỉnh đã duyệt
                visited[u] = true;
                foreach (Tuple<int, int> it in adj[u])
                {
                    int v = it.Item1;
                    int w = it.Item2;
                    if (dist[v] > dist[u] + w)
                    {
                        dist[v] = dist[u] + w;
                        pre[v] = u; // trước v là u
                    }
                }
            }
            List<int> path = new List<int>();
            int k = end;
            path.Add(k);
            while (k != start)
            {
                int u = pre[k];
                Tong += getWeight(u, k); // Cộng dồn trọng số cạnh
                k = u;
                path.Insert(0, k);
            }
            lstKQ = path;

        }
        private int getWeight(int u, int v)
        {
            foreach (Tuple<int, int> it in adj[u])
            {
                if (it.Item1 == v)
                {
                    return it.Item2;
                }
            }
            return -1; // Không tìm thấy cạnh
        }
    }
}
