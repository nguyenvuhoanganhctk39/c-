using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai2
{
    class Queue:SQ
    {
        public Queue()
        {
            dau = 0;cuoi = 0;
        }
        public new void Push(int num)
        {
            base.Push(num);
            cuoi++;
        }
        public new int Pop()
        {
            dau--;
            return a[dau];
        }
    }
}
