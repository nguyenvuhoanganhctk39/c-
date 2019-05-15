using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        class Dathuc
        {
            int[] a;
            int bac;
            public Dathuc()
            {
                a = new int[100];
            }
            public Dathuc(int bac)
            {
                this.bac = bac;
                a = new int[bac + 1];
            }
            public void Nhap()
            {
                Console.WriteLine("Nhap bac da thuc");
                bac = int.Parse(Console.ReadLine());
                a = new int[bac + 1];
                for (int i = 0; i <= bac; i++)
                {
                    Console.WriteLine("He so thu {0} ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }

            }
            public void XuatDaThuc()
            {
                string dathuc = "";
                for (int i = bac; i >= 0; i--)
                {
                    if (a[i] != 0)
                    {
                        if (i == 0)
                        {
                            dathuc += a[i].ToString();
                        }
                        else if (i == 1 && a[0] == 0)
                        {
                            dathuc += a[i].ToString() + "*x^" + i;
                        }
                        else if (i == 1 && a[0] != 0)
                        {
                            dathuc += a[i].ToString() + "*x +";
                        }
                        
                        else
                        {
                            dathuc += a[i].ToString() + "*x^" + i + "+";
                        }
                    }

                }
                Console.WriteLine(dathuc);
            }
            public Dathuc CongDaThuc(Dathuc a, Dathuc b)
            {
                Dathuc c;
                if (a.bac < b.bac)
                {
                    c = b;
                    for (int i = 0; i <= a.bac; i++)
                    {
                        c.a[i] = a.a[i] + b.a[i];

                    }
                }
                else
                {
                    c = a;
                    for (int i = 0; i <= b.bac; i++)
                    {
                        c.a[i] = a.a[i] + b.a[i];

                    }
                }

                return c;
            }
            public Dathuc DaoHam()
            {
                Dathuc c = new Dathuc(bac - 1);
                for (int i = c.bac; i >= 0; i--)
                {
                    c.a[i] = a[i + 1] * (i + 1);
                }
                return c;
            }
            public static Dathuc operator +(Dathuc a, Dathuc b)
            {
                Dathuc c;
                if (a.bac < b.bac)
                {
                    c = b;
                    for (int i = 0; i <= a.bac; i++)
                    {
                        c.a[i] = a.a[i] + b.a[i];

                    }
                }
                else
                {
                    c = a;
                    for (int i = 0; i <= b.bac; i++)
                    {
                        c.a[i] = a.a[i] + b.a[i];

                    }
                }

                return c;
            }
            public Dathuc TruDaThuc(Dathuc a, Dathuc b)
            {
                Dathuc c;
                if (a.bac < b.bac)
                {
                    c = b;
                    for (int i = 0; i <= a.bac; i++)
                    {
                        c.a[i] = a.a[i] - b.a[i];

                    }
                }
                else
                {
                    c = a;
                    for (int i = 0; i <= b.bac; i++)
                    {
                        c.a[i] = a.a[i] - b.a[i];

                    }
                }

                return c;
            }
            public static Dathuc operator -(Dathuc a, Dathuc b)
            {
                Dathuc c;
                if (a.bac < b.bac)
                {
                    c = b;
                    for (int i = 0; i <= a.bac; i++)
                    {
                        c.a[i] = a.a[i] - b.a[i];

                    }
                }
                else
                {
                    c = a;
                    for (int i = 0; i <= b.bac; i++)
                    {
                        c.a[i] = a.a[i] - b.a[i];

                    }
                }

                return c;
            }

        }
        static void Main(string[] args)
        {
            Dathuc a = new Dathuc();
            Dathuc b = new Dathuc();
            Dathuc c = new Dathuc();


            a.Nhap();
            a.XuatDaThuc();

            Console.WriteLine("---------------------------------");
            b.Nhap();
            b.XuatDaThuc();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Cong hai da thuc :");
            c.CongDaThuc(a, b).XuatDaThuc();
            //c = a + b;
            //c.XuatDaThuc();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Tru hai da thuc :");
            c.TruDaThuc(a, b).XuatDaThuc();
            b.XuatDaThuc();
            //c = a - b;
            //c.XuatDaThuc();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Dao ham da thuc 1 :");
            a.DaoHam().XuatDaThuc();
            Console.ReadLine();
        }
    }
}
