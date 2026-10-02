/*
* TRUY VẤN MẢNG SỐ NGUYÊN BẰNG LINQ
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 29/09/2026
*
* Phát biểu đề bài:
* Cho mảng số nguyên:
* int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
*
* a. Liệt kê các phần tử chia hết cho 4 và 3.
* b. Liệt kê các phần tử nhỏ hơn hoặc bằng 3.
* c. Tạo một dãy mới: số chẵn chia đôi, số lẻ giữ nguyên giá trị.
*
* Ý tưởng:
* - Dùng LINQ Where để lọc các phần tử theo điều kiện.
* - Dùng LINQ Select để tạo dãy mới.
*
* Mã giả:
* - Khai báo mảng số nguyên.
* - Dùng Where lọc các số chia hết cho 4 và 3.
* - Dùng Where lọc các số nhỏ hơn hoặc bằng 3.
* - Dùng Select: số chẵn chia 2, số lẻ giữ nguyên.
* - Xuất kết quả.
*/

using System;
using System.Linq;

namespace Lab03
{
    class Bai02_1
    {
        public static void ChayBai02_1()
        {
            // Khai bao bien
            int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

            // a. Liet ke cac phan tu chia het cho 4 va 3
            var cauA = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);

            Console.WriteLine("a. Cac phan tu chia het cho 4 va 3:");
            foreach (int x in cauA)
            {
                Console.Write(x + " ");
            }

            // b. Liet ke cac phan tu nho hon hoac bang 3
            var cauB = mangSo.Where(x => x <= 3);

            Console.WriteLine("\n\nb. Cac phan tu nho hon hoac bang 3:");
            foreach (int x in cauB)
            {
                Console.Write(x + " ");
            }

            // c. So chan chia doi, so le giu nguyen
            var cauC = mangSo.Select(x =>
            {
                if (x % 2 == 0)
                    return x / 2;
                else
                    return x;
            });

            Console.WriteLine("\n\nc. Day moi:");
            foreach (int x in cauC)
            {
                Console.Write(x + " ");
            }
        }
    }
}