using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bao01
{
    class Program
    {
        class cosonhiphan
        {
            int[] a;
            byte num;
            public cosonhiphan(byte num)
            {
                this.num = num;
                a = new int[8];
                DoiNhiPhan(num);

            }
            public cosonhiphan()
            {
                a = new int[8];

            }
            public void Nhap()
            {
                Console.Write("Nhap so thap phan: ");
                int n = Convert.ToInt32(Console.ReadLine());
                DoiNhiPhan(n);
            }
            public void Xuat()
            {
                for (int i = 7; i >=0; i--)
                {
                    Console.Write("{0}",a[i]);
                }
            }
            public static cosonhiphan operator +(cosonhiphan a,cosonhiphan b )
            {
                cosonhiphan s = new cosonhiphan();
                s.a[7] = 1;
                for (int i = 0; i < 7; i++)
                {                 
                    if (a.a[i]==1 && b.a[i]==1)
                    {
                        s.a[i] = 0;
                        a.a[i + 1] = a.a[i + 1] + 1;
                    }
                    else if(a.a[i] +b.a[i]>=2)
                    {
                        s.a[i] = (a.a[i]+b.a[i])%2;
                        a.a[i+1] = a.a[i + 1] + 1;
                    }
                    else
                    {
                        s.a[i] = a.a[i] + b.a[i];
                    }

            }
                return s;
            }
            public static cosonhiphan operator -(cosonhiphan a,cosonhiphan b )
            {
                cosonhiphan s = new cosonhiphan();
                
                for (int i = 0; i < 7; i++)
                {
                   
                    if (a.a[i]==0 && b.a[i]==1)
                    {
                        s.a[i] = 1;
                        b.a[i + 1] = b.a[i + 1] + 1;
                    }
                    else if (a.a[i] - b.a[i] < 0)
                    {
                        s.a[i] = 0;
                        b.a[i + 1] = b.a[i + 1] + 1;
                    }
                    else
                    {
                        s.a[i] = a.a[i] - b.a[i];
                    }

            }
                return s;
            }
            public void DoiNhiPhan(int n)
            {
                int k = 0;
                if(n>0)
                {
                    a[7] = 1;
                }
                else
                {
                    a[7] = 0;
                    n *= -1;
                }
                do
                {
                    int du = n % 2;
                    a[k] = du;
                    k++;
                    n = n / 2;
                } while (n > 0);
            }
            public void DoiThapPhan()
            {
                int n;
                double dec = 0, i = 0, d;

                Console.WriteLine("\nNhap so trong he nhi phan: ");
                n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    d = n % 10;
                    dec = dec + d * Math.Pow(2, i); // su dung ham trong C#
                    n = n / 10;
                    i++;
                }
                Console.Write("\nSo thap phan tuong duong la: {0}\n\n", dec);
            }
            public double DoiSoThapPhan(int n)
            {
                double dec = 0, i = 0, d;
                while (n != 0)
                {
                    d = n % 10;
                    dec = dec + d * Math.Pow(2, i);
                    n = n / 10;
                    i++;
                }
                return dec;
            }

        }
        static void Main(string[] args)
        {
            cosonhiphan coso1 = new cosonhiphan();
            coso1.Nhap();
            coso1.Xuat();

            Console.WriteLine("\n----------------------------------------------------");
            cosonhiphan coso2 = new cosonhiphan();
            coso2.Nhap();
            coso2.Xuat();
            Console.WriteLine("\n----------------------------------------------------");
            cosonhiphan coso3 = new cosonhiphan();

            Console.Write("\nCong hai so nhi phan: ");
            coso3 = coso1 + coso2;
            coso3.Xuat();

            Console.Write("\nTru hai so nhi phan: ");
            coso3 = coso1 - coso2;
            coso3.Xuat();

            Console.ReadLine();
        }
    }
}
