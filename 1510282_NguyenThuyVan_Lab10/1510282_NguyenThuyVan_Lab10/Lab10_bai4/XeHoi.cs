using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab10_bai4
{
    interface IODatabase
    {
        void Read(string filename);
        void Write(string filename);
        string Data { get; set; }
    }
    class XeHoi
    {
        protected int Tocdo;
        protected string Bienso;
        protected string HangSX;
      
        public virtual string id()
        {
            return "Xe Hoi";
        }
        public XeHoi(int tocdo, string bienso, string hangsx)
        {
           // Id = id;
            Tocdo = tocdo;
            Bienso = bienso;
            HangSX = hangsx;
        }
        public void Xuat()
        {
            Console.Write("Xe: {0}, ID: {1}, Bien so: {2}, Toc do: {3} Kmh", HangSX, id(), Bienso, Tocdo);
        }
    }
}
