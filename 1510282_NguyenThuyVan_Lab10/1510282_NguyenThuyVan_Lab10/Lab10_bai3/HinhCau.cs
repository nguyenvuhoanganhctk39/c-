using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai3
{
    class HinhCau:HinhTron
    {
       new double  r;
        public HinhCau() { }
        public HinhCau(double bk) : base(bk)
        {
            r = bk;
        }
        public new void Nhap()
        {
            Console.WriteLine("Nhap vao ban kinh hinh cau: ");
            r = double.Parse(Console.ReadLine());
        }
        public new double DienTich()
        {
            return 4 * r * r * Math.PI;
        }
        public double TheTich()
        {
            return DienTich() * r / 3;
        }
    }
}
