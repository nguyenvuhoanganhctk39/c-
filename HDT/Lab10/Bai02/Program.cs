using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class SQ
    {
       protected int[] a;
       protected int dau;
       protected int duoi;
       protected const int MAX=10;
        public SQ()
        {
            a = new int[MAX];
        }
        public bool Empty()
        {
            return dau == 0;
        }
        public bool Full()
        {
            return dau == MAX;
        }
        public void Push(int num)
        {
            a[dau] = num;
        }
    }
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
            return a[dau];
        }
        
    }
    class Queue:SQ
    {
        public Queue()
        {
            dau = 0;
            duoi = 0;
        }
        public new void Push(int num)
        {
            base.Push(num);
            duoi++;
        }
        public new int Pop()
        {
            dau--;
           return a[dau];
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack st= new Stack();
            st.Push(3);
            Console.WriteLine(st.Pop());

        }
    }
}
