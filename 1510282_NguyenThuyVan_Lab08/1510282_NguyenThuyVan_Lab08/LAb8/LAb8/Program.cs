using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        class cosonhiphan
        {
            public int[] m = new int[8];
            public int n;
            public cosonhiphan()
            {
            }
            string s = "";
            public void Nhap()
            {
                Console.WriteLine("Nhap vao mot so nguyen bat ky: ");
                n = int.Parse(Console.ReadLine());
                //Binary(n);
                for (int i = 0; i <= 7; i++)
                {
                    m[7 - i] = n % 2;
                    n = n / 2;
                }
                for (int j = 0; j <= 7; j++)
                {
                    s += m[j].ToString();
                }

            }
            public void Xuat()
            {
                Console.WriteLine("Co so nhi phan tuong ung voi so thap phan vua nhap la: ");
                Console.WriteLine(s);
            }    
            public string NhiPhan(int num)
            {
                string p = "";
                for (int i = 0; i <= 7; i++)
                {
                    m[7 - i] = num % 2;
                    num = num / 2;
                }
                for (int j = 0; j <= 7; j++)
                {
                    p += m[j].ToString();
                }
                return p;
            }
            public void  ThapPhan(int num)
            {
                int i = 0;
                double d, dec=0;
              //  int n = num;
                while (num != 0)
                {
                    d = num % 10;
                    dec = dec + d * Math.Pow(2, i); // su dung ham trong C#
                    num = num / 10;
                    i++;
                }
                Console.WriteLine(dec);
            }
            public  int  Cong (int a, int b)
            {
                int du, d, s, j, c = 0;
                du = 0;
                for (j = 0; j <= 8; j++)
                {
                    d = (bit(a, j) + bit(b, j) + du) / 2;
                    s = bit(a, j) + bit(b, j) + du - 2 * d;
                    c = c - (s *j);
                    du = d;
                }
                return (c);
            } 
            public  int bit(int a, int k)
            {
                int j = 1;
                if (a == j * k)
                    return 1;
                return 0;
            }

        }
        static void Main(string[] args)
        {
            cosonhiphan ob = new cosonhiphan();
            ob.Nhap();
            ob.Xuat();
            Console.WriteLine("Doi so thap phan thanh nhi phan");
            Console.Write("Nhap vao mot so nguyen bat ky: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("So nhi phan tuong ung voi so thap phan {0} la: ", num);
            Console.WriteLine(ob.NhiPhan(num));
            Console.WriteLine("===========================================================");
            Console.WriteLine("Doi so nhi phan thanh thap phan");
            Console.Write("Nhap vao mot so nhi phan bat ky: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So thap phan tuong ung cua so nhi phan {0} la:", n);
            ob.ThapPhan(n);
            Console.Write("Nhap vao mot so nhi phan bat ky: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao mot so nhi phan bat ky: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cong hai so nhi phan {0} va {1} la:",n1,n2);
            int k = ob.Cong(n1, n2);
            Console.WriteLine(ob.NhiPhan(k));
            Console.ReadLine();
        }
    }
}
