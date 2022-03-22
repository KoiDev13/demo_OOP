using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    internal class NhanVienSanXuat
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int SoSanPham { get; set; }

        public double TinhLuong()
        {
            return this.SoSanPham * 100;
        }
    }
}
