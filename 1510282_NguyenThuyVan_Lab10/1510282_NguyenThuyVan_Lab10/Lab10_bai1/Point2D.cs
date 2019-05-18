using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai1
{
    class Point2D
    {
        protected int x, y;
        public Point2D(int toadoX, int toadoY)
        {
            x = toadoX;
            y = toadoY;
        }
        public void setxy(int toadox, int toadoy)
        {
            x = toadox;
            y = toadoy;
        }
        public void Xuat()
        {
            Console.Write("({0},{1})", x, y);
        }
    }
}
