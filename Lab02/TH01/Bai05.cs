/*
* BÀI 5: MENU
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 15/09/2026
*
* Phát biểu đề bài: In menu và xử lý các lựa chọn:
*   1. Nhập hai giá trị số thực cho x, y
*   2. Tính x^y
*   3. Tính căn bậc 2 của x và y
*   4. Thoát
*
* Ý tưởng:
* - Dùng vòng lặp để menu xuất hiện liên tục.
* - Nhập lựa chọn của người dùng.
* - Dùng switch để xử lý từng chức năng.
*/

using System;

namespace TH01
{
    class Bai05
    {
        public static void ChayBai05()
        {
            // Khai bao bien
            double x = 0, y = 0;
            int chon;
            bool daNhap = false;

            // Xu ly menu
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap x: ");
                        x = double.Parse(Console.ReadLine());

                        Console.Write("Nhap y: ");
                        y = double.Parse(Console.ReadLine());

                        daNhap = true;
                        break;

                    case 2:
                        if (daNhap)
                        {
                            Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + Math.Pow(x, y));
                        }
                        else
                        {
                            Console.WriteLine("Vui long chon chuc nang 1 truoc!");
                        }
                        break;

                    case 3:
                        if (daNhap)
                        {
                            if (x >= 0)
                                Console.WriteLine("Can bac 2 cua x la: " + Math.Sqrt(x));
                            else
                                Console.WriteLine("Khong the tinh can bac 2 cua x!");

                            if (y >= 0)
                                Console.WriteLine("Can bac 2 cua y la: " + Math.Sqrt(y));
                            else
                                Console.WriteLine("Khong the tinh can bac 2 cua y!");
                        }
                        else
                        {
                            Console.WriteLine("Vui long chon chuc nang 1 truoc!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thoat chuong trinh!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                Console.WriteLine();

            } while (chon != 4);
        }
    }
}

/*
- TEST CASE 1:
Input:
1
x = 4
y = 2
2
3
4

Output:
MENU
1. Nhap hai gia tri so thuc cho x, y
2. Tinh x^y
3. Tinh can bac 2 cua x va y
4. Thoat
Chon chuc nang: 1
Nhap x: 4
Nhap y: 2

Chon chuc nang: 2
Ket qua 4 mu 2 la: 16

Chon chuc nang: 3
Can bac 2 cua x la: 2
Can bac 2 cua y la: 1.4142135623730951

Chon chuc nang: 4
Thoat chuong trinh!
*/