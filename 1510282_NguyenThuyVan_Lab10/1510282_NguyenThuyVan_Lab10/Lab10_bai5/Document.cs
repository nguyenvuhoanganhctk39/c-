using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab10_bai5
{
   public class Document:IODatabase,BaoMat
    {
        string S;
        public Document(string str)
        {
            S = str;
        }

        public string Data
        {
            get
            {
                return S;
            }

            set
            {
                S = value;
            }
        }

        public void GiaiMa()
        {
            string kq = "";
            for (int i = 0; i < S.Length; i++)
            {
                kq = kq + (char)((int)S[i] - 5);
                S = kq;
            }
        }

        public void Mahoa()
        {
            string kq = "";for(int i=0; i< S.Length; i++)
            {
                kq = kq + (char)((int)S[i] + 5);
                S = kq;
            }
        }

        public void Read(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string text;

            while ((text = sr.ReadLine()) != null)
            {
                S = S + text;
            }
            sr.Close();
            fs.Close();
        }
        public void Write(string filename)
        {
            FileStream fs;
            fs = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(S);
            sw.Close();
            fs.Close();
        }
        public int SoTu(string filename)
        {
            int st=0;
            //Read(filename);
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string text;
            
            while ((text = sr.ReadLine()) != null)
            {
                S = S + text;
            }
            if(S != null)
            {
                string[] words = S.Split(' ');
                st += words.Length;
            }
            return st;
        }
        public int SoKyTu(string filename)
        {
            int skt = 0;
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string text;

            while ((text = sr.ReadLine()) != null)
            {
                S = S + text;
            }
            if (S != null)
            {
                string[] words = S.Split(' ');
                skt += words.Length;
            }
            return skt;
        }
    }
}
