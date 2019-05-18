using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai1
{
    class Point3D:Point2D
    {
        int z;
        public Point3D(int toadoX, int toadoY, int toadoZ) : base(toadoX, toadoY)
        {
            z = toadoZ;
        }
        public void setxyz(int toadox, int toadoy, int toadoz)
        {
            x = toadox;
            y = toadoy;
            z = toadoz;
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine(",{0})", z);
        }
    }
}
