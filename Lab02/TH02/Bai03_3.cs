/*
* BÀI 3.3: SẮP XẾP MẢNG TỔNG QUÁT BẰNG DELEGATE
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 21/09/2026
*
* Phát biểu đề bài:
* Viết phương thức sắp xếp một mảng tổng quát bằng delegate.
*
* Ý tưởng:
* - Xây dựng lớp SinhVienBai33 gồm họ tên và điểm.
* - Khai báo delegate SoSanh<T> để so sánh hai đối tượng.
* - Xây dựng phương thức SapXepMang<T>() nhận vào mảng
*   và delegate so sánh.
* - Dùng delegate để quyết định thứ tự sắp xếp.
* - Hoán vị hai phần tử nếu sai thứ tự.
*
* Mã giả:
* - Khai báo delegate SoSanh<T>.
* - Khai báo lớp SinhVienBai33.
* - Viết phương thức SoSanhDiem().
* - Viết phương thức SapXepMang<T>().
* - Nhập danh sách sinh viên.
* - Gọi SapXepMang() và truyền delegate vào.
* - Xuất danh sách sau khi sắp xếp.
*/

using System;

namespace TH02
{
    // Delegate dùng để so sánh hai đối tượng
    delegate int SoSanh<T>(T a, T b);

    // Lớp SinhVien
    class SinhVienBai33
    {
        private string hoTen;
        private double diem;

        // Constructor mặc nhiên
        public SinhVienBai33()
        {
            hoTen = "";
            diem = 0;
        }

        // Constructor có tham số
        public SinhVienBai33(string hoTen, double diem)
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

        // Nhập dữ liệu
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap diem: ");
            diem = double.Parse(Console.ReadLine());
        }

        // Xuất dữ liệu
        public void Output()
        {
            Console.WriteLine("Ho ten: " + hoTen + " - Diem: " + diem);
        }

        // Phương thức so sánh theo điểm
        public static int SoSanhDiem(SinhVienBai33 a, SinhVienBai33 b)
        {
            if (a.diem > b.diem)
                return 1;

            if (a.diem < b.diem)
                return -1;

            return 0;
        }
    }

    class SapXepBai33
    {
        // Phương thức sắp xếp mảng tổng quát bằng delegate
        public static void SapXepMang<T>(T[] a, SoSanh<T> soSanh)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (soSanh(a[i], a[j]) > 0)
                    {
                        T temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }

    class Bai03_3
    {
        public static void ChayBai03_3()
        {
            int n;
            SinhVienBai33[] dsSinhVien;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so luong sinh vien: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("So luong sinh vien phai lon hon 0!");
            }
            while (n <= 0);

            dsSinhVien = new SinhVienBai33[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap sinh vien thu " + (i + 1) + ":");

                dsSinhVien[i] = new SinhVienBai33();
                dsSinhVien[i].Input();
            }

            // Sap xep bang delegate
            SapXepBai33.SapXepMang(dsSinhVien, SinhVienBai33.SoSanhDiem);

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