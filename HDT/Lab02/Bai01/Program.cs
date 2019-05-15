using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo ob1 = new PhanSo(2,5);
            ob1.Show();
            PhanSo ob2 = new PhanSo(2, 5);
            ob1.Show();
            Console.ReadLine();
            return;
        }
    }
    class PhanSo
    {
        public int tuso;
        public int mauso;

        public PhanSo(int tu,int mau)
        {
            tuso = tu;
            mauso = mau;
        }
        public PhanSo(PhanSo ob)
        {
            tuso = ob.tuso;
            mauso = ob.mauso;
        }
        public void Show()
        {
            Console.WriteLine("{0}/{1}",tuso,mauso);
        }
    }
}
