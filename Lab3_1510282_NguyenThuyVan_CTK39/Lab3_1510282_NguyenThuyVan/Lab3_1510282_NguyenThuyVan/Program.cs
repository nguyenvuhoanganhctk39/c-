using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1510282_NguyenThuyVan
{
    class Program
    {
        class Tamthuc
        {
            int a, b, c;
            public Tamthuc()
            {  }
           
            public Tamthuc(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
           
            public void Nhap()
            {
                Console.WriteLine("Nhap he so a,b,c lan luot: {0},{1},{2} ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            }
            public void Xuat()
            {
                if(c >= 0)
                    Console.WriteLine("Tam thuc: {0}x^2 + {1}x + {2}",a,b,c);
                else
                    Console.WriteLine("Tam thuc: {0}x^2 + {1}x  {2}",a,b,c);
            }
            public static Tamthuc operator +(Tamthuc t1, Tamthuc t2)
            {
                Tamthuc kq = new Tamthuc();
                kq.a = t1.a + t2.a;
                kq.b = t1.b + t2.b;
                kq.c = t1.c + t2.c;
                return kq;
            }
            public static Tamthuc operator -(Tamthuc t1, Tamthuc t2)
            {
                Tamthuc kq = new Tamthuc();
                kq.a = t1.a - t2.a;
                kq.b = t1.b - t2.b;
                kq.c = t1.c - t2.c;
                return kq;
            }
            public static Tamthuc operator *(Tamthuc t, int n)
            {
                Tamthuc kq = new Tamthuc();
                kq.a = t.a * n;
                kq.b = t.b * n;
                kq.c = t.c * n;
                return kq;
            }
            public static Tamthuc operator ++(Tamthuc t1)
            {
                Tamthuc kq = new Tamthuc();
                kq.c = t1.c + 1;
                return kq;
            }

            public static bool operator ==(Tamthuc t1, Tamthuc t2)
            {
                return (t1.a == t2.a && t1.b == t2.b && t1.c == t2.c);
            }
            public static bool operator !=(Tamthuc t1, Tamthuc t2)
            {
                return !(t1==t2);
            }
            public override string ToString()
            {
                string s = a.ToString() + "x^2" +" + "+ b.ToString() + "x" +" + "+ c.ToString();
                return s;
            }
            //ep kieu tuong minh tam thuc co nghiem?
            public static explicit operator bool(Tamthuc t)
            {
                double d = t.b * t.b - 4 * t.a * t.c;
                return d >= 0;
            }
            //ep kieu ngam dinh
            public static implicit operator Tamthuc(int n)
            {
                Tamthuc t = new Tamthuc();
                t.a = n / 100;
                t.b = (n % 100) / 10;
                t.c = n % 10;
                return t;


              }
            }
        static void Main(string[] args)
        {
            Tamthuc t3 = new Tamthuc();
            t3.Nhap();
            Console.WriteLine("Tam thuc vua nhap: ");
            t3.Xuat();
            Tamthuc t1 = new Tamthuc(2, 3, 4);
            Tamthuc t2 = new Tamthuc(2, 1, -4);
            t1.Xuat();
            t2.Xuat();
            
            Tamthuc kq = new Tamthuc();
            //cong 2 tam thuc
            kq = t1 + t2;
            Console.WriteLine("Cong hai tam thuc: "); 
            Console.WriteLine("Tam thuc: ({0}) + Tam thuc ({1}) = {2} ", t1.ToString(), t2.ToString(),kq.ToString());
            
            //tru hai tam thuc
            kq = t1 - t2;
            Console.WriteLine("Tru hai tam thuc ");
            Console.WriteLine("Tam thuc: ({0}) - Tam thuc ({1}) = {2} ", t1.ToString(), t2.ToString(), kq.ToString());
            //toan tu * voi mot so
            int n;
            Console.WriteLine("Nhap n:");
            n = int.Parse(Console.ReadLine());
            kq = t2 * n;
            Console.WriteLine("Tam thuc ({0}) * {1} = {2}:",t2.ToString(),n,kq.ToString());
            Console.ReadLine();
            //toan tu ++ them 1

            //ep kieu tg minh tam thuc co nghiem

            bool nghiem = (bool)t1;
            Console.WriteLine("Ep kieu tuong minh tam thuc co nghiem? ");
            if (nghiem)
                Console.WriteLine("Tam thuc {0} co nghiem",t1.ToString());
            else
                Console.WriteLine("Tam thuc {0} vo nghiem",t1.ToString());

            //ep kieu ngam dinh
            Tamthuc num;
            Console.WriteLine("NHap so tu nhien co 3 chu so: num =");
            
            num =(Tamthuc)int.Parse(Console.ReadLine());
            num.Xuat();
            
            Console.ReadLine();
        }
    }
}
