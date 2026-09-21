/*
* BÀI 2.7: TÍNH LƯƠNG NHÂN VIÊN
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 20/09/2026
*
* Phát biểu đề bài:
* Một phòng ban có n nhân viên (họ tên, mức lương, số ngày vắng).
* Biết rằng một ngày vắng sẽ bị trừ 100.000 VNĐ.
* Hãy tính tổng lương của phòng ban.
*
* Ý tưởng:
* - Xây dựng lớp NhanVienBai27 để lưu thông tin một nhân viên.
* - Xây dựng lớp PhongBan để lưu danh sách n nhân viên.
* - Tính lương của mỗi nhân viên:
*   Luong = MucLuong - SoNgayVang * 100000.
* - Tính tổng lương bằng cách cộng lương của tất cả nhân viên.
*
* Mã giả:
* - Khai báo lớp NhanVienBai27.
* - Khai báo lớp PhongBan chứa mảng nhân viên.
* - Xây dựng Constructor mặc nhiên.
* - Xây dựng Constructor có tham số.
* - Xây dựng Constructor sao chép.
* - Xây dựng Indexer this[i].
* - Nhập danh sách nhân viên.
* - Xuất danh sách nhân viên.
* - Tính lương từng nhân viên.
* - Tính tổng lương của phòng ban.
*/

using System;

namespace TH02
{
    // Lớp nhân viên riêng cho Bài 2.7
    class NhanVienBai27
    {
        // Field
        private string hoTen;
        private double mucLuong;
        private int soNgayVang;

        // Constructor mac nhien
        public NhanVienBai27()
        {
            hoTen = "";
            mucLuong = 0;
            soNgayVang = 0;
        }

        // Constructor co tham so
        public NhanVienBai27(string hoTen, double mucLuong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.soNgayVang = soNgayVang;
        }

        // Constructor sao chep
        public NhanVienBai27(NhanVienBai27 nv)
        {
            hoTen = nv.hoTen;
            mucLuong = nv.mucLuong;
            soNgayVang = nv.soNgayVang;
        }

        // Property HoTen
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }

        // Property MucLuong
        public double MucLuong
        {
            get
            {
                return mucLuong;
            }
            set
            {
                mucLuong = value;
            }
        }

        // Property SoNgayVang
        public int SoNgayVang
        {
            get
            {
                return soNgayVang;
            }
            set
            {
                soNgayVang = value;
            }
        }

        // Nhap thong tin nhan vien
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap muc luong: ");
            mucLuong = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap so ngay vang: ");
                soNgayVang = int.Parse(Console.ReadLine());

                if (soNgayVang < 0)
                    Console.WriteLine("So ngay vang phai lon hon hoac bang 0!");
            }
            while (soNgayVang < 0);
        }

        // Tinh luong
        public double TinhLuong()
        {
            return mucLuong - soNgayVang * 100000;
        }

        // Xuat thong tin nhan vien
        public void Output()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Muc luong: " + mucLuong);
            Console.WriteLine("So ngay vang: " + soNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
    }


    class PhongBan
    {
        // Field
        private NhanVienBai27[] dsNhanVien;

        // Constructor mac nhien
        public PhongBan()
        {
            dsNhanVien = new NhanVienBai27[0];
        }

        // Constructor co tham so
        public PhongBan(int n)
        {
            dsNhanVien = new NhanVienBai27[n];

            for (int i = 0; i < n; i++)
            {
                dsNhanVien[i] = new NhanVienBai27();
            }
        }

        // Constructor sao chep
        public PhongBan(PhongBan p)
        {
            dsNhanVien = new NhanVienBai27[p.dsNhanVien.Length];

            for (int i = 0; i < p.dsNhanVien.Length; i++)
            {
                dsNhanVien[i] = new NhanVienBai27(p.dsNhanVien[i]);
            }
        }

        // Indexer
        public NhanVienBai27 this[int i]
        {
            get
            {
                return dsNhanVien[i];
            }
            set
            {
                dsNhanVien[i] = value;
            }
        }

        // So luong nhan vien
        public int SoLuong
        {
            get
            {
                return dsNhanVien.Length;
            }
        }

        // Nhap danh sach nhan vien
        public void Input()
        {
            for (int i = 0; i < dsNhanVien.Length; i++)
            {
                Console.WriteLine("\nNhap nhan vien thu " + (i + 1) + ":");
                dsNhanVien[i].Input();
            }
        }

        // Xuat danh sach nhan vien
        public void Output()
        {
            for (int i = 0; i < dsNhanVien.Length; i++)
            {
                Console.WriteLine("\nNhan vien thu " + (i + 1) + ":");
                dsNhanVien[i].Output();
            }
        }

        // Tinh tong luong phong ban
        public double TinhTongLuong()
        {
            double tongLuong = 0;

            for (int i = 0; i < dsNhanVien.Length; i++)
            {
                tongLuong = tongLuong + dsNhanVien[i].TinhLuong();
            }

            return tongLuong;
        }
    }


    class Bai02_7
    {
        public static void ChayBai02_7()
        {
            // Khai bao bien
            int n;
            PhongBan phongBan;
            double tongLuong;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so luong nhan vien n: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("n phai lon hon 0!");
            }
            while (n <= 0);

            phongBan = new PhongBan(n);

            Console.WriteLine("\nNhap danh sach nhan vien:");
            phongBan.Input();

            // Xu ly
            tongLuong = phongBan.TinhTongLuong();

            // Xuat ket qua
            Console.WriteLine("\nDANH SACH NHAN VIEN:");
            phongBan.Output();

            Console.WriteLine("\nTong luong cua phong ban: " + tongLuong);

            // Kiem tra Indexer
            Console.WriteLine(
                "\nNhan vien thu 0 thong qua Indexer: "
                + phongBan[0].HoTen
            );
        }
    }
}


/*
- TEST CASE 1:
Input:
2
Nguyen Van A
10000000
2
Tran Thi B
12000000
1

Output:
Nhan vien thu 1:
Ho ten: Nguyen Van A
Muc luong: 10000000
So ngay vang: 2
Luong thuc nhan: 9800000

Nhan vien thu 2:
Ho ten: Tran Thi B
Muc luong: 12000000
So ngay vang: 1
Luong thuc nhan: 11900000

Tong luong cua phong ban: 21700000
Nhan vien thu 0 thong qua Indexer: Nguyen Van A


- TEST CASE 2:
Input:
3
Nguyen Van A
8000000
0
Tran Thi B
9000000
2
Le Van C
10000000
5

Output:
Nhan vien thu 1:
Ho ten: Nguyen Van A
Muc luong: 8000000
So ngay vang: 0
Luong thuc nhan: 8000000

Nhan vien thu 2:
Ho ten: Tran Thi B
Muc luong: 9000000
So ngay vang: 2
Luong thuc nhan: 8800000

Nhan vien thu 3:
Ho ten: Le Van C
Muc luong: 10000000
So ngay vang: 5
Luong thuc nhan: 9500000

Tong luong cua phong ban: 26300000
Nhan vien thu 0 thong qua Indexer: Nguyen Van A


- TEST CASE 3:
Input:
1
Pham Van D
15000000
3

Output:
Nhan vien thu 1:
Ho ten: Pham Van D
Muc luong: 15000000
So ngay vang: 3
Luong thuc nhan: 14700000

Tong luong cua phong ban: 14700000
Nhan vien thu 0 thong qua Indexer: Pham Van D
*/