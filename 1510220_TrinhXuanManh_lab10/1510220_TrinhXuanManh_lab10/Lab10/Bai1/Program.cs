using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
	class Point2D
	{
		protected int x, y;

		public void setxy(int toadoX, int toadoY)
		{
			x = toadoX;
			y = toadoY;
		}
		public Point2D(int toadoX, int toadoY)
		{
			this.x = toadoX;
			this.y = toadoY;
		}
		public Point2D()
		{

		}
		public void Xuat()
		{
			Console.WriteLine("({0},{1})", x, y);
		}


	}
	class Point3D : Point2D
	{
		int z;

		public Point3D(int toadoX, int toadoY, int z) : base(toadoX, toadoY)
		{
			this.z = z;
		}
		public Point3D()
		{
		}

		public void setxyz(int toadoX, int toadoY, int toadoZ)
		{
			x = toadoX;
			y = toadoY;
			z = toadoZ;
		}
		public new void Xuat()
		{
			Console.WriteLine("({0}, {1}, {2})", x, y, z);
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
			p3.setxyz(4, 5, 6);
			p3.Xuat();
			p3.Xuat();
			Console.ReadKey();
		}
	}
}
