using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
	class HinhTron
	{
		protected int bankinh;
		public HinhTron()
		{

		}
		public HinhTron(int bk)
		{
			this.bankinh = bk;
		}
		public double DienTich()
		{
			return (Math.PI * bankinh * bankinh);
		}
	}

	class HinhCau : HinhTron
	{
		public HinhCau(int bk) : base(bk)
		{
			bankinh = bk;
		}
		public double DienTichHC()
		{
			return (Math.PI * 4 * bankinh * bankinh);
		}
		public double TheTichHC()
		{
			return (Math.PI * 4 / 3 * bankinh * bankinh * bankinh);
		}
	}

	class Program
	{

		static void Main(string[] args)
		{
			HinhTron ht = new HinhTron(10);
			Console.WriteLine("dien tich hinh tron la: {0}", ht.DienTich());



			HinhCau hc = new HinhCau(5);
			Console.WriteLine("dien tich hinh cau la: {0}", hc.DienTichHC());
			Console.WriteLine("the tich hinh cau la: {0}", hc.TheTichHC());

			Console.ReadLine();

		}
	}
}
