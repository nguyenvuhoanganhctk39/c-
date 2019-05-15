using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        class MyClass
        {
            public static int i;
            public void seti(int n) { i= n; }
            public int geti() { return i; }
        }
        static void Main(string[] args)
        {
            MyClass.i = 100;
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass();
            ob1.seti(10);
            Console.WriteLine("Giá trị db1: {0}", ob1.geti());
            Console.WriteLine("Giá trị db2: {0}", ob2.geti());

        }
    }
}
