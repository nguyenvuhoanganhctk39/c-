using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai2
{
    class Stack:SQ
    {
        public Stack()
        {
            dau = 0;
        }
        public new void Push(int num)
        {
            base.Push(num);
            dau++;
        }
        public int Pop()
        {
            dau--;
            return a[dau] ;
        }
    }
}
