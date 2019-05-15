using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        class Matran
        {
            int hang, cot;
            const int MAX = 100;
            int[,] a;
            public Matran()
            {
                a = new int[MAX, MAX];
            }
            public Matran(int hang,int cot)
            {
                this.hang = hang;
                this.cot = cot;
                this.a = new int[this.hang, this.cot];
            }
            public void NhapMatran()
            {
                Console.WriteLine("Nhap so hang");
                this.hang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so cot");
                this.cot = int.Parse(Console.ReadLine());
                a = new int[this.hang, this.cot];

                for (int i = 0; i < hang; i++)
                {
                    for (int j = 0; j < cot; j++)
                    {
                        Console.Write("\nNhap phan tu thu ({0},{1}):",i,j);
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            public void XuatMatran()
            {
                for (int i = 0; i < hang; i++)
                {
                    for (int j = 0; j < cot; j++)
                    {
                        if (j==(cot-1))
                        {
                            Console.WriteLine("{0}  ",a[i, j]);
                        }
                        else
                        {
                            Console.Write("{0}  ",a[i, j]);
                        }
                        
                    }
                }
            }
            public static Matran operator +(Matran a, Matran b)
            {
                Matran c = new Matran(a.hang, a.cot);
                for (int i = 0; i < a.hang; i++)

                {

                    for (int j = 0; j < a.cot; j++)

                    {

                        c.a[i, j] = a.a[i, j] + b.a[i, j];

                    }

                }
                return c;
            }
            public Matran NghichDaoMaTran()
            {
                Matran c = new Matran(cot,hang);
                for (int i = 0; i < cot; i++)

                {

                    for (int j = 0; j < hang; j++)

                    {

                        c.a[i, j] = a[j, i];

                    }

                }
                return c;
            }
            public static Matran  operator *(Matran a,Matran b)
            {
                Matran c = new Matran(a.hang,a.cot);
                for (int i = 0; i < a.hang; i++)
                    for (int j = 0; j < b.cot; j++)
                        c.a[i, j] = 0;
                for (int i = 0; i < a.hang; i++)    //hang cua ma tran thu nhat 
                {
                    for (int j = 0; j < b.cot; j++)    //cot cua ma tran thu hai 
                    {
                      int  sum = 0;
                        for (int k = 0; k < a.cot; k++)
                            sum = sum + a.a[i, k] * b.a[k, j];
                        c.a[i, j] = sum;
                    }
                }
                return c;
            }

        }
        static void Main(string[] args)
        {
            Matran a = new Matran();
            Matran b = new Matran();
            Matran c = new Matran();

            a.NhapMatran();
            b.NhapMatran();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Ma tran a da nhap");
            a.XuatMatran();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Ma tran b da nhap");
            b.XuatMatran();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Cong 2 ma tran");
            try
            {
                c = a + b;
                c.XuatMatran();
            }
            catch
            {
                Console.WriteLine("Khong the cong hai ma tran khong bang nhau");
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Nhan 2 ma tran");
            try
            {
                c = a * b;
                c.XuatMatran();
            }
            catch
            {
                Console.WriteLine("Khong the nhan hai ma tran khong bang nhau");
            }



            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Ma tran nghich dao");
            c = a.NghichDaoMaTran();
            c.XuatMatran();
            Console.ReadLine();
        }
    }
}
