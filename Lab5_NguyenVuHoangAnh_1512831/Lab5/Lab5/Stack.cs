using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Stack
    {
        double[] a = new double[100];
        int n;
        public Stack()
        {
            a = new double[100];
            n = 0;
        }
        public void Push(double x)
        {

            a[n] = x;
            n++;
        }
        public double Pop()
        {
            double x = a[n];
            n = n - 1;
            return x;
        }
        public bool IsEmpty()
        {
            return n == 0;
        }
    }
}
