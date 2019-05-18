using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
	class XeHoi
	{
		private string iD;
		protected int tocDo;
		protected string bienSo;
		protected string hangSX;

		protected string ID { get => iD; set => iD = value; }
		protected int TocDo { get => tocDo; set => tocDo = value; }
		protected string BienSo { get => bienSo; set => bienSo = value; }
		protected string HangSX { get => hangSX; set => hangSX = value; }

		public XeHoi(string id, int td, string BS, string HSX)
		{
			this.ID = id;
			TocDo = td;
			BienSo = BS;
			HangSX = HSX;
		}

		public void Xuat()
		{
			Console.WriteLine("Xe: {0}, Bien so: {1}, Toc do {2} km/h", HangSX, BienSo, TocDo);
		}
	}
	class XeTai : XeHoi
	{
		double TrongTai;

		public XeTai(int td, string BS, string HSX, double TT) : base("Xe tai", td, BS, HSX)
		{
			TrongTai = TT;
		}

		public double TrongTai1 { get => TrongTai; set => TrongTai = value; }

		public new void Xuat()
		{
			Console.WriteLine("Xe: {0}, Bien so: {1}, Toc do {2} km/h, Trong tai: {3} tan", HangSX, BienSo, TocDo, TrongTai1);
		}
	}

	class XeKhach : XeHoi
	{
		int SoHanhKhach;

		public XeKhach(int td, string BS, string HSX, int SHK) : base("Xe khach", td, BS, HSX)
		{
			SoHanhKhach1 = SHK;
		}

		public int SoHanhKhach1 { get => SoHanhKhach; set => SoHanhKhach = value; }

		public new void Xuat()
		{
			base.Xuat();
			Console.WriteLine(", {0} cho ngoi", SoHanhKhach1);
		}
	}



	class Program
	{
		static void Main(string[] args)
		{
			XeKhach c = new XeKhach(150, "49A-4444", "toyota", 24);
			c.Xuat();
			Console.WriteLine();
			Console.WriteLine("Tham chieu cau lop xehoi cos the tro den doi tuonng thuoc lop dan xuat xe khach");
			Console.WriteLine("Nhung chi co the goi ham tuong ung voi xehoi");
			XeHoi h = c;
			h.Xuat();
			Console.ReadLine();
		}
	}
}
