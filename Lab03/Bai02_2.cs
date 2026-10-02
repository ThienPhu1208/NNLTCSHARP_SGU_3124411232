/*
* TRUY VẤN MẢNG CHUỖI BẰNG LINQ
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 29/09/2026
*
* Phát biểu đề bài:
* Cho mảng chuỗi:
* string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
* "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
*
* a. Liệt kê các phần tử có 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên.
* b. Biến đổi mỗi phần tử thành dạng: <chữ thường> - <CHỮ HOA>.
* c. Liệt kê các phần tử có chứa ký tự “u”.
* d. Liệt kê các từ “Thúy Kiều Thúy Vân” bằng cách chọn các phần tử
*    bắt đầu bằng chữ in hoa.
*
* Ý tưởng:
* - Dùng LINQ Where để lọc các phần tử theo điều kiện.
* - Dùng OrderBy để sắp xếp theo ký tự đầu tiên.
* - Dùng Select để biến đổi từng phần tử.
*
* Mã giả:
* - Khai báo mảng chuỗi.
* - Lọc các chuỗi có 4 ký tự và sắp xếp theo ký tự đầu tiên.
* - Chuyển mỗi chuỗi thành chữ thường và chữ hoa.
* - Lọc các chuỗi có chứa ký tự "u".
* - Chọn các chuỗi bắt đầu bằng chữ in hoa.
* - Xuất kết quả.
*/

using System;
using System.Linq;

namespace Lab03
{
    class Bai02_2
    {
        public static void ChayBai02_2()
        {
            // Khai bao bien
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
                                   "Thúy", "Kiều", "là", "chị", "em", "là",
                                   "Thúy", "Vân" };

            // a. Cac phan tu co 4 ky tu va sap xep tang dan theo ky tu dau tien
            var cauA = mangChuoi
                .Where(x => x.Length == 4)
                .OrderBy(x => x);

            Console.WriteLine("a. Cac phan tu co 4 ky tu:");
            foreach (string x in cauA)
            {
                Console.Write(x + " ");
            }

            // b. Bien doi moi phan tu thanh dang chu thuong - CHU HOA
            var cauB = mangChuoi.Select(x => x.ToLower() + " - " + x.ToUpper());

            Console.WriteLine("\n\nb. Chuyen doi chuoi:");
            foreach (string x in cauB)
            {
                Console.WriteLine(x);
            }

            // c. Cac phan tu co chua ky tu "u"
            var cauC = mangChuoi.Where(x => x.ToLower().Contains("u"));

            Console.WriteLine("\n\nc. Cac phan tu co chua ky tu \"u\":");
            foreach (string x in cauC)
            {
                Console.Write(x + " ");
            }

            // d. Cac tu bat dau bang chu in hoa
            var cauD = mangChuoi.Where(x => char.IsUpper(x[0]));

            Console.WriteLine("\n\nd. Cac tu bat dau bang chu in hoa:");
            foreach (string x in cauD)
            {
                Console.Write(x + " ");
            }
        }
    }
}