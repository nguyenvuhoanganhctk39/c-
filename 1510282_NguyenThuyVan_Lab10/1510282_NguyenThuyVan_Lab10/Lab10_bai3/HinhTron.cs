using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai3
{
    class HinhTron
    {
        protected double r;
        public HinhTron() { }
        public HinhTron(double bk)
        {
            r = bk;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap vao ban kinh hinh tron: ");
            r = double.Parse(Console.ReadLine());
        }
        public double DienTich()
        {
            return r * r * Math.PI;
        }
    }
}
