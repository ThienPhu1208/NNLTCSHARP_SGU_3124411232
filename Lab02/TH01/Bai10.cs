/*
* BÀI 10: CHUỖI ĐỐI XỨNG
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 16/09/2026
*
* Phát biểu đề bài:
* - Viết phương thức thành viên kiểm tra chuỗi có đối xứng hay không.
*
* Ý tưởng:
* - So sánh ký tự đầu với ký tự cuối.
* - So sánh tiếp các cặp ký tự ở bên trong.
* - Nếu có cặp ký tự khác nhau thì chuỗi không đối xứng.
* - Nếu tất cả các cặp đều giống nhau thì chuỗi đối xứng.
*
* Mã giả:
* - Nhập chuỗi.
* - Duyệt từ đầu và cuối chuỗi.
* - Nếu hai ký tự khác nhau thì trả về false.
* - Nếu không có ký tự khác nhau thì trả về true.
*/

using System;

namespace TH01
{
    class Bai10
    {
        public static bool KiemTraDoiXung(string chuoi)
        {
            int dau = 0;
            int cuoi = chuoi.Length - 1;

            while (dau < cuoi)
            {
                if (chuoi[dau] != chuoi[cuoi])
                    return false;

                dau++;
                cuoi--;
            }

            return true;
        }

        public static void ChayBai10()
        {
            // Khai bao bien
            string chuoi = "";

            // Nhap du lieu
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();

            // Xu ly va xuat ket qua
            if (KiemTraDoiXung(chuoi))
                Console.WriteLine("Chuoi doi xung.");
            else
                Console.WriteLine("Chuoi khong doi xung.");
        }
    }
}

/*
- TEST CASE 1:
Input: madam
Output: Chuoi doi xung.

- TEST CASE 2:
Input: hello
Output: Chuoi khong doi xung.

- TEST CASE 3:
Input: abcba
Output: Chuoi doi xung.

- TEST CASE 4:
Input: abcde
Output: Chuoi khong doi xung.

- TEST CASE 5:
Input: a
Output: Chuoi doi xung.
*/