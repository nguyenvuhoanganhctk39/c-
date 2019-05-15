using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        class Dathuc
        {
            const int MAX = 10;
            int[,] a;
            int bac;
            public Dathuc()
            {
                a = new int[MAX, MAX];
            }
            public void NhapDaThuc()
            {
                bac = 0;
                while (true)
                {
                    Console.Write("Nhap he so thu {0} :", bac + 1);
                    int heso = int.Parse(Console.ReadLine());
                    Console.Write("Nhap he so mu thu {0} :", bac + 1);
                    int somu = int.Parse(Console.ReadLine());

                    if (somu == -1)
                    {
                        a[bac, 1] = -1;
                        break;
                    }
                    else if (heso != 0)
                    {
                        a[bac, 0] = heso;
                        a[bac, 1] = somu;
                        bac++;
                    }
                }
            }
            public void XuatDathuc()
            {
                string dathuc = "";
                for (int i = 0; i < bac; i++)
                {

                    if (i==bac-1)
                    {
                        dathuc += a[i, 0].ToString() + "*x^" + a[i, 1];
                    }
                    else
                    {
                        dathuc += a[i, 0].ToString() + "*x^" + a[i, 1] + "+";
                    }
                }
                Console.WriteLine("{0}", dathuc);
            }

            public void Sapxep()
            {
                int hesotemp = 0;
                int somutemp = 0;

                for (int i = 0; i < bac-1; i++)
                {

                    for (int j = i+1; j <bac; j++)
                    {
                        if (a[i, 1] <= a[j, 1])
                        {
                            hesotemp = a[i, 0];
                            somutemp = a[i, 1];

                            a[i, 0] = a[j, 0];
                            a[i, 1] = a[j, 1];

                            a[j, 0] = hesotemp;
                            a[j, 1] = somutemp;
                        }
                    }

                }
            }
            public void RutGon()
            {
                for (int i = 0; i < bac; i++)
                {

                    if (a[i, 1] == a[i + 1, 1])
                    {
                        a[i, 0] = a[i, 0] + a[i + 1, 0];
                        a[i, 1] = a[i + 1, 1];

                        for (int j = i+1; j < bac; j++)
                        {
                            a[j, 0] = a[j + 1, 0];
                            a[j, 1] = a[j + 1, 1];
                        }
                        bac--;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Dathuc a = new Dathuc();
            Dathuc c = new Dathuc();
            Dathuc b = new Dathuc();
            a.NhapDaThuc();
            //a.RutGon(a).XuatDathuc();
            a.Sapxep();
            a.RutGon();
            a.XuatDathuc();


            Console.ReadLine();
        }
    }
}
