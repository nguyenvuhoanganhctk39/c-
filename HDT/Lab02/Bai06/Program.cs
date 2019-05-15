using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    class Program
    {
        public class PhanSo
        {
            public int tuso;
            public int mauso;
            public int tuso2;
            public int mauso2;
            public PhanSo()
            {
                Console.Write("Nhap tu so phan so thu 1 : ");
                tuso = int.Parse(Console.ReadLine());
                Console.Write("Nhap mau so phan so thu 1 : ");
                mauso = int.Parse(Console.ReadLine());
                Console.Write("Nhap tu so phan so thu 2 : ");
                tuso2 = int.Parse(Console.ReadLine());
                Console.Write("Nhap mau so phan so thu 2 : ");
                mauso2 = int.Parse(Console.ReadLine());
            }

            public void show()
            {
                Console.WriteLine("Phan so thu nhat: {0}/{1}", tuso, mauso);

                Console.WriteLine("Phan so thu hai: {0}/{1}", tuso2, mauso2);

            }
            public void Cong()
            {
                int a = tuso * mauso2;
                int b = tuso2 * mauso;
                int c = mauso * mauso2;
                if (a + b == c)
                {
                    Console.WriteLine("Phan so a+ Phan so b = 1");
                }
                else
                    Console.WriteLine("Phan so a+ Phan so b = {0}/{1}", ((tuso * mauso2) + (tuso2 * mauso)), (mauso * mauso2));
            }

            public void Tru()
            {
                Console.WriteLine("Phan so a - Phan so b = {0}/{1}", ((tuso * mauso2) - (tuso2 * mauso)), (mauso * mauso2));
            }
            public void Nhan()
            {
                if (tuso == mauso2 && tuso2 == mauso)
                {
                    Console.WriteLine("Phan so a x Phan so b = 1");
                }
                else Console.WriteLine("Phan so a x Phan so b = {0}/{1}", (tuso * tuso2), (mauso * mauso2));
            }
            public void Chia()
            {
                Console.WriteLine("Phan so a / Phan so b = {0}/{1}", tuso * mauso2, (tuso2 * mauso));
            }
            public void SoSanh()
            {
                if (tuso / mauso > tuso2 / mauso2)
                {
                    Console.WriteLine("Phan so a lon hon phan so b");
                }
                else if (tuso / mauso < tuso2 / mauso2)
                {
                    Console.WriteLine("Phan so a nho hon phan so b");
                }
                else

                    Console.WriteLine("Phan so a bang phan so b");

            }
        }
        static void Main(string[] args)
        {
            PhanSo ob = new PhanSo();
            ob.show();
            ob.Cong();
            ob.Tru();
            ob.Nhan();
            ob.Chia();
            ob.SoSanh();
            Console.ReadLine();
        }
    }
}

