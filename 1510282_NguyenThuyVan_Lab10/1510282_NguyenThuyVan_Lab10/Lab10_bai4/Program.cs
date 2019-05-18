using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai4
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            XeKhach c = new XeKhach(150, "49A-4444", "Toyota", 24);
            c.Xuat();
            Console.WriteLine();
            Console.WriteLine("Tham chieu cua lop co so xe hoi co the tro den doi tuong thuoc lop dan xuat xe khach");
            Console.WriteLine("Nhung chi co the goi ham xuat tuong ung voi xe hoi\n");
            XeHoi h = c;
            h.Xuat();
            Console.WriteLine("\n");
            XeTai t = new XeTai(150, "32B-5555", "Hyundai", 90);
            t.Xuat();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
