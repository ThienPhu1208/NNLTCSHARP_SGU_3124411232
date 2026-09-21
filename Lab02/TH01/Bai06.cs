/*
* BÀI 6: RETURN GIÁ TRỊ
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 16/09/2026
*
* Phát biểu đề bài: Xây dựng lớp có phương thức tìm giá trị lớn nhất của ba số nguyên.
*
* Ý tưởng:
* - Nhập ba số nguyên.
* - So sánh ba số để tìm số lớn nhất.
* - Phương thức trả về giá trị lớn nhất.
*/

using System;

namespace TH01
{
    class Bai06
    {
        public static int TimMax(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            return max;
        }

        public static void ChayBai06()
        {
            // Khai bao bien
            int a, b, c;
            int ketQua;

            // Nhap du lieu
            Console.Write("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen c: ");
            c = int.Parse(Console.ReadLine());

            // Xu ly
            ketQua = TimMax(a, b, c);

            // Xuat ket qua
            Console.WriteLine("Gia tri lon nhat la: " + ketQua);
        }
    }
}

/*
- TEST CASE 1:
Input:
15
8
20
Output: Gia tri lon nhat la: 20

- TEST CASE 2:
Input:
5
12
7
Output: Gia tri lon nhat la: 12

- TEST CASE 3:
Input:
9
9
5
Output: Gia tri lon nhat la: 9

- TEST CASE 4:
Input:
-10
-5
-20
Output: Gia tri lon nhat la: -5

- TEST CASE 5:
Input:
0
-3
8
Output: Gia tri lon nhat la: 8
*/