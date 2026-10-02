/*
* THỐNG KÊ VÀ PHÂN NHÓM MẢNG SỐ
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 29/09/2026
*
* Phát biểu đề bài:
* Cho mảng:
* int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
*
* a. Cho biết tổng số phần tử, số phần tử chẵn và số phần tử lẻ.
* b. Tính tổng các giá trị, giá trị lớn nhất và giá trị nhỏ nhất.
* c. Cho biết có bao nhiêu giá trị khác nhau trong mảng.
* d. Phân nhóm các phần tử theo số dư khi chia cho 5;
*    in số dư và các phần tử thuộc từng nhóm.
*
* Ý tưởng:
* - Dùng Count để đếm số phần tử.
* - Dùng Where để lọc số chẵn và số lẻ.
* - Dùng Sum để tính tổng.
* - Dùng Max và Min để tìm giá trị lớn nhất và nhỏ nhất.
* - Dùng Distinct để lấy các giá trị khác nhau.
* - Dùng GroupBy để phân nhóm theo số dư khi chia cho 5.
*
* Mã giả:
* - Khai báo mảng số nguyên.
* - Đếm tổng số phần tử.
* - Lọc và đếm số chẵn, số lẻ.
* - Tính tổng, tìm lớn nhất và nhỏ nhất.
* - Lấy các giá trị khác nhau và đếm.
* - Nhóm các phần tử theo số dư khi chia cho 5.
* - Xuất kết quả.
*/

using System;
using System.Linq;

namespace Lab03
{
    class Bai03_1
    {
        public static void ChayBai03_1()
        {
            // Khai bao bien
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

            // a. Tong so phan tu, so chan, so le
            int tongSoPhanTu = mangSo.Count();
            int soChan = mangSo.Count(x => x % 2 == 0);
            int soLe = mangSo.Count(x => x % 2 != 0);

            Console.WriteLine("a. Thong ke so phan tu:");
            Console.WriteLine("Tong so phan tu: " + tongSoPhanTu);
            Console.WriteLine("So phan tu chan: " + soChan);
            Console.WriteLine("So phan tu le: " + soLe);

            // b. Tong, lon nhat, nho nhat
            int tong = mangSo.Sum();
            int lonNhat = mangSo.Max();
            int nhoNhat = mangSo.Min();

            Console.WriteLine("\nb. Thong ke gia tri:");
            Console.WriteLine("Tong cac gia tri: " + tong);
            Console.WriteLine("Gia tri lon nhat: " + lonNhat);
            Console.WriteLine("Gia tri nho nhat: " + nhoNhat);

            // c. Dem so gia tri khac nhau
            int soGiaTriKhacNhau = mangSo.Distinct().Count();

            Console.WriteLine("\nc. So gia tri khac nhau: " + soGiaTriKhacNhau);

            // d. Phan nhom theo so du khi chia cho 5
            var nhom = mangSo.GroupBy(x => x % 5)
                             .OrderBy(g => g.Key);

            Console.WriteLine("\nd. Phan nhom theo so du khi chia cho 5:");

            foreach (var group in nhom)
            {
                Console.Write("So du " + group.Key + ": ");

                foreach (int x in group)
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();
            }
        }
    }
}