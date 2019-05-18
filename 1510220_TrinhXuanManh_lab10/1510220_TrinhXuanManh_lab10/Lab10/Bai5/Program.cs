using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bai5
{

	interface IODatabase
	{
		void Read(string FileName);
		void Write(string FileName);
		string Data { get; set; }
	}

	interface BaoMat
	{
		void MaHoa();
		void GiaiMa();
	}

	public class Document : IODatabase, BaoMat
	{
		string S;

		public Document(string str)
		{
			S = str;
		}

		public void Read(string FileName)
		{
			FileStream fs = new FileStream(FileName, FileMode.Open);

			StreamReader sr = new StreamReader(fs);

			string text;
			S = "";
			while ((text = sr.ReadLine()) != null)
			{
				S = S + text;
			}
			sr.Close();
			fs.Close();
		}
		public void Write(string FileName)
		{
			FileStream fs;
			fs = new FileStream(FileName, FileMode.OpenOrCreate);

			StreamWriter sw = new StreamWriter(fs);

			sw.WriteLine(S);
			sw.Close();
			fs.Close();
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
		public void MaHoa()
		{
			string KQ = "";
			for (int i = 0; i < S.Length; i++)
				KQ = KQ + (char)((int)S[i] + 5);
			S = KQ;

		}
		public void GiaiMa()
		{
			string KQ = "";
			for (int i = 0; i < S.Length; i++)
				KQ = KQ + (char)((int)S[i] - 5);
			S = KQ;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			string FileName = "data.txt";
			Document doc = new Document("Hello");
			doc.Write(FileName);
			doc.Read(FileName);

			Console.WriteLine("du lieu trong file: {0}", doc.Data);
			Console.WriteLine("du lieu sau khi ma hoa: ");
			doc.MaHoa();
			Console.WriteLine(doc.Data);
			Console.WriteLine("du lieu sau khi giai ma: ");
			doc.GiaiMa();
			Console.WriteLine(doc.Data);
			Console.ReadLine();
		}
	}
}
