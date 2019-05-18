using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai1
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p2 = new Point2D(2,3);
           // p2.setxy(1, 2);
            p2.Xuat();
            Point3D p3 = new Point3D(3,4,5);
           // p3.setxyz(3, 4, 5);
            p3.Xuat();
            p3.Xuat();
            Console.ReadLine();
        }
    }
}
