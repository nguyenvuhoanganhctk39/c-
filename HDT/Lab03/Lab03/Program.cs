using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
       public class TamThuc
        {
            public int a, b, c;
            public TamThuc()
            {
                a = 0;
                b = 0;
                c = 0;
            }
            public TamThuc(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public TamThuc(TamThuc tt)
            {
                a = tt.a;
                b = tt.b;
                c = tt.c;
            }
            public void NhapTamThuc()
            {
                Console.Write("Nhap he so a :");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap he so b :");
                b = int.Parse(Console.ReadLine());
                Console.Write("Nhap he so c :");
                c = int.Parse(Console.ReadLine());
            }
            public void XuatTamThuc()
            {
                if (c > 0)
                {
                    Console.WriteLine("{0}*x^2 + {1}*x + {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0}*x^2 + {1}*x {2}", a, b, c);

                }

            }

            public static TamThuc operator +(TamThuc t1, TamThuc t2)
            {
                TamThuc kq = new TamThuc();
                kq.a = t1.a + t2.a;
                kq.b = t1.b + t2.b;
                kq.c = t1.c + t2.c;
                return kq;
            }
            public static TamThuc operator -(TamThuc t1, TamThuc t2)
            {
                TamThuc kq = new TamThuc();
                kq.a = t1.a - t2.a;
                kq.b = t1.b - t2.b;
                kq.c = t1.c - t2.c;
                return kq;
            }
            public static explicit operator bool(TamThuc t)
            {
                double d = t.b * t.b - 4 * t.a * t.c;
                return d >= 0;
            }
            public static explicit operator TamThuc(int t)
            {
                TamThuc ob = new TamThuc();
                ob.a = t / 100;
                ob.b = (t % 100)/10;
                ob.c = t % 10;
                return ob;
            }
            public static TamThuc operator *(TamThuc t1, int n)
            {
                TamThuc kq = new TamThuc();
                kq.a = t1.a * n;
                kq.b = t1.b * n;
                kq.c = t1.c * n;

                return kq;
            }
            public static bool operator !=(TamThuc t1, TamThuc t2)
            {
                return !(t1 == t2);
            }
            public static bool operator ==(TamThuc t1, TamThuc t2)
            {
                return (t1.a == t2.a && t1.b == t2.b && t1.c == t2.c);
            }
            public static TamThuc operator ++(TamThuc t1)
            {
                TamThuc kq = new TamThuc();
                kq.a = t1.a ;
                kq.b = t1.b;
                kq.c = t1.c++;
                return kq;
            }

        }

        static void Main(string[] args)
        {
            TamThuc a = new TamThuc();
            a.NhapTamThuc();
            a.XuatTamThuc();
            TamThuc b = new TamThuc();
            b.NhapTamThuc();
            b.XuatTamThuc();
            TamThuc c = new TamThuc();
            c = a + b;
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Cong hai tam thuc: ");
            c.XuatTamThuc();
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Tru hai tam thuc: ");
            c = a - b;
            c.XuatTamThuc();
            if ((bool)a)
            {
                Console.WriteLine("-----------------------------------------------------");
                a.XuatTamThuc(); Console.WriteLine("Co nghiem");
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------");
                a.XuatTamThuc(); Console.WriteLine("Vo nghiem");
            }
            if ((bool)b)
            {
                Console.WriteLine("-----------------------------------------------------");
                b.XuatTamThuc(); Console.WriteLine("Co nghiem");
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------");
                b.XuatTamThuc(); Console.WriteLine("Vo nghiem");
            }
            Console.WriteLine("-----------------------------------------------------");

            TamThuc d = new TamThuc();
            Console.WriteLine("Nhap mot so co 3 chu so");
            d = (TamThuc)int.Parse(Console.ReadLine());
            d.XuatTamThuc();
            Console.WriteLine("-----------------------------------------------------");
            TamThuc e = new TamThuc();
            e = a++;
            e.XuatTamThuc();
            Console.WriteLine("-----------------------------------------------------");
            if (a==b)
            {
                Console.WriteLine("Hai tam thuc a va b bang nhau");
            }
            else
            {
                Console.WriteLine("Hai tam thuc a va b bang nhau");

            }
            Console.ReadLine();
        }
    }
}
