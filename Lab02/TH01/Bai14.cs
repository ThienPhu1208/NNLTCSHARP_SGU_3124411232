/*
* BÀI 14: TÍNH LƯƠNG 1 NHÂN VIÊN
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 17/09/2026
*
* Phát biểu đề bài:
* - Nhập thông tin một nhân viên gồm họ tên, mức lương, số ngày vắng.
* - Một ngày vắng bị trừ 100.000 VNĐ.
* - Tính và xuất lương của nhân viên.
*
* Ý tưởng:
* - Xây dựng lớp NhanVien gồm họ tên, mức lương, số ngày vắng.
* - Tính tiền bị trừ = số ngày vắng * 100000.
* - Lương thực nhận = mức lương - tiền bị trừ.
*
* Mã giả:
* - Nhập họ tên.
* - Nhập mức lương.
* - Nhập số ngày vắng.
* - Tính lương thực nhận.
* - Xuất thông tin và lương.
*/

using System;

namespace TH01
{
    class NhanVien
    {
        public string hoTen;
        public double mucLuong;
        public int soNgayVang;

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap muc luong: ");
            mucLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            soNgayVang = int.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return mucLuong - soNgayVang * 100000;
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Muc luong: " + mucLuong);
            Console.WriteLine("So ngay vang: " + soNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
    }

    class Bai14
    {
        public static void ChayBai14()
        {
            // Khai bao bien
            NhanVien nv = new NhanVien();

            // Nhap du lieu
            nv.Nhap();

            // Xuat ket qua
            Console.WriteLine("\nThong tin nhan vien:");
            nv.Xuat();
        }
    }
}

/*
- TEST CASE 1:
Input:
Ho ten: Nguyen Van An
Muc luong: 10000000
So ngay vang: 2

Output:
Thong tin nhan vien:
Ho ten: Nguyen Van An
Muc luong: 10000000
So ngay vang: 2
Luong thuc nhan: 9800000


- TEST CASE 2:
Input:
Ho ten: Tran Thi Mai
Muc luong: 8000000
So ngay vang: 0

Output:
Thong tin nhan vien:
Ho ten: Tran Thi Mai
Muc luong: 8000000
So ngay vang: 0
Luong thuc nhan: 8000000


- TEST CASE 3:
Input:
Ho ten: Le Van Binh
Muc luong: 12000000
So ngay vang: 5

Output:
Thong tin nhan vien:
Ho ten: Le Van Binh
Muc luong: 12000000
So ngay vang: 5
Luong thuc nhan: 11500000
*/