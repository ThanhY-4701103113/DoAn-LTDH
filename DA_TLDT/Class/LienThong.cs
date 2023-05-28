using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DA_TLDT.Class;
namespace DA_TLDT.Class
{
    public class LienThong
    {
        Data dt = new Data();
        public List<int>[] lstKQ = new List<int>[100];
        List<int>[] lst = new List<int>[100];
        public bool[] visited = new bool[100];
        public int n_Lien_Thong = 0;
        public int[,] maTran = new int[100, 100];

        public void Reset()
        {
            n_Lien_Thong = 0;
            for (int i = 0; i < 100; i++)
            {
                lst[i] = new List<int>();
            }
            for (int i = 0; i < 100; i++)
            {
                lstKQ[i] = new List<int>();
            }
            for (int i = 0; i < 100; i++)
            {
                visited[i] = false;
            }
        }
        public void Docmatran(Data data)
        {
            this.dt = data;
            //Khởi taọ giá trị mặc định cho 2 mảng 
            for (int i = 0; i < 100; i++)
            {
                lst[i] = new List<int>();
            }
            for (int i = 0; i < 100; i++)
            {
                lstKQ[i] = new List<int>();
            }
            for (int i = 0; i < 100; i++)
            {
                visited[i] = false;
            }


            for (int i = 0; i < dt.lst_Diem.Count; i++)
                for (int j = 0; j < dt.lst_Diem.Count; j++)
                    maTran[i, j] = dt.maTran[i, j];

        }
        public void MTK_DSK()
        {
            for (int i = 0; i < dt.lst_Diem.Count; i++)
            {
                for (int j = 0; j < dt.lst_Diem.Count; j++)
                {
                    if (maTran[i, j] != 0)
                    {
                        lst[i].Add(j);
                    }
                }
            }
        }
        public void Visited(int x, int n_lien_thong)
        {
            if (!visited[x])
            {
                visited[x] = true;
                lstKQ[n_Lien_Thong].Add(x);
                foreach (int tmp in lst[x])
                    if (!visited[tmp])
                    {
                        Visited(tmp, n_Lien_Thong);
                    }
            }
        }
        public void ThanhPhanLienThong()
        {
            for (int i = 0; i < dt.lst_Diem.Count; i++)
            {
                if (!visited[i])
                {
                    n_Lien_Thong++;
                    Visited(i, n_Lien_Thong);
                }
            }
        }
    }
}
