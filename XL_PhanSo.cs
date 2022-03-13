using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    public struct PhanSo1
    {
        public int TuSo;
        public int MauSo;
    }
    public class XL_PhanSo
    {
        public static PhanSo1 NhapPhanSo(string ghiChu)
        {
            PhanSo1 kq;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so:");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so:");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;
        }
    }
}
