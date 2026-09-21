/*
* BÀI 9: THAM CHIẾU OUT
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 16/09/2026
*
* Phát biểu đề bài: Xây dựng lớp có phương thức tìm giá trị lớn nhất và giá trị nhỏ nhất của ba số thực.
*
* Ý tưởng:
* - Sử dụng tham chiếu out để trả về đồng thời giá trị lớn nhất và giá trị nhỏ nhất.
* - Gán số đầu tiên cho max và min.
* - So sánh lần lượt với hai số còn lại.
*
* Mã giả:
* - Nhập a, b, c.
* - Gọi phương thức TimMaxMin(a, b, c, out max, out min).
* - Xuất max và min.
*/

using System;

namespace TH01
{
    class Bai09
    {
        public static void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            max = a;
            min = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            if (b < min)
                min = b;

            if (c < min)
                min = c;
        }

        public static void ChayBai09()
        {
            // Khai bao bien
            double a, b, c;
            double max, min;

            // Nhap du lieu
            Console.Write("Nhap so thuc a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc c: ");
            c = double.Parse(Console.ReadLine());

            // Xu ly
            TimMaxMin(a, b, c, out max, out min);

            // Xuat ket qua
            Console.WriteLine("Gia tri lon nhat la: " + max);
            Console.WriteLine("Gia tri nho nhat la: " + min);
        }
    }
}

/*
- TEST CASE 1:
Input:
a = 5.5
b = 10.2
c = 3.7

Output:
Gia tri lon nhat la: 10.2
Gia tri nho nhat la: 3.7


- TEST CASE 2:
Input:
a = 20
b = 10
c = 15

Output:
Gia tri lon nhat la: 20
Gia tri nho nhat la: 10


- TEST CASE 3:
Input:
a = -5.5
b = -2.2
c = -10.5

Output:
Gia tri lon nhat la: -2.2
Gia tri nho nhat la: -10.5


- TEST CASE 4:
Input:
a = 7.5
b = 7.5
c = 7.5

Output:
Gia tri lon nhat la: 7.5
Gia tri nho nhat la: 7.5


- TEST CASE 5:
Input:
a = 0
b = 12.5
c = -3.5

Output:
Gia tri lon nhat la: 12.5
Gia tri nho nhat la: -3.5
*/