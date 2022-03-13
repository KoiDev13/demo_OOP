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

            Diem a, b; 
            a= new Diem();
            b= new Diem();
            a.Nhap("Nhap diem a: ");
            b.Nhap("Nhap diem b: ");
            double kq = a.TinhKhoangCach(b);
            Console.WriteLine($"Khoang cach tu a den b la {kq}");

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
