using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_OOP
{
    internal class NhanVienVanPhong
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int LuongCoBan { get; set; }
        public int PhuCap { get; set; }

        public void Nhap(string GhiChu)
        {
            Console.WriteLine(GhiChu);
            Console.WriteLine("Nhap Ma Nhan vien:");
            this.MaNV = Console.ReadLine();
            Console.WriteLine("Nhap Ho Ten:");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap Dia Chi:");
            this.DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap Luong co ban:");
            this.LuongCoBan = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Phu cap:");
            this.PhuCap = int.Parse(Console.ReadLine());
        }
        public double TinhLuong()
        {
            return this.LuongCoBan * 10 + this.PhuCap;
        }
    }
}
