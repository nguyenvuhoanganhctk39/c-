using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
   public class SinhVien
    {
        private string ho;
        private string ten;
        private string mSSV;

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MSSV { get => mSSV; set => mSSV = value; }

        public SinhVien()
        {

        }
        public SinhVien(string Ho, string Ten, string MSSV)
        {
            this.Ho = Ho;
            this.Ten = Ten;
            this.MSSV = MSSV;
        }
        public void Xuat1sv()
        {
            Console.WriteLine(Ho + "\t\t" + Ten + "\t\t" + MSSV);
        }
    }
}
