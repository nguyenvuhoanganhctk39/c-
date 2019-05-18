using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void XuatKT(int n)
        {
            char c = ' ';
            switch (n)
            {
                case 10:
                    c = 'A';
                    break;
                case 11:
                    c = 'B';
                    break;
                case 12:
                    c = 'C';
                    break;
                case 13:
                    c = 'D';
                    break;
                case 14:
                    c = 'E';
                    break;
                case 15:
                    c = 'F';
                    break;
                default:
                    c = (char)(n + 48);
                    break;
            }
            Console.Write(c);
        }
        static char DoiSo(int n)
        {
            char c = ' ';
            switch (n)
            {
                case 10:
                    c = 'A';
                    break;
                case 11:
                    c = 'B';
                    break;
                case 12:
                    c = 'C';
                    break;
                case 13:
                    c = 'D';
                    break;
                case 14:
                    c = 'E';
                    break;
                case 15:
                    c = 'F';
                    break;
                default:
                    c = (char)(n + 48);
                    break;
            }
            return c;
        }
        static Stack DoiCoSo(int n, int b)
        {
            Stack s = new Stack();
            int t, d;
            do
            {
                t = n / b;
                d = n % b;
                s.Push(d);
                n = t;
            } while (t > 0);
            return s;
        }
        static void XuatCoSo(int n, int b)
        {
            Stack s = DoiCoSo(n, b);
            while (!s.IsEmpty())
            {
                XuatKT((int)s.Pop());
            }
            return;
        }
        static void Main(string[] args)
        {
            //int n = 255;
            int a = 2;
            int b = 16;
            //XuatCoSo(n, b);

            int num;
            Console.Write("Nhap vao mot so nguyen: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Doi so {0} sang he nhi phan: ", num);
            XuatCoSo(num, a);
            Console.WriteLine();
            Console.Write("Doi so {0} sang he thap luc phan: ", num);
            XuatCoSo(num, b);
            Console.ReadKey();
            
            Console.WriteLine("=========================================================");
            Matrix m = new Matrix();
            m.test();
            Console.ReadKey();
        }
    }
}
