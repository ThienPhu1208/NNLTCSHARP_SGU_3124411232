/*
* BÀI 3.1: SẮP XẾP CÁC ĐỐI TƯỢNG
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 20/09/2026
*
* Phát biểu đề bài: Dùng phương thức tĩnh Array.Sort(...) để sắp xếp các đối tượng của một lớp nào đó.
*
* Ý tưởng:
* - Xây dựng lớp SinhVienBai31 gồm họ tên và điểm.
* - Cho lớp SinhVienBai31 kế thừa IComparable.
* - Cài đặt phương thức CompareTo để so sánh điểm.
* - Sử dụng Array.Sort(...) để sắp xếp danh sách sinh viên theo điểm tăng dần.
*
* Mã giả:
* - Khai báo lớp SinhVienBai31.
* - Nhập danh sách sinh viên.
* - Sử dụng Array.Sort(...) để sắp xếp.
* - Xuất danh sách sau khi sắp xếp.
*/

using System;

namespace TH02
{
    class SinhVienBai31 : IComparable<SinhVienBai31>
    {
        private string hoTen;
        private double diem;

        // Constructor mặc nhiên
        public SinhVienBai31()
        {
            hoTen = "";
            diem = 0;
        }

        // Constructor có tham số
        public SinhVienBai31(string hoTen, double diem)
        {
            this.hoTen = hoTen;
            this.diem = diem;
        }

        // Property
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double Diem
        {
            get { return diem; }
            set { diem = value; }
        }

        // Nhập sinh viên
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap diem: ");
            diem = double.Parse(Console.ReadLine());
        }

        // Xuất sinh viên
        public void Output()
        {
            Console.WriteLine("Ho ten: " + hoTen + " - Diem: " + diem);
        }

        // So sánh theo điểm tăng dần
        public int CompareTo(SinhVienBai31 other)
        {
            if (diem > other.diem)
                return 1;

            if (diem < other.diem)
                return -1;

            return 0;
        }
    }

    class Bai03_1
    {
        public static void ChayBai03_1()
        {
            int n;
            SinhVienBai31[] dsSinhVien;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so luong sinh vien: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("So luong sinh vien phai lon hon 0!");
            }
            while (n <= 0);

            dsSinhVien = new SinhVienBai31[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap sinh vien thu " + (i + 1) + ":");

                dsSinhVien[i] = new SinhVienBai31();
                dsSinhVien[i].Input();
            }

            // Sap xep
            Array.Sort(dsSinhVien);

            // Xuat ket qua
            Console.WriteLine("\nDanh sach sinh vien sau khi sap xep tang dan theo diem:");

            for (int i = 0; i < n; i++)
            {
                dsSinhVien[i].Output();
            }
        }
    }
}

/*
- TEST CASE 1:
Input:
3
Nguyen Van A
8
Nguyen Van B
6.5
Nguyen Van C
9

Output:
Danh sach sinh vien sau khi sap xep tang dan theo diem:
Ho ten: Nguyen Van B - Diem: 6.5
Ho ten: Nguyen Van A - Diem: 8
Ho ten: Nguyen Van C - Diem: 9


- TEST CASE 2:
Input:
4
Nguyen Van A
7
Tran Van B
9
Le Van C
5
Pham Van D
8

Output:
Danh sach sinh vien sau khi sap xep tang dan theo diem:
Ho ten: Le Van C - Diem: 5
Ho ten: Nguyen Van A - Diem: 7
Ho ten: Pham Van D - Diem: 8
Ho ten: Tran Van B - Diem: 9


- TEST CASE 3:
Input:
2
Nguyen Van A
10
Tran Van B
8

Output:
Danh sach sinh vien sau khi sap xep tang dan theo diem:
Ho ten: Tran Van B - Diem: 8
Ho ten: Nguyen Van A - Diem: 10
*/