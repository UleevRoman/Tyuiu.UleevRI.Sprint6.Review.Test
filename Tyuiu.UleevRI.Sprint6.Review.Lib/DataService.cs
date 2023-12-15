using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.UleevRI.Sprint6.Review.Lib
{
    public class DataService
    {
        public int CalculateMatrix(int[,] num, int n1, int n2, int k, int l, int R)
        {
            int cnt = 0;
            for (int i = k; i < l+1; i++)
            {
                cnt += num[R, i];
            }
            return cnt;
        }
    }
}
