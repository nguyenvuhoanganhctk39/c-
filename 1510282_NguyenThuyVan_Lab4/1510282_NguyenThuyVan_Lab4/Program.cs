using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1510282_NguyenThuyVan_Lab4
{
    class Program
    {
        class SoPhuc
        {
            float pt, pa;
            public SoPhuc()
            { }
            public SoPhuc(float a, float b)
            {
                pt = a;
                pa = b;
            }
            public SoPhuc(SoPhuc ob)
            {
                pt = ob.pt;
                pa = ob.pa;
            }
            public override string ToString()
            {
                string s = pt.ToString() + " + " + pa.ToString() + "*i";
                return s;
            }
            public void Nhap()
            {
                Console.Write("Nhap phan thuc: ",pt);
                pt = float.Parse(Console.ReadLine());
                Console.Write("Nhap phan ao: ", pa);
                pa = float.Parse(Console.ReadLine());
            }
            public void Xuat()
            {
                if(pa >= 0)
                    Console.WriteLine(" {0} + {1}*i",pt,pa);
                else
                    Console.WriteLine(" {0} {1}*i", pt, pa);
            }
            public SoPhuc Cong(SoPhuc sp1)
            {
                SoPhuc sp = new SoPhuc();
                sp.pt = pt + sp1.pt;
                sp.pa = pa + sp1.pa;
                return sp;
            }
            public SoPhuc Tru(SoPhuc sp1)
            {
                SoPhuc sp = new SoPhuc();
                sp.pt = pt - sp1.pt;
                sp.pa = pa - sp1.pa;
                return sp;
            }
            public static SoPhuc operator +(SoPhuc sp1, SoPhuc sp2)
            {
                SoPhuc kq = new SoPhuc();
                kq.pt = sp1.pt + sp2.pt;
                kq.pa = sp1.pa + sp2.pa;
                return kq;
            }
            public static SoPhuc operator -(SoPhuc sp1, SoPhuc sp2)
            {
                SoPhuc kq = new SoPhuc();
                kq.pt = sp1.pt - sp2.pt;
                kq.pa = sp1.pa - sp2.pa;
                return kq;
            }
            public static SoPhuc operator *(SoPhuc sp1, SoPhuc sp2)
            {
                SoPhuc kq = new SoPhuc();
                kq.pt = (sp1.pt * sp2.pt) - (sp1.pa*sp2.pa);
                kq.pa = (sp1.pt * sp2.pa) + (sp1.pa*sp2.pt);
                return kq;
            }
            public static SoPhuc operator /(SoPhuc sp1, SoPhuc sp2)
            {
                SoPhuc kq = new SoPhuc();
                kq.pt = (sp1.pt * sp2.pt + sp1.pa*sp2.pa) / (sp2.pt*sp2.pt + sp2.pa * sp2.pa);
                kq.pa = ( sp1.pa * sp2.pt -sp1.pt * sp2.pa) / (sp2.pt * sp2.pt + sp2.pa * sp2.pa);
                return kq;
            }
            public static bool operator ==(SoPhuc sp1, SoPhuc sp2)
            {
                return (sp1.pt == sp2.pt && sp1.pa == sp2.pa);
            }
            public static bool operator !=(SoPhuc sp1, SoPhuc sp2)
            {
                return !(sp1 == sp2);
            }
            public void KTSP()
            {
                if(this.pt == 0)
                    Console.WriteLine("So phuc la so thuan ao");
                else if(this.pa == 0)
                    Console.WriteLine("So phuc la so thuc");
                else
                    Console.WriteLine("So la so phuc");
            }
        }
        static void Main(string[] args)
        {
            SoPhuc sp1 = new SoPhuc();
            sp1.Nhap();
            Console.Write("So phuc vua nhap la:");
            sp1.Xuat();
           
            SoPhuc sp2 = new SoPhuc(2, 3);
            Console.Write("So phuc: ");
            sp2.Xuat();
            Console.WriteLine("===========================================================");
            SoPhuc sp3 = new SoPhuc(4,5);
            Console.Write("So phuc: ");
            sp3.Xuat();
            Console.WriteLine("===========================================================");
            SoPhuc sp4 = new SoPhuc();
            sp4 = sp1 + sp3;
            Console.Write("Toan tu cong hai so phuc: {0} + {1} = ", sp1.ToString(), sp3.ToString());
            sp4.Xuat();
            Console.WriteLine("===========================================================");
            sp4 = sp1 - sp3;
            Console.Write("Toan tu tru hai so phuc: {0} - {1} = ", sp1.ToString(), sp3.ToString());
            sp4.Xuat();
            Console.WriteLine("===========================================================");
            sp4 = sp1 * sp3;
            Console.Write("Toan tu nhan hai so phuc: {0} * {1} = ", sp1.ToString(), sp3.ToString());
            sp4.Xuat();
            Console.WriteLine("===========================================================");
            sp4 = sp1 / sp3;
            Console.Write("Toan tu chia hai so phuc: {0} / {1} =", sp1.ToString(), sp3.ToString());
            sp4.Xuat();
            Console.WriteLine("===========================================================");
            Console.WriteLine("So sanh hai so phuc");
            if(sp1 == sp3)
                Console.WriteLine("So phuc {0} == so phuc {1}", sp1.ToString(), sp3.ToString());
            else
                Console.WriteLine("So phuc {0} != so phuc {1}", sp1.ToString(), sp3.ToString());
            Console.WriteLine("===========================================================");
            Console.WriteLine("Kiem tra so {0} la so phuc, so thuc hay thuan ao?", sp1.ToString());
            sp1.KTSP();
            Console.ReadLine();
        }
    }
}
