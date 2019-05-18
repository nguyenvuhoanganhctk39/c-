using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Bai2
{
    class Program
    {
        class cosothaplucphan
        {
            int l, dn = 0, m;
            int s;
            int n;
            int temp;
           // char tlp;
            public cosothaplucphan()
            {
            }
            public void Nhap()
            {
                Console.Write("Nhap vao mot so thap phan:");
                 n = int.Parse(Console.ReadLine());
                Console.Write("So thap luc phan tuong ung cua {0} la: ",n);
                //Console.WriteLine(ThapLucPhan(n));
                ThapLucPhan(n);
            }
            public void Xuat()
            {
            }
            public void ThapLucPhan(int num)
            {
                for (l = num; l > 0; l = l / 16)
                {
                    temp = l % 16;
                    if (temp < 10)
                        temp = temp + 48;
                    else
                        temp = temp + 55;
                    dn = dn * 100 + temp;
                }
                for(int m = dn; m > 0; m = m/100)
                {
                   s = (m % 100);
                   Console.Write((char)s);
                }
               // return (char)s;
            }
            public int ThapPhan(string hex)
            {
                double tmp = 0;
                var chars = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                for(int i= 0; i<hex.Length; i++)
                {
                    var t = Convert.ToChar(hex.Substring(i,1));
                    for(int j=0; j < 16; j++)
                    {
                        if (t != chars[j])
                            continue;
                        tmp += j * (Math.Pow(16,hex.Length-(i + 1)));
                        break;
                    }
                }
                return (int)tmp;
            }
        }
        static void Main(string[] args)
        {
            cosothaplucphan ob = new cosothaplucphan();
            Console.WriteLine("\n\n=======Doi thap phan sang co so thap luc phan=======\n");
            ob.Nhap();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("=======Doi thap luc phan sang co so thap phan=======\n");
            
            Console.Write("Nhap vao 1 so thap luc phan: ");
            var hex = Convert.ToString(Console.ReadLine());
            Console.Write("So thap phan tuong ung cua so thap luc phan {0} la: ",hex);
            Console.Write(ob.ThapPhan(hex));
            Console.ReadKey();
        }
    }
}
