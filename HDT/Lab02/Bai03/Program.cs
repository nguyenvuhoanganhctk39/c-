using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
       public class TienIch
        {
            public int a;
            public int b;
            public int m;

            public int Luythua()
            {
                int kq = 1;
                for (int i = 0; i < m; i++)
                {
                    kq = kq* a;
                }
                return kq;
            }
            public int USCLN(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                if (a == 0 || b == 0)
                    return a + b;
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }
                return a;
            }
            public int BCNN(int a, int b)
            {
                int result = USCLN(a, b);
                return a * b / result;
            }

        }
        static void Main(string[] args)
        {
            TienIch ob1 = new TienIch();
            ob1.a = 6;
            ob1.b = 2;
            ob1.m = 3;
            Console.WriteLine(" {0} ^ {1} la : {2} ", ob1.a, ob1.m, ob1.Luythua());
            Console.WriteLine("UCLN cua {0} va {1} la : {2} ", ob1.a, ob1.b, ob1.USCLN(ob1.a, ob1.b));
            Console.WriteLine("UCLN cua {0} va {1} la : {2} ", ob1.a, ob1.b, ob1.BCNN(ob1.a, ob1.b));
            Console.ReadLine();
        }
    }
}
