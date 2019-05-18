using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab10_bai5
{
     interface IODatabase
    {
        void Read(string filename);
        void Write(string filename);
        string Data { get; set; }
    }
    interface BaoMat
    {
        void Mahoa();
        void GiaiMa();
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Users\\THUY VAN\\Desktop\\test.txt";
            Document d = new Document("Hoc mon Open Source\n");
            d.Write(filename);
            d.Read(filename);
            Console.WriteLine("Du lieu trong file {0}  \n", d.Data);
            Console.WriteLine("Du lieu sau khi ma hoa:");
            d.Mahoa();
            Console.WriteLine(d.Data);
            Console.WriteLine("Du lieu sau khi giai ma:");
            d.GiaiMa();
            Console.WriteLine(d.Data);
           
            Console.WriteLine("=====================================");
            Console.WriteLine("Tong so tu trong file {0} la: ",filename);
            int kq = d.SoTu(filename);
            Console.WriteLine(kq);
            Console.ReadLine();
        }
    }
}
