using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    static void SinhVieen(string[] args)
    {
        
    }
    internal class SinhVien
    {
        private string maSo;
        private string hoTen;
        private string chuyenNganh;
        private int namSinh;
        private float diemTB;
        private string loai;



        public SinhVien() { }


        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTB, string loai)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
            this.loai = loai;
        }

        public SinhVien(SinhVien sv)
        {
            this.maSo = sv.maSo;
            this.hoTen = sv.hoTen;
            this.chuyenNganh = sv.chuyenNganh;
            this.namSinh = sv.namSinh;
            this.diemTB = sv.diemTB;
            this.loai = sv.loai;
        }
        public string MaSo
        {
            get { return this.maSo; }
            set { this.maSo = value; }
        }
        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }
        public int NamSinh
        {
            get { return this.namSinh; }
            set { this.namSinh = value; }
        }
        public float DiemTB
        {
            get { return this.diemTB; }
            set { this.DiemTB = value; }
        }
        public bool KiemTraDiemTB(float dtb)
        {
            return dtb >= 0 && dtb <= 10;
        }
        public bool KiemTraNamSinh(int NamSinh)
        {
            return NamSinh >= 17 && NamSinh <= 70;
        }
        public string XepLoai()
        {
            if (diemTB < 5)
                Console.WriteLine("Kém");
            if (diemTB < 7)
                Console.WriteLine("Trung Bình");
            if (diemTB < 8)
                Console.WriteLine("Khá");
            return "Giỏi";
        }
        public void nhap()
        {
            Console.WriteLine("Nhập mã sv: ");
            maSo = Console.ReadLine();
            Console.WriteLine("Nhập họ và tên: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhập chuyên ngành: ");
            chuyenNganh = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm trung bình: ");
            diemTB = float.Parse(Console.ReadLine());
        }


        public void xuat()
        {
            Console.WriteLine($"Mã: {maSo}");
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Chuyên ngành: {chuyenNganh}");
            Console.WriteLine($"Năm sinh: {namSinh}");
            Console.WriteLine($"Điểm TB: {diemTB}");
            Console.WriteLine($"Loại: {loai}");
        }

    }
}   

