/*
* BÀI 3.2: SẮP XẾP MẢNG TỔNG QUÁT BẰNG INTERFACE
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 21/09/2026
*
* Phát biểu đề bài: Viết phương thức sắp xếp một mảng tổng quát bằng interface (mô phỏng phương thức Array.Sort(...)).
*
* Ý tưởng:
* - Xây dựng interface ISoSanh<T> để định nghĩa phương thức so sánh.
* - Xây dựng phương thức SapXep<T>() nhận vào một mảng tổng quát.
* - Dùng phương thức CompareTo() của interface để so sánh.
* - Hoán vị hai phần tử nếu phần tử trước lớn hơn phần tử sau.
* - Phương thức SapXep<T>() mô phỏng cách sử dụng Array.Sort(...).
*
* Mã giả:
* - Khai báo interface ISoSanh<T>.
* - Khai báo phương thức CompareTo().
* - Xây dựng phương thức SapXep<T>().
* - Duyệt từng cặp phần tử trong mảng.
* - So sánh hai phần tử bằng CompareTo().
* - Hoán vị nếu sai thứ tự.
* - Xuất mảng sau khi sắp xếp.
*/

using System;

namespace TH02
{
    // Interface dùng để so sánh hai đối tượng
    interface ISoSanh<T>
    {
        int CompareTo(T other);
    }

    // Lớp SinhVien sử dụng interface
    class SinhVienBai32 : ISoSanh<SinhVienBai32>
    {
        private string hoTen;
        private double diem;

        // Constructor mặc nhiên
        public SinhVienBai32()
        {
            hoTen = "";
            diem = 0;
        }

        // Constructor có tham số
        public SinhVienBai32(string hoTen, double diem)
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

        // So sánh theo điểm tăng dần
        public int CompareTo(SinhVienBai32 other)
        {
            if (diem > other.diem)
                return 1;

            if (diem < other.diem)
                return -1;

            return 0;
        }
    }

    class SapXep
    {
        // Phương thức sắp xếp mảng tổng quát
        public static void SapXepMang<T>(T[] a) where T : ISoSanh<T>
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i].CompareTo(a[j]) > 0)
                    {
                        T temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }

    class Bai03_2
    {
        public static void ChayBai03_2()
        {
            int n;
            SinhVienBai32[] dsSinhVien;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so luong sinh vien: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("So luong sinh vien phai lon hon 0!");
            }
            while (n <= 0);

            dsSinhVien = new SinhVienBai32[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap sinh vien thu " + (i + 1) + ":");

                dsSinhVien[i] = new SinhVienBai32();
                dsSinhVien[i].Input();
            }

            // Goi phuong thuc sap xep tu viet
            SapXep.SapXepMang(dsSinhVien);

            // Xuat ket qua
            Console.WriteLine("\nDanh sach sinh vien sau khi sap xep:");

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
Danh sach sinh vien sau khi sap xep:
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
Danh sach sinh vien sau khi sap xep:
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
Danh sach sinh vien sau khi sap xep:
Ho ten: Tran Van B - Diem: 8
Ho ten: Nguyen Van A - Diem: 10
*/