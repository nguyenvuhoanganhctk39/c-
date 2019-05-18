using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1510282_NguyenThuyVan
{
    class Program
    {
        
        class Queue
        {
           public double [] Q;
            const int MAX = 100;
            int front = 0;
            int rear = -1;
            public Queue()
            {
                Q = new double[MAX];
            }
            public bool IsEmpty()
            {
                return (front < 0 || front > rear) ? true : false;
            }
            public bool IsFull()
            {
                return rear == MAX - 1 ? true : false;
            }
            public void EnQueue(double item)
            {
                if(IsFull())
                {
                    Console.WriteLine("Hang doi day roi, khong the them");
                    return;
                }
                rear++;
                Q[rear] = item;
            }
            public void DeQueue()
            {
                if(IsEmpty())
                {
                    Console.WriteLine("Hang doi rong, k co gi de xoa");
                    return;
                }
                Q[front] = 0;
                front++;
            }
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            int num;
            Console.Write("Nhap vao so phan tu hang doi:");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("Nhap vao phan tu cua hang doi: {0}",i);
                q.EnQueue(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Hang doi");
            for (int i = 0; i < num; i++)
            {
                Console.Write(" {0}", q.Q[i]);
            }
            //Console.ReadKey();
            //Console.WriteLine("Kiem tra hang doi");
            //if(q.IsFull())
            //    Console.WriteLine("Hang doi da day!");
            //Console.ReadLine();
            //if(q.IsEmpty())
            //    Console.WriteLine("Hang doi rong!");
            //Console.ReadKey();

            Console.ReadLine();
        }
    }
}
