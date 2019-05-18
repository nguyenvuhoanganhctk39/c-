using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaThuc
{
    class Program
    {
        class Dathuc
        {
            int n;
            const int MAX = 100;
            double[] dt;
            public Dathuc()
            {
                dt = new double[MAX];
            }
            public void Nhap()
            {
                Console.WriteLine("Nhap vao bac cua da thuc: ");
                n = int.Parse(Console.ReadLine());
                for(int i=n; i>=0; i--)
                {
                    Console.WriteLine("Nhap vao cac gia tri he so thu {0}: ",i);
                    dt[i] = double.Parse(Console.ReadLine());
                }
            }
            public void Xuat()
            {
                string dathuc = "";
                Console.WriteLine("Xuat da thuc bac {0} ", n);
                for (int i =n; i>=0; i--)
                {
                    if(dt[i] !=0)
                    {
                        if(i !=0 && dt[i-1]!= 0)
                        {
                            dathuc += dt[i].ToString() + "*x^" + i + " + ";
                        }
                        else
                        { dathuc += dt[i].ToString(); }
                    }
                }
                Console.WriteLine(dathuc);
            }
            public static  Dathuc operator +(Dathuc dt1, Dathuc dt2)
            {
                Dathuc kq = new Dathuc();
                
                return kq;
            }

        }
        static void Main(string[] args)
        {
            Dathuc dt = new Dathuc();
            dt.Nhap();
            Console.WriteLine("Da thuc vua nhap la: ");
            dt.Xuat();
            Console.ReadLine();
        }
    }
}
