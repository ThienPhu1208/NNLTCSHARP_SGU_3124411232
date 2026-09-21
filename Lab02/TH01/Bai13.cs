/*
* BÀI 13: NHẬP XUẤT THÔNG TIN SINH VIÊN
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 17/09/2026
*
* Phát biểu đề bài:
* - Xây dựng lớp sinh viên để lưu trữ 1 sinh viên: mã sinh viên, họ tên, địa chỉ, sinh viên năm thứ mấy.
* - Nhập xuất 1 sinh viên.
*
* Ý tưởng:
* - Xây dựng lớp SinhVien gồm các thuộc tính: maSinhVien, hoTen, diaChi, namThu.
* - Nhập thông tin cho sinh viên.
* - Xuất thông tin sinh viên ra màn hình.
*
* Mã giả:
* - Khai báo lớp SinhVien.
* - Khai báo các thuộc tính của sinh viên.
* - Nhập thông tin sinh viên.
* - Xuất thông tin sinh viên.
*/

using System;

namespace TH01
{
    class SinhVien
    {
        public string maSinhVien;
        public string hoTen;
        public string diaChi;
        public int namThu;

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSinhVien = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();

            Console.Write("Nhap sinh vien nam thu may: ");
            namThu = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien: " + maSinhVien);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("Sinh vien nam thu: " + namThu);
        }
    }

    class Bai13
    {
        public static void ChayBai13()
        {
            // Khai bao bien
            SinhVien sv = new SinhVien();

            // Nhap du lieu
            sv.Nhap();

            // Xuat ket qua
            Console.WriteLine("\nThong tin sinh vien:");
            sv.Xuat();
        }
    }
}

/*
- TEST CASE 1:
Input:
Ma sinh vien: 3124411232
Ho ten: Nguyen Thien Phu
Dia chi: Ho Chi Minh
Sinh vien nam thu: 2

Output:
Thong tin sinh vien:
Ma sinh vien: 3124411232
Ho ten: Nguyen Thien Phu
Dia chi: Ho Chi Minh
Sinh vien nam thu: 2


- TEST CASE 2:
Input:
Ma sinh vien: 3124411001
Ho ten: Tran Van An
Dia chi: Binh Duong
Sinh vien nam thu: 1

Output:
Thong tin sinh vien:
Ma sinh vien: 3124411001
Ho ten: Tran Van An
Dia chi: Binh Duong
Sinh vien nam thu: 1


- TEST CASE 3:
Input:
Ma sinh vien: 3124411050
Ho ten: Le Thi Mai
Dia chi: Dong Nai
Sinh vien nam thu: 3

Output:
Thong tin sinh vien:
Ma sinh vien: 3124411050
Ho ten: Le Thi Mai
Dia chi: Dong Nai
Sinh vien nam thu: 3
*/