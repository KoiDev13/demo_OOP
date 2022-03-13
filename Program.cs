using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PhanSo t;
            t= new PhanSo();
            t.TUSO = 1;
            int tt = t.TUSO;
            t.MAUSO = 2;
            string chuoi = t.XuatPhanSo();
            Console.WriteLine(chuoi);

            
            
            // Class Tam giac Program

            /*
            TamGiac t;
            t = new TamGiac();
            t.NhapTamGiac("Nhap tam giac: ");
            double kq = t.TinhChuVi();
            Console.WriteLine($"Chu vi tam giac la {kq}");
            */

            // Class Diem Program
            /*
            Diem a, b; 
            a= new Diem();
            b= new Diem();
            a.NhapDiem("Nhap diem a: ");
            b.NhapDiem("Nhap diem b: ");
            double kq = a.TinhKhoangCach(b);
            Console.WriteLine($"Khoang cach tu a den b la {kq}");
            */


            // Class PhanSo Program
            /*
            PhanSo a, b;
            a = new PhanSo();
            b = new PhanSo();
            a.Nhap("Nhap phan so a: ");
            b.Nhap("Nhap phan so b: ");
            PhanSo kq;
            kq = a.Cong(b);
            Console.WriteLine("Ket qua la: ");
            kq.XuatPhanSo();
            */
        }
    }
}
