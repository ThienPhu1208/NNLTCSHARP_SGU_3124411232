/*
* BÀI 1.1: TÍNH TUỔI 1 SINH VIÊN
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 18/09/2026
*
* Phát biểu đề bài:
* - Nhập thông tin sinh viên gồm họ tên, năm sinh.
* - Tính và xuất tuổi sinh viên.
*
* Ý tưởng:
* - Xây dựng lớp SinhVien gồm Field, Constructor, Property và Method.
* - Nhập họ tên và năm sinh.
* - Tính tuổi = năm hiện tại - năm sinh.
* - Xuất thông tin và tuổi sinh viên.
*
* Mã giả:
* - Nhập họ tên.
* - Nhập năm sinh.
* - Tính tuổi.
* - Xuất tuổi.
*/

using System;

namespace TH02
{
    class SinhVien
    {
        // Field
        private string hoTen;
        private int namSinh;

        // Constructor mac dinh
        public SinhVien()
        {
            hoTen = "";
            namSinh = 0;
        }

        // Constructor co tham so
        public SinhVien(string hoTen, int namSinh)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        // Property
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        // Method
        public int TinhTuoi()
        {
            return 2026 - namSinh;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Nam sinh: " + NamSinh);
            Console.WriteLine("Tuoi: " + TinhTuoi());
        }
    }

    class Bai01_1
    {
        public static void ChayBai01_1()
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
Ho ten: Nguyen Thien Phu
Nam sinh: 2006

Output:
Thong tin sinh vien:
Ho ten: Nguyen Thien Phu
Nam sinh: 2006
Tuoi: 20


- TEST CASE 2:
Input:
Ho ten: Tran Van An
Nam sinh: 2005

Output:
Thong tin sinh vien:
Ho ten: Tran Van An
Nam sinh: 2005
Tuoi: 21


- TEST CASE 3:
Input:
Ho ten: Le Thi Mai
Nam sinh: 2007

Output:
Thong tin sinh vien:
Ho ten: Le Thi Mai
Nam sinh: 2007
Tuoi: 19
*/