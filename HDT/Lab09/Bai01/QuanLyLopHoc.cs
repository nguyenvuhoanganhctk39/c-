using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    public class QuanLyLopHoc
    {
        SinhVien[] sv;
        int count;

        public QuanLyLopHoc()
        {
            sv = new SinhVien[100];
            count = 0;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap so luong hoc sinh");
            count = int.Parse(Console.ReadLine());
            sv = new SinhVien[count];
            for (int i = 0; i < count; i++)
            {
                sv[i] = new SinhVien();
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                Console.WriteLine("Nhap ho");
                sv[i].Ho = Console.ReadLine();
                Console.WriteLine("Nhap ten");
                sv[i].Ten = Console.ReadLine();
                Console.WriteLine("Nhap MSSV");
                sv[i].MSSV = Console.ReadLine();
            }

        }
        public void Xuat()
        {
            XuatTieuDe();
            for (int i = 0; i < count; i++)
            {
                sv[i].Xuat1sv();
            }
        }
        public void XuatTieuDe()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("Ho: \t\tTen: \t\tMSSV:");
            Console.WriteLine("===================================================");

        }
        public void ThemSinhVien(SinhVien a)
        {
            sv[count] = a;
            count++;
        }
        public void TimKiem(string hoten)
        {
            XuatTieuDe();
            for (int i = 0; i < count; i++)
            {
                if (sv[i].Ho == hoten || sv[i].Ten == hoten || sv[i].MSSV == hoten)
                {
                    sv[i].Xuat1sv();
                }
            }
        }
        public void XoaSV(string hoten)
        {
            int i = 0, j = 0;
            while (i < count)
            {
                if (sv[i].Ho == hoten || sv[i].Ten == hoten || sv[i].MSSV == hoten)
                {
                    sv[i] = sv[i + 1];
                    j = 1;
                    count--;
                }
                else if (j == 1)
                {
                    sv[i] = sv[i + 1];
                }
                i++;
            }
        }

    }
}
