using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai4
{
    class XeTai:XeHoi:IODatabase
    {
        double TrongTai;
        public override string id()
        {
            return ("Xe Tai");
        }
        public XeTai(int tocdo, string bienso, string hangsx, double trongtai) : base(tocdo, bienso, hangsx)
        {
            TrongTai = trongtai;
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine(",Trong tai {0} tan",TrongTai);
        }
        string s = "";
        public new void Read(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string text;
          
            while((text = sr.ReadLine())!= null)
            {
                s = s + text;
            }
            sr.Close();
            fs.Close();
        }
        public new void Write(string filename)
        {
            FileStream fs;
            fs = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Close();
            fs.Close();
        }
    }
}
