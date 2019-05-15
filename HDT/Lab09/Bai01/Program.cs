using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyLopHoc qllh = new QuanLyLopHoc();
            int menu = 1;
            //qllh.Nhap();
            qllh.ThemSinhVien(new SinhVien("Dam", "Duy", "1510191"));
            qllh.ThemSinhVien(new SinhVien("Nghiem", "Hieu", "1510198"));
            qllh.ThemSinhVien(new SinhVien("Trinh", "Manh", "1510220"));
            qllh.ThemSinhVien(new SinhVien("Nguyen", "Ha", "1510195"));


            while (menu > 0)
            {
                Console.WriteLine("0.Thoat");
                Console.WriteLine("1.Xem DS sinh vien");
                Console.WriteLine("2.Nhap tu ban phim");
                Console.WriteLine("3.Tim kiem sinh vien");
                Console.WriteLine("4.Them sinh vien");
                Console.WriteLine("5.Xoa sinh vien");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        break;
                    case 1:
                        qllh.Xuat();
                        break;
                    case 2:
                        qllh.Nhap();
                        qllh.Xuat();
                        break;
                    case 3:
                        Console.WriteLine("Nhap ho, ten hoac mssv");
                        qllh.TimKiem(Console.ReadLine());
                        break;
                    case 4:
                        SinhVien a = new SinhVien();
                        Console.WriteLine("Nhap ho");
                        a.Ho = Console.ReadLine();
                        Console.WriteLine("Nhap ten");
                        a.Ten = Console.ReadLine();
                        Console.WriteLine("Nhap MSSV");
                        a.MSSV = Console.ReadLine();
                        qllh.ThemSinhVien(a);
                        break;
                    case 5:
                        Console.WriteLine("Nhap ho, ten hoac mssv can xoa");
                        qllh.XoaSV(Console.ReadLine());
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }


}
