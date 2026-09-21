/*
* BÀI 2: XUẤT VÀ NHẬP CHUỖI
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 15/09/2026
*
* Phát biểu đề bài: Nhập họ tên và xuất họ tên đã nhập ra màn hình console theo định dạng yêu cầu.
*
* Ý tưởng:
* - Khai báo biến họ tên.
* - Nhập họ tên bằng Console.ReadLine().
* - Xuất lời chào có họ tên vừa nhập.
*/

using System;

namespace TH01
{
    class Bai02
    {
        public static void ChayBai02()
        {
            // Khai bao bien
            string hoTen = "";

            // Nhap du lieu
            Console.Write("Nhap ho ten cua ban: ");
            hoTen = Console.ReadLine();

            // Xuat ket qua
            Console.WriteLine("Chao ban " + hoTen + "!");
        }
    }
}

/*
- TEST CASE 1:
Input: Tran Anh Minh
Output: Nhap ho ten cua ban: Tran Anh Minh
Chao ban Tran Anh Minh!

- TEST CASE 2:
Input: Nguyen Thien Phu
Output: Nhap ho ten cua ban: Nguyen Thien Phu
Chao ban Nguyen Thien Phu!
*/
