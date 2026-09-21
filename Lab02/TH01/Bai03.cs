/*
* BÀI 3: NHẬP SỐ NGUYÊN
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 15/09/2026
*
* Phát biểu đề bài: Nhập hai số nguyên x, y. Tính x^y và xuất kết quả.
*
* Ý tưởng:
* - Nhập x và y.
* - Dùng Math.Pow(x, y) để tính x mũ y.
* - Xuất kết quả.
*/

using System;

namespace TH01
{
    class Bai03
    {
        public static void ChayBai03()
        {
            // Khai bao bien
            int x, y;
            double ketQua;

            // Nhap du lieu
            Console.Write("Nhap so nguyen x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine());

            // Xu ly
            ketQua = Math.Pow(x, y);

            // Xuat ket qua
            Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + ketQua);
        }
    }
}

/*
- TEST CASE 1:
Input:
x = 7
y = 3
Output: Ket qua 7 mu 3 la: 343

- TEST CASE 2:
Input:
x = 2
y = 5
Output: Ket qua 2 mu 5 la: 32
*/