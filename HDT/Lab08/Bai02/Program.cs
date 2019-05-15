using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bao02
{
    class Program
    {
        class cosothaplucphan
        {
            int[] a;
            public cosothaplucphan()
            {
                a = new int[16];
            }
            public int Nhap()
            {
                int dn = 0;
                int tmp;
                Console.Write("Nhap mot so thap phan: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = n; i > 0; i = i / 16)
                {
                    tmp = i % 16;
                    if (tmp < 10)
                        tmp = tmp + 48;
                    else
                        tmp = tmp + 55;
                    dn = dn * 100 + tmp;
                }

                return dn;
            }
            public void Xuat(int dn)
            {
                int s;
                Console.Write("\nSo thap luc phan (so Hexa) tuong duong la: ");
                for (int i = dn; i > 0; i = i / 100)
                {
                    s = i % 100;
                    Console.Write("{0}", (char)s);
                }
            }
            public void DtoH(int d)
            {
                string soHex="";

                int r = d % 16;
                if (d - r == 0)
                {
                    string c = toChar(r);
                    soHex += c;
                }
                else
                {
                    soHex += toChar(r);
                    DtoH((d - r) / 16);
                }
                Console.Write(soHex);

            }
            public string toChar(int r)
            {
                string s = "123456789ABCDEF";
                char[] c = s.ToCharArray();
                return c[r - 1].ToString();
            }
            public static cosothaplucphan operator +(cosothaplucphan a, cosothaplucphan b)
            {

            }
        }
        static void Main(string[] args)
        {
            cosothaplucphan a = new cosothaplucphan();
            cosothaplucphan b = new cosothaplucphan();
            cosothaplucphan c = new cosothaplucphan();
            a.Xuat(a.Nhap());
            Console.WriteLine("-------------------------------------------------------------------");
            b.Xuat(b.Nhap());
            Console.WriteLine("-------------------------------------------------------------------");
            c = a + b;

            Console.ReadKey();


        }
    }
}