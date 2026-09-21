/*
* BÀI 3.5: TÍNH LƯƠNG NHÂN VIÊN
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 21/09/2026
*
* Phát biểu đề bài: Trong một công ty X, các nhân viên thuộc một trong hai bộ phận: nhân viên kinh doanh và nhân viên sản xuất.
*
* Thông tin cơ bản của nhân viên gồm:
* - Mã nhân viên
* - Họ tên
*
* Cách tính lương:
* - Nhân viên kinh doanh: ngoài mức lương cơ bản hàng tháng,
*   nhận thêm 500.000 đồng trên mỗi hợp đồng được ký kết.
* - Nhân viên sản xuất: lương tính theo số lượng sản phẩm x 1.000.
*   Nếu làm trên 3.000 sản phẩm thì được thưởng thêm 5% lương.
*
* Ý tưởng:
* - Xây dựng lớp NhanVienBai35 làm lớp cha.
* - Xây dựng lớp NhanVienKinhDoanh kế thừa NhanVienBai35.
* - Xây dựng lớp NhanVienSanXuat kế thừa NhanVienBai35.
* - Mỗi lớp con override phương thức TinhLuong().
* - Sử dụng mảng kiểu NhanVienBai35 để lưu các loại nhân viên.
* - Gọi TinhLuong() để thể hiện tính đa hình.
*
* Mã giả:
* - Khai báo lớp NhanVienBai35.
* - Khai báo phương thức TinhLuong().
* - Xây dựng lớp NhanVienKinhDoanh kế thừa NhanVienBai35.
* - Xây dựng lớp NhanVienSanXuat kế thừa NhanVienBai35.
* - Override phương thức TinhLuong().
* - Nhập danh sách nhân viên.
* - Tính và xuất lương từng nhân viên.
*/

using System;

namespace TH02
{
    // Lớp cha
    class NhanVienBai35
    {
        protected string maNhanVien;
        protected string hoTen;
        protected double luongCoBan;

        // Constructor mặc nhiên
        public NhanVienBai35()
        {
            maNhanVien = "";
            hoTen = "";
            luongCoBan = 0;
        }

        // Constructor có tham số
        public NhanVienBai35(string maNhanVien, string hoTen, double luongCoBan)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.luongCoBan = luongCoBan;
        }

        // Nhập thông tin chung
        public virtual void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            maNhanVien = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap luong co ban: ");
            luongCoBan = double.Parse(Console.ReadLine());
        }

        // Tính lương
        public virtual double TinhLuong()
        {
            return luongCoBan;
        }

        // Xuất thông tin chung
        public virtual void Output()
        {
            Console.WriteLine("Ma nhan vien: " + maNhanVien);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }

    // Lớp nhân viên kinh doanh
    class NhanVienKinhDoanh : NhanVienBai35
    {
        private int soHopDong;

        // Constructor mặc nhiên
        public NhanVienKinhDoanh()
        {
            soHopDong = 0;
        }

        // Constructor có tham số
        public NhanVienKinhDoanh(
            string maNhanVien,
            string hoTen,
            double luongCoBan,
            int soHopDong) : base(maNhanVien, hoTen, luongCoBan)
        {
            this.soHopDong = soHopDong;
        }

        // Nhập thông tin
        public override void Input()
        {
            base.Input();

            Console.Write("Nhap so hop dong: ");
            soHopDong = int.Parse(Console.ReadLine());
        }

        // Tính lương
        public override double TinhLuong()
        {
            return luongCoBan + soHopDong * 500000;
        }

        // Xuất thông tin
        public override void Output()
        {
            Console.WriteLine("Loai: Nhan vien kinh doanh");
            base.Output();
            Console.WriteLine("So hop dong: " + soHopDong);
        }
    }

    // Lớp nhân viên sản xuất
    class NhanVienSanXuat : NhanVienBai35
    {
        private int soSanPham;

        // Constructor mặc nhiên
        public NhanVienSanXuat()
        {
            soSanPham = 0;
        }

        // Constructor có tham số
        public NhanVienSanXuat(
            string maNhanVien,
            string hoTen,
            int soSanPham) : base(maNhanVien, hoTen, 0)
        {
            this.soSanPham = soSanPham;
        }

        // Nhập thông tin
        public override void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            maNhanVien = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap so san pham: ");
            soSanPham = int.Parse(Console.ReadLine());
        }

        // Tính lương
        public override double TinhLuong()
        {
            double luong;

            luong = soSanPham * 1000;

            if (soSanPham > 3000)
                luong = luong + luong * 0.05;

            return luong;
        }

        // Xuất thông tin
        public override void Output()
        {
            Console.WriteLine("Loai: Nhan vien san xuat");
            Console.WriteLine("Ma nhan vien: " + maNhanVien);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("So san pham: " + soSanPham);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }

    class Bai03_5
    {
        public static void ChayBai03_5()
        {
            int n;
            int loai;
            NhanVienBai35[] dsNhanVien;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so luong nhan vien: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("So luong nhan vien phai lon hon 0!");
            }
            while (n <= 0);

            dsNhanVien = new NhanVienBai35[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhan vien thu " + (i + 1));
                Console.WriteLine("1. Nhan vien kinh doanh");
                Console.WriteLine("2. Nhan vien san xuat");

                do
                {
                    Console.Write("Chon loai nhan vien: ");
                    loai = int.Parse(Console.ReadLine());

                    if (loai != 1 && loai != 2)
                        Console.WriteLine("Loai nhan vien khong hop le!");
                }
                while (loai != 1 && loai != 2);

                if (loai == 1)
                {
                    dsNhanVien[i] = new NhanVienKinhDoanh();
                }
                else
                {
                    dsNhanVien[i] = new NhanVienSanXuat();
                }

                dsNhanVien[i].Input();
            }

            // Xuat ket qua
            Console.WriteLine("\n========== DANH SACH NHAN VIEN ==========");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhan vien thu " + (i + 1) + ":");

                dsNhanVien[i].Output();
            }
        }
    }
}

/*
- TEST CASE 1:
Input:
2
1
KD01
Nguyen Van A
10000000
4
2
SX01
Tran Van B
3500

Output:
Nhan vien thu 1:
Loai: Nhan vien kinh doanh
Ma nhan vien: KD01
Ho ten: Nguyen Van A
Luong: 12000000
So hop dong: 4

Nhan vien thu 2:
Loai: Nhan vien san xuat
Ma nhan vien: SX01
Ho ten: Tran Van B
So san pham: 3500
Luong: 3675000


- TEST CASE 2:
Input:
2
1
KD02
Le Van C
8000000
3
2
SX02
Pham Van D
3000

Output:
Nhan vien thu 1:
Loai: Nhan vien kinh doanh
Ma nhan vien: KD02
Ho ten: Le Van C
Luong: 9500000
So hop dong: 3

Nhan vien thu 2:
Loai: Nhan vien san xuat
Ma nhan vien: SX02
Ho ten: Pham Van D
So san pham: 3000
Luong: 3000000


- TEST CASE 3:
Input:
1
2
SX03
Hoang Van E
4000

Output:
Nhan vien thu 1:
Loai: Nhan vien san xuat
Ma nhan vien: SX03
Ho ten: Hoang Van E
So san pham: 4000
Luong: 4200000
*/