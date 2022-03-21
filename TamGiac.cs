using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    class TamGiac
    {
        public Diem A { get; set; }
        public Diem B { get; set; }
        public Diem C { get; set; }


        public TamGiac()
        {
            this.A = new Diem(0, 0);
            this.B = new Diem(1, 0);
            this.C = new Diem(0, 1);
        }
        public TamGiac(Diem a, Diem b, Diem c)
        {
            if (KiemTraTamGiac(a, b, c))
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                this.A = new Diem(0, 0);
                this.B = new Diem(1, 0);
                this.C = new Diem(0, 1);
            }
        }

        public bool KiemTraTamGiac(Diem p1, Diem p2, Diem p3)
        {
            double a, b, c;
            a = p1.TinhKhoangCach(p2);
            b = p2.TinhKhoangCach(p3);
            c = p3.TinhKhoangCach(p1);
            return a + b > c && b + c > a && c + a > b;
        }
    }
}
