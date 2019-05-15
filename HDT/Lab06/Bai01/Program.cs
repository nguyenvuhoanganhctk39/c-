using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        class Queue
        {
            const int MAX = 100;
            int front, rear,count;
            double[] Q;
            public Queue()
            {
                front= 0;
                rear = -1;
                count = 0;
                Q = new double[MAX];
            }
            public void Enqueue(double a)
            {
                Q[++rear] = a;
                count++;

            }
            public void Nhap()
            {
                Console.WriteLine("Nhap so luong hang doi");
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("Nhap phan tu thu {0} ",i);
                    Enqueue(double.Parse(Console.ReadLine()));
                }
            }
            public void Xuat()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("{0}, ",Q[i]);
                }
            }
            public double Dequeue()
            {
                double x;
                x = Q[front];
                for (int i = front; i < rear; i++)
                {
                    Q[i] = Q[i + 1];
                }
                rear--;
                count--;
                return x;
            }
            public bool Isempty()
            {
                return rear==0;
            }
            public bool Isfull()
            {
                return rear==MAX-1;
            }
        }
        static void Main(string[] args)
        {
            Queue a = new Queue();
            a.Nhap();
            Console.WriteLine("Mang da nhap");
            a.Xuat();
            Console.WriteLine("\nPhan tu bo vao dau tien: {0}",a.Dequeue());
            Console.WriteLine("Mang con lai");
            a.Xuat();
            //Console.WriteLine("Phan tu bo vao dau tien");
            Console.WriteLine();
        }
    }
}
