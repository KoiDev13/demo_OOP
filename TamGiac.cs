using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    internal class TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;

        public void NhapTamGiac(string GhiChu)
        {
            this.A = new Diem();
            this.B = new Diem();
            this.C = new Diem();
            this.A.NhapDiem(GhiChu);
            this.B.NhapDiem(GhiChu);
            this.C.NhapDiem(GhiChu);
        }  

        public double TinhChuVi()
        {
            double ab, bc, ca;
            ab = this.A.TinhKhoangCach(B);
            bc = this.B.TinhKhoangCach(C);
            ca = this.C.TinhKhoangCach(A);

            return ab + bc + ca;
        }
    }
}
