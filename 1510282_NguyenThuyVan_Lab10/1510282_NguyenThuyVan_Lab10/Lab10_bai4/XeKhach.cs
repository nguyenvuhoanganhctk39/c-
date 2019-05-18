using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai4
{
    class XeKhach:XeHoi
    {
        int soHanhKhach;
        public override string id()
        {
            return "Xe Khach";
        }
        public XeKhach(int tocdo, string bienso, string hangsx, int soHK) : base(tocdo, bienso, hangsx)
        {
            soHanhKhach = soHK;
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine(", {0} cho ngoi", soHanhKhach);
        }
    }
}
