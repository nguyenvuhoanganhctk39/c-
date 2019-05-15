using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{

    class Program
    {
        class SoPhuc
        {
           public float a, b;
            public SoPhuc(float a, float b)
            {
                this.a = a;
                this.b = b;
            }
            public SoPhuc()
            {
                this.a = 0;
                this.b = 0;
            }
            public void NhapSoPhuc()
            {
                Console.WriteLine("Nhap phan thuc");
                this.a = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap phan ao");
                this.b = float.Parse(Console.ReadLine());
            }
            public void XuatSoPhuc()
            {
                Console.WriteLine("So phuc : {0} + {1}*i", a, b);
            }
            public static SoPhuc operator +(SoPhuc a, SoPhuc b)
            {
                SoPhuc c = new SoPhuc();
                c.a = a.a + b.a;
                c.b = a.b + b.b;
                return c;
            }
            public static SoPhuc operator -(SoPhuc a, SoPhuc b)
            {
                SoPhuc c = new SoPhuc();
                c.a = a.a - b.a;
                c.b = a.b - b.b;
                return c;
            }
            public static SoPhuc operator *(SoPhuc a, SoPhuc b)
            {
                SoPhuc c = new SoPhuc();
                c.a = a.a * b.a - a.b * b.b;
                c.b = a.a * b.b + a.b * b.a;
                return c;
            }
            public static bool operator ==(SoPhuc a, SoPhuc b)
            {
                
                return a.a==b.a && a.b==b.b;
            }
            public static bool operator !=(SoPhuc a, SoPhuc b)
            {
                return a.a != b.a;
            }
            public static SoPhuc operator /(SoPhuc a, SoPhuc b)
            {
                return new SoPhuc((float)Math.Round((a.a * b.a + a.b * b.b)/(b.a*b.a+b.b *b.b),2), (b.a * a.b - a.a * b.b)/ (b.a * b.a + b.b * b.b));
            }
            public void Kiemtra()
            {
                if (this.a==0)
                {
                    Console.WriteLine("So phuc nay la so thuan ao");
                }
                else if(this.b==0)
                {
                    Console.WriteLine("So phuc nay la so thuc");
                }
                else
                {
                    Console.WriteLine("So phuc nay la so phuc");
                }
            }

        }
        static void Main(string[] args)
        {
            SoPhuc a = new SoPhuc();
            SoPhuc b = new SoPhuc(3, 4);
            SoPhuc c = new SoPhuc();
            a.NhapSoPhuc();
            Console.Write("So phuc a ");
            a.XuatSoPhuc();
            Console.Write("So phuc b ");
            b.XuatSoPhuc();
            c = a + b;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Cong 2 so phuc");
            c.XuatSoPhuc();
            c = a - b;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Tru 2 so phuc");
            c.XuatSoPhuc();
            c = a * b;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Nhan 2 so phuc");
            c.XuatSoPhuc();
            c = a / b;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Chia 2 so phuc");
            c.XuatSoPhuc();
            Console.WriteLine("-----------------------------------------------------------------");
            if (a==b)
            {
                Console.WriteLine("Hai so phuc a va b bang nhau");
            }
            else
            {
                Console.WriteLine("Hai so phuc ava b khac nhau");
            }
            Console.WriteLine("-----------------------------------------------------------------");
            a.Kiemtra();
            Console.WriteLine("-----------------------------------------------------------------");
            b.Kiemtra();


        }
    }
}
