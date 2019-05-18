using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai2
{
    class SQ
    {
        protected int [] a;
        protected int dau;
        protected int cuoi;
        protected const int max = 100;
        public SQ()
        {
            a= new int [max];
        }
        public bool Empty()
        {
            return dau == 0;
        }
        public bool Full()
        {
            return cuoi == max;
        }
        public void Push(int num)
        {
            a[dau] = num;
        }
    }
}
