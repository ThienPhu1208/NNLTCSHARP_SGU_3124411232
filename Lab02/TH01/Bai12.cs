/*
* BÀI 12: XỬ LÝ CHUỖI
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 17/09/2026
*
* Phát biểu đề bài:
* - Nhập một chuỗi gồm nhiều từ.
* - Chuyển chuỗi sang ký tự thường.
* - Chuyển chuỗi sang ký tự hoa.
* - Đếm số từ trong chuỗi.
*
* Ý tưởng:
* - Dùng ToLower() để chuyển chuỗi sang chữ thường.
* - Dùng ToUpper() để chuyển chuỗi sang chữ hoa.
* - Duyệt chuỗi và đếm số lần bắt đầu một từ.
*
* Mã giả:
* - Nhập chuỗi.
* - Chuyển chuỗi sang chữ thường.
* - Chuyển chuỗi sang chữ hoa.
* - Duyệt từng ký tự để đếm số từ.
* - Xuất kết quả.
*/

using System;

namespace TH01
{
    class Bai12
    {
        public static int DemSoTu(string chuoi)
        {
            int soTu = 0;
            bool dangTrongTu = false;

            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] != ' ' && dangTrongTu == false)
                {
                    soTu++;
                    dangTrongTu = true;
                }
                else if (chuoi[i] == ' ')
                {
                    dangTrongTu = false;
                }
            }

            return soTu;
        }

        public static void ChayBai12()
        {
            // Khai bao bien
            string chuoi = "";
            string chuoiThuong = "";
            string chuoiHoa = "";
            int soTu;

            // Nhap du lieu
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();

            // Xu ly
            chuoiThuong = chuoi.ToLower();
            chuoiHoa = chuoi.ToUpper();
            soTu = DemSoTu(chuoi);

            // Xuat ket qua
            Console.WriteLine("Chuoi ky tu thuong: " + chuoiThuong);
            Console.WriteLine("Chuoi ky tu hoa: " + chuoiHoa);
            Console.WriteLine("So tu trong chuoi: " + soTu);
        }
    }
}

/*
- TEST CASE 1:
Input: Hello World
Output:
Chuoi ky tu thuong: hello world
Chuoi ky tu hoa: HELLO WORLD
So tu trong chuoi: 2

- TEST CASE 2:
Input: Nguyen Thien Phu
Output:
Chuoi ky tu thuong: nguyen thien phu
Chuoi ky tu hoa: NGUYEN THIEN PHU
So tu trong chuoi: 3

- TEST CASE 3:
Input: Hello World C Sharp 
Output:
Chuoi ky tu thuong: hello world c sharp
Chuoi ky tu hoa: HELLO WORLD C SHARP
So tu trong chuoi: 4

- TEST CASE 4:
Input: Lap Trinh C#
Output:
Chuoi ky tu thuong: lap trinh c#
Chuoi ky tu hoa: LAP TRINH C#
So tu trong chuoi: 3

- TEST CASE 5:
Input: Xin Chao
Output:
Chuoi ky tu thuong: xin chao
Chuoi ky tu hoa: XIN CHAO
So tu trong chuoi: 2
*/