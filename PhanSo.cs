using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    internal class PhanSo
    {
        public int TuSo;
        public int MauSo;

        public void Nhap(string GhiChu)
        {
            Console.WriteLine(GhiChu);
            Console.WriteLine("Nhap Tu So:");
            this.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Mau So:");
            this.MauSo = int.Parse(Console.ReadLine());
        }
        public PhanSo Cong(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = this.TuSo * b.MauSo + this.MauSo * b.TuSo;
            kq.MauSo = this.MauSo * b.MauSo;
            return kq;
        }

        public void XuatPhanSo()
        {
            Console.WriteLine($"{this.TuSo}/{this.MauSo}");
        }
    }
}
