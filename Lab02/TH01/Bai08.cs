/*
* BÀI 8: THAM CHIẾU REF
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 16/09/2026
*
* Phát biểu đề bài: Xây dựng lớp có phương thức hoán vị hai số thực.
*
* Ý tưởng:
* - Sử dụng tham chiếu ref để thay đổi trực tiếp giá trị của hai số thực.
* - Dùng biến trung gian để hoán vị hai giá trị.
*
* Mã giả:
* - Nhập a, b.
* - Gọi phương thức HoanVi(ref a, ref b).
* - Xuất a, b sau khi hoán vị.
*/

using System;

namespace TH01
{
    class Bai08
    {
        public static void HoanVi(ref double a, ref double b)
        {
            double tam;

            tam = a;
            a = b;
            b = tam;
        }

        public static void ChayBai08()
        {
            // Khai bao bien
            double a, b;

            // Nhap du lieu
            Console.Write("Nhap so thuc a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc b: ");
            b = double.Parse(Console.ReadLine());

            // Xu ly
            HoanVi(ref a, ref b);

            // Xuat ket qua
            Console.WriteLine("Sau khi hoan vi:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}

/*
- TEST CASE 1:
Input:
a = 10
b = 20

Output:
Sau khi hoan vi:
a = 20
b = 10

- TEST CASE 2:
Input:
a = -5.5
b = 3.2

Output:
Sau khi hoan vi:
a = 3.2
b = -5.5

- TEST CASE 3:
Input:
a = 7.5
b = 7.5

Output:
Sau khi hoan vi:
a = 7.5
b = 7.5

- TEST CASE 4:
Input:
a = 0
b = 12.5

Output:
Sau khi hoan vi:
a = 12.5
b = 0
*/