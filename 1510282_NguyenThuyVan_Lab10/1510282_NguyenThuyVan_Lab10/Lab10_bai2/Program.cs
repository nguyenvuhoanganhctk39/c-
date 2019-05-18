using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(3);
            st.Push(2);
            Console.WriteLine("=========stack===========");
            Console.WriteLine("Lay ptu trong stack ra");
            Console.Write(st.Pop() +", ");
            Console.WriteLine(st.Pop());
            Console.WriteLine("=======queue===========");
            Queue q = new Queue();
            q.Push(3);
            q.Push(6);
            Console.WriteLine("Lay ptu trong queue ra");
            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());

            Console.ReadLine();
        }
    }
}
