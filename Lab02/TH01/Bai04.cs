/*
* BÀI 4: NHẬP SỐ NGUYÊN VÀ THÔNG BÁO LỖI
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 15/09/2026
*
* Phát biểu đề bài: Làm lại bài 3, nhưng thông báo lỗi khi x hay y không phải là số nguyên.
*
* Ý tưởng:
* - Nhập x và kiểm tra x có phải số nguyên hay không.
* - Nhập y và kiểm tra y có phải số nguyên hay không.
* - Nếu x hoặc y không phải số nguyên thì thông báo lỗi.
* - Nếu cả hai đều là số nguyên thì tính x^y.
*/

using System;

namespace TH01
{
    class Bai04
    {
        public static void ChayBai04()
        {
            // Khai bao bien
            int x, y;
            double ketQua;

            // Nhap du lieu
            Console.Write("Nhap so nguyen x: ");
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Loi: x khong phai la so nguyen!");
                return;
            }

            Console.Write("Nhap so nguyen y: ");
            if (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Loi: y khong phai la so nguyen!");
                return;
            }

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
x = 5
y = 0
Output: Ket qua 5 mu 0 la: 1

- TEST CASE 3:
Input:
x = -2
y = 3
Output: Ket qua -2 mu 3 la: -8

- TEST CASE 4:
Input:
x = 7.5
y = 3
Output: Loi: x khong phai la so nguyen!

- TEST CASE 5:
Input:
x = 7
y = abc
Output: Loi: y khong phai la so nguyen!
*/