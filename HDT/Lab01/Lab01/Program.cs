using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class HCN
    {
        double Hinhchunhat;
        public double SetHCN() {
            Console.WriteLine("Nhap chieu dai");
            return;

        }
        public double Chieurong { get => chieurong; set => chieurong = value; }
        public double DienTich ()
        {
            return chieudai * chieurong;
        }
        public double ChuVi()
        {
            return( chieudai + chieurong)*2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
