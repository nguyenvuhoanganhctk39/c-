using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
	class LopChinh
	{
		protected int[] mang = new int[10];
		public int Empty()
		{
			int rong = -1;
			return rong;
		}

		public int Full()
		{
			int full = -1;
			return full;
		}

		public int Push()
		{
			int ok = -1;
			return ok;
		}

	}
	class Stack : LopChinh
	{
		public int Pop()
		{
			//Pop cua stack FIFO
			int gt = 0;
			return gt;
		}
	}

	class Queue : LopChinh
	{
		public int Pop()
		{
			// Pop cua Querry
			int gt = 0;
			return gt;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			LopChinh lc = new LopChinh();

		}
	}
}
