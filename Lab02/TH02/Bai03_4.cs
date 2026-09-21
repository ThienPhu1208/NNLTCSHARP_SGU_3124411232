 /*
* BÀI 3.4*: XÂY DỰNG LỚP CONSOLEMENU TỔNG QUÁT
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 21/09/2026
*
* Phát biểu đề bài:
* Xây dựng lớp ConsoleMenu tổng quát có chức năng:
*
* Menu
* 1. Chức năng 1
* 2. Chức năng 2
* 0. Thoát chương trình
* Thực hiện: x
* Bạn thực hiện chức năng x
*
* Áp dụng cho bài toán giải phương trình bậc 2,
* với thư viện hỗ trợ mở rộng qua sự kiện, kế thừa.
*
* Ý tưởng:
* - Xây dựng delegate để xử lý sự kiện chọn chức năng.
* - Xây dựng lớp ConsoleMenu chứa menu tổng quát.
* - Tạo sự kiện Choose để xử lý chức năng được chọn.
* - Lớp PTBac2Console kế thừa từ ConsoleMenu.
* - Đăng ký các chức năng giải phương trình bậc 2
*   thông qua sự kiện Choose.
*
* Mã giả:
* - Khai báo delegate ChooseHandler.
* - Xây dựng lớp ConsoleMenu.
* - Tạo sự kiện Choose.
* - Hiển thị menu.
* - Nhập lựa chọn.
* - Phát sinh sự kiện Choose.
* - Xây dựng lớp PTBac2Console kế thừa ConsoleMenu.
* - Đăng ký chức năng nhập phương trình.
* - Đăng ký chức năng giải phương trình.
* - Chạy chương trình.
*/

using System;

namespace TH02
{
    // Delegate xử lý sự kiện chọn chức năng
    delegate void ChooseHandler(int chucNang);

    // Lớp ConsoleMenu tổng quát
    class ConsoleMenu
    {
        // Sự kiện Choose
        public event ChooseHandler Choose;

        // Hiển thị menu
        public void ShowMenu()
        {
            Console.WriteLine("\n========== MENU ==========");
            Console.WriteLine("1. Nhap phuong trinh");
            Console.WriteLine("2. Giai phuong trinh");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.WriteLine("==========================");
        }

        // Chạy menu
        public void Run()
        {
            int luaChon;

            do
            {
                ShowMenu();

                Console.Write("Thuc hien: ");
                luaChon = int.Parse(Console.ReadLine());

                if (luaChon == 0)
                {
                    Console.WriteLine("Thoat chuong trinh.");
                }
                else if (luaChon >= 1 && luaChon <= 2)
                {
                    Console.WriteLine("Ban thuc hien chuc nang " + luaChon);

                    // Phat sinh su kien Choose
                    if (Choose != null)
                        Choose(luaChon);
                }
                else
                {
                    Console.WriteLine("Chuc nang khong hop le!");
                }

            }
            while (luaChon != 0);
        }
    }

    // Lớp phương trình bậc 2 kế thừa ConsoleMenu
    class PTBac2Console : ConsoleMenu
    {
        private double a;
        private double b;
        private double c;

        // Nhập phương trình
        public void NhapPhuongTrinh()
        {
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            c = double.Parse(Console.ReadLine());
        }

        // Giải phương trình
        public void GiaiPhuongTrinh()
        {
            double delta;
            double x1;
            double x2;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem x = " + x1);
                }

                return;
            }

            delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);

                Console.WriteLine("Phuong trinh co nghiem kep x = " + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Phuong trinh co 2 nghiem:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }

        // Xử lý sự kiện Choose
        public void XuLyChucNang(int chucNang)
        {
            if (chucNang == 1)
            {
                NhapPhuongTrinh();
            }
            else if (chucNang == 2)
            {
                GiaiPhuongTrinh();
            }
        }
    }

    class Bai03_4
    {
        public static void ChayBai03_4()
        {
            PTBac2Console app = new PTBac2Console();

            // Đăng ký sự kiện Choose
            app.Choose += app.XuLyChucNang;

            // Chạy menu
            app.Run();
        }
    }
}

/*
- TEST CASE 1:
Input:
1
1
-3
2
2
0

Output:
Ban thuc hien chuc nang 1

Ban thuc hien chuc nang 2
Phuong trinh co 2 nghiem:
x1 = 2
x2 = 1


- TEST CASE 2:
Input:
1
1
2
1
2
0

Output:
Ban thuc hien chuc nang 1

Ban thuc hien chuc nang 2
Phuong trinh co nghiem kep x = -1


- TEST CASE 3:
Input:
1
1
2
5
2
0

Output:
Ban thuc hien chuc nang 1

Ban thuc hien chuc nang 2
Phuong trinh vo nghiem.


- TEST CASE 4:
Input:
1
0
2
-4
2
0

Output:
Ban thuc hien chuc nang 1

Ban thuc hien chuc nang 2
Phuong trinh co nghiem x = 2
*/