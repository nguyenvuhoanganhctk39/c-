using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        class Stack
        {
            const int MAX=100;
            int top;
            int[] a = new int[MAX];
            public Stack()
            {
                top =0;
            }
            public void Push(int i)
            {
                if (FullStack()==false)
                {
                    a[top] = i;
                    this.top++;
                }
                else
                {
                    Console.WriteLine("Stack Day");
                }
               
            }
            public int Pop()
            {
                int temp = 1000;
                if (EmtyStack()==false)
                {
                    temp = a[top - 1];
                    top--;
                    return temp;
                }
                else
                {
                    Console.WriteLine("Stack rong");
                }
                return temp;
            }
            public void XuatStack()
            {
                Console.Write("Stack :");
                for (int i = 0; i < top; i++)
                {
                    Console.Write("{0},",a[i]);
                }
            }
            public bool EmtyStack()
            {
                return top == 0;
            }
            public bool FullStack()
            {
                return top == MAX;
            }
            public void ToBin()
            {
                int[] b = new int[MAX];
                for (int i = 0; i < top; i++)
                {
                     b[i] = int.Parse(Convert.ToString(a[i], 2));
                    Console.Write("{0},", b[i]);
                }

            }
            public void ToHex()
            {
                string[] b = new string[MAX];
                for (int i = 0; i < top; i++)
                {
                    b[i] = Convert.ToString(a[i], 16);
                    Console.Write("{0},", b[i]);
                }

            }
        }
        static void Main(string[] args)
        {
            Stack a = new Stack();
            Console.WriteLine("Nhap so luong phan tu stack");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}",i+1);
                a.Push(int.Parse(Console.ReadLine()));
            }
            a.XuatStack();
            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("Phan tu cuoi {0} ", a.Pop());

            Console.WriteLine("\nStack he bin");
            a.ToBin();
            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("\nStack he hex");
            a.ToHex();
            Console.ReadLine();
        }
    }
}
