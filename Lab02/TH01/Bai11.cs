/*
* BÀI 11: ĐẢO CHUỖI
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 17/09/2026
*
* Phát biểu đề bài: Viết phương thức thành viên trả về chuỗi là đảo của một chuỗi.
*
* Ý tưởng:
* - Duyệt chuỗi từ ký tự cuối về ký tự đầu.
* - Ghép các ký tự vào chuỗi kết quả.
* - Trả về chuỗi kết quả.
*
* Mã giả:
* - Nhập chuỗi.
* - Duyệt từ vị trí cuối về vị trí đầu.
* - Thêm từng ký tự vào chuỗi đảo.
* - Trả về chuỗi đảo.
*/

using System;

namespace TH01
{
    class Bai11
    {
        public static string DaoChuoi(string chuoi)
        {
            string ketQua = "";

            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                ketQua = ketQua + chuoi[i];
            }

            return ketQua;
        }

        public static void ChayBai11()
        {
            // Khai bao bien
            string chuoi = "";
            string chuoiDao = "";

            // Nhap du lieu
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();

            // Xu ly
            chuoiDao = DaoChuoi(chuoi);

            // Xuat ket qua
            Console.WriteLine("Chuoi dao la: " + chuoiDao);
        }
    }
}

/*
- TEST CASE 1:
Input: hello
Output: Chuoi dao la: olleh


- TEST CASE 2:
Input: abcde
Output: Chuoi dao la: edcba


- TEST CASE 3:
Input: madam
Output: Chuoi dao la: madam


- TEST CASE 4:
Input: Nguyen Thien Phu
Output: Chuoi dao la: uhP neihT neyugN


- TEST CASE 5:
Input: a
Output: Chuoi dao la: a
*/