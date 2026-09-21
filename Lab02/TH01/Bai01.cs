/*
* BÀI 1: MÃ NGUỒN CHƯƠNG TRÌNH
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 15/09/2026
*
* Phát biểu đề bài: Nhập họ tên và xuất họ tên đã nhập ra màn hình console.
*
* Ý tưởng:
* - Khai báo biến họ tên.
* - Nhập họ tên bằng Console.ReadLine().
* - Xuất họ tên bằng Console.WriteLine().
*/

using System;

namespace TH01
{
    class Bai01
    {
        public static void ChayBai01()
        {
            // Khai bao bien
            string hoTen = "";

            // Nhap du lieu
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            // Xuất ket qua
            Console.WriteLine("Ho ten vua nhap: " + hoTen);
        }
    }
}