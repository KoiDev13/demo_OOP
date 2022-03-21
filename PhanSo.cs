using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    internal class PhanSo
    {
        private int TuSo;
        private int MauSo;

        public PhanSo()
        {
            this.TuSo = 0;
            this.MauSo = 1;
        }

        public PhanSo(int t)
        {
            this.TuSo = t;
            this.MauSo = 1;
        }

        public PhanSo(int t, int m)
        {
            this.TuSo = t;
            if (m != 0)
            {
                this.MauSo = m;
            }
            else
            {
                this.MauSo = 1; 
            }
        }
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

        public string XuatPhanSo()
        {
            return $"{this.TuSo}/{this.MauSo}";
        }
        public int TUSO
        {
            get {
                return this.TuSo;
            }
            set {
                this.TuSo = value;
            }
        }

        public int MAUSO
        {
            get
            {
                return this.MauSo;
            }
            set
            {
                if (value != 0)
        {
                    this.MauSo = value;
                }
            }
        }
    }
}
