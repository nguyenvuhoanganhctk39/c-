using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Point2D
    {
        protected int x, y;
        public void setxy(int toadox, int taodoy)
        {
            x = toadox;
            y = taodoy;
        }
        public void Xuat()
        {
            Console.Write("\nToa do x:{0},y:{1}",x,y);
        }

    }
    class Point3D : Point2D
    {
        int z;
        public void setxyz(int toadoX, int toadoY, int toadoZ)
        {
            x = toadoX;
            y = toadoY;
            z = toadoZ;
        }
        public new void Xuat()
        {
            base.Xuat(); Console.Write(",z:{0}",z);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p2 = new Point2D();
            p2.setxy(1, 2);
            p2.Xuat();
            Point3D p3 = new Point3D();
            p3.setxyz(3, 4, 5);
            p3.Xuat();
            Console.ReadLine();

        }
    }
}
