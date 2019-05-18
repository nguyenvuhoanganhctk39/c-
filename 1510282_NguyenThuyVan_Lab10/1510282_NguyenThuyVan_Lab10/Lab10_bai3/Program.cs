using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron ht = new HinhTron();
            ht.Nhap();
            Console.WriteLine( ht.DienTich());
            HinhCau hc = new HinhCau();
            hc.Nhap();
            Console.WriteLine("Dien tich hinh cau: {0} ",hc.DienTich());
            Console.WriteLine("The tich hinh cau: {0} ", hc.TheTich());
            Console.ReadLine();
        }
    }
}
