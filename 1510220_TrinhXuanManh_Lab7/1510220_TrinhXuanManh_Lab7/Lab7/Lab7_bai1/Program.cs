using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_bai1
{
	class Program
	{
		class Dathuc
		{
			int[] a;
			int bac;
			public Dathuc()
			{
				a = new int[100];
			}
			public Dathuc(int bac)
			{
				this.bac = bac;
				a = new int[bac + 1];
			}


			// nhap da thuc
			public void Nhap()
			{
				bac = int.Parse(Console.ReadLine());
				a = new int[bac + 1];
				for (int i = 0; i <= bac; i++)
				{
					Console.WriteLine("He so thu {0} ", i + 1);
					a[i] = int.Parse(Console.ReadLine());
				}

			}


			// xuat da thuc
			public void XuatDaThuc()
			{
				string dathuc = "";
				for (int i = bac; i >= 0; i--)
				{
					if (a[i] != 0)
					{ 
						if (i == 0)
						{
							dathuc += a[i].ToString();
						}
						else if (i == 1)
						{
							dathuc += a[i].ToString() + "*x +";
						}
						else
						{
							dathuc += a[i].ToString() + "*x^" + i + "+";
						}
					}

				}
				Console.WriteLine(dathuc);
			}


			// cong hai da thuc
			public Dathuc CongDaThuc(Dathuc a, Dathuc b)
			{
				Dathuc c;
				if (a.bac < b.bac)
				{
					c = b;
					for (int i = 0; i <= a.bac; i++)
					{
						c.a[i] = a.a[i] + b.a[i];

					}
				}
				else
				{
					c = a;
					for (int i = 0; i <= b.bac; i++)
					{
						c.a[i] = a.a[i] + b.a[i];

					}
				}

				return c;
			}
			

			public static Dathuc operator +(Dathuc a, Dathuc b)
			{
				Dathuc c;
				if (a.bac < b.bac)
				{
					c = b;
					for (int i = 0; i <= a.bac; i++)
					{
						c.a[i] = a.a[i] + b.a[i];

					}
				}
				else
				{
					c = a;
					for (int i = 0; i <= b.bac; i++)
					{
						c.a[i] = a.a[i] + b.a[i];

					}
				}

				return c;
			}

			//tru ai da thuc
			public Dathuc TruDaThuc(Dathuc a, Dathuc b)
			{
				Dathuc c;
				if (a.bac < b.bac)
				{
					c = b;
					for (int i = 0; i <= a.bac; i++)
					{
						c.a[i] = a.a[i] - b.a[i];

					}
				}
				else
				{
					c = a;
					for (int i = 0; i <= b.bac; i++)
					{
						c.a[i] = a.a[i] - b.a[i];

					}
				}

				return c;
			}

			public static Dathuc operator -(Dathuc a, Dathuc b)
			{
				Dathuc c;
				if (a.bac < b.bac)
				{
					c = b;
					for (int i = 0; i <= a.bac; i++)
					{
						c.a[i] = a.a[i] - b.a[i];

					}
				}
				else
				{
					c = a;
					for (int i = 0; i <= b.bac; i++)
					{
						c.a[i] = a.a[i] - b.a[i];

					}
				}

				return c;
			}

			// dao ham da thuc
			public Dathuc DaoHam()
			{
				Dathuc c = new Dathuc(bac - 1);
				for (int i = c.bac; i >= 0; i--)
				{
					c.a[i] = a[i + 1] * (i + 1);
				}
				return c;
			}


		}
		static void Main(string[] args)
		{
			Dathuc a = new Dathuc();
			Dathuc b = new Dathuc();
			Dathuc c = new Dathuc();

			Console.WriteLine("Nhap bac da thuc thu nhat:");
			a.Nhap();
			Console.WriteLine("Da thuc thu nhat la: ");
			a.XuatDaThuc();

			Console.WriteLine("---------------------------------");
			Console.WriteLine("Nhap bac da thuc thu hai:");
			b.Nhap();
			Console.WriteLine("Da thuc thu hai la: ");
			b.XuatDaThuc();
			Console.WriteLine("---------------------------------");

			Console.WriteLine("Cong hai da thuc :");
			c.CongDaThuc(a, b).XuatDaThuc();

			Console.WriteLine("---------------------------------");

			Console.WriteLine("Tru hai da thuc :");
			c.TruDaThuc(a, b).XuatDaThuc();

			Console.WriteLine("---------------------------------");

			Console.WriteLine("Dao ham da thuc 1 :");
			a.DaoHam().XuatDaThuc();

			Console.WriteLine("---------------------------------");
			Console.WriteLine("Dao ham da thuc 2 :");
			b.DaoHam().XuatDaThuc();

			Console.ReadLine();

		}
	}
}