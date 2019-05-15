using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    class Program
    {
        public class PhanSo
        {
            public int tuso;
            public int mauso;
            public PhanSo()
            {

            }
            public PhanSo(int tu)
            {
                tuso = tu;
                mauso = 1;
            }
            public PhanSo(int tu, int mau)
            {
                tuso = tu;
                mauso = mau;

            }
            public static PhanSo operator +(PhanSo a, PhanSo b)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = (a.tuso * b.mauso + b.tuso * a.mauso);
                kq.mauso = (a.mauso * b.mauso);
                return kq;
            }
            public static PhanSo operator -(PhanSo a, PhanSo b)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = (a.tuso * b.mauso - b.tuso * a.mauso);
                kq.mauso = (a.mauso * b.mauso);
                return kq;
            }
            public static PhanSo operator /(PhanSo a, PhanSo b)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = (a.tuso * b.mauso);
                kq.mauso = (a.mauso * b.tuso);
                return kq;
            }
            public static PhanSo operator *(PhanSo a, PhanSo b)
            {
                PhanSo kq = new PhanSo();
                kq.tuso = (a.tuso * b.tuso);
                kq.mauso = (a.mauso * b.mauso);
                return kq;
            }
            public static bool operator !=(PhanSo a, PhanSo b)
            {
                return !(a == b);
            }
            public static bool operator ==(PhanSo a, PhanSo b)
            {
                return (a == b);
            }
            public void ShowPhanSo()
            {
                Console.WriteLine("{0}/{1}", tuso, mauso);
            }


        }
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo(2, 3);
            PhanSo b = new PhanSo(2, 5);
            PhanSo c = new PhanSo();
            PhanSo d = new PhanSo();
            PhanSo e = new PhanSo();
            PhanSo f = new PhanSo();

            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;

            Console.WriteLine("Cong 2 phan so");
            c.ShowPhanSo();
            Console.WriteLine("Tru 2 phan so");
            d.ShowPhanSo();
            Console.WriteLine("Nhan 2 phan so");
            e.ShowPhanSo();
            Console.WriteLine("Chia 2 phan so");
            f.ShowPhanSo();
            Console.ReadLine();
        }
    }
}
