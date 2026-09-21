/*
* BÀI 7: PHƯƠNG THỨC BOOL
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 16/09/2026
*
* Phát biểu đề bài: Xây dựng lớp có phương thức kiểm tra n có phải là số nguyên tố hay không.
*
* Ý tưởng:
* - Số nguyên tố là số lớn hơn 1 và chỉ chia hết cho 1
*   và chính nó.
* - Kiểm tra n có chia hết cho các số từ 2 đến n - 1 hay không.
* - Nếu có thì trả về false.
* - Nếu không có thì trả về true.
*/

using System;

namespace TH01
{
    class Bai07
    {
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static void ChayBai07()
        {
            // Khai bao bien
            int n;

            // Nhap du lieu
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            // Xu ly va xuat ket qua
            if (KiemTraSoNguyenTo(n))
                Console.WriteLine(n + " la so nguyen to.");
            else
                Console.WriteLine(n + " khong phai la so nguyen to.");
        }
    }
}

/*
- TEST CASE 1:
Input: 7
Output: 7 la so nguyen to.

- TEST CASE 2:
Input: 10
Output: 10 khong phai la so nguyen to.

- TEST CASE 3:
Input: 2
Output: 2 la so nguyen to.

- TEST CASE 4:
Input: 1
Output: 1 khong phai la so nguyen to.

- TEST CASE 5:
Input: -5
Output: -5 khong phai la so nguyen to.
*/