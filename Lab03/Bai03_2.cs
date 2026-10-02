/*
* THỐNG KÊ MẢNG CHUỖI
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 29/09/2026
*
* Phát biểu đề bài:
* Cho mảng:
* string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
* "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
* "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };
*
* a. Tìm các phần tử có chiều dài ngắn nhất và dài nhất.
* b. Phân nhóm theo từ đầu tiên của tên món và liệt kê các phần tử
*    trong từng nhóm.
* c. Đếm số phần tử có từ đầu tiên là "Bánh".
*
* Ý tưởng:
* - Dùng Min và Max để tìm chiều dài ngắn nhất và dài nhất.
* - Dùng Where để lấy các món có chiều dài tương ứng.
* - Dùng GroupBy để phân nhóm theo từ đầu tiên.
* - Dùng Count để đếm số món bắt đầu bằng "Bánh".
*
* Mã giả:
* - Khai báo mảng món ăn.
* - Tìm chiều dài nhỏ nhất và lớn nhất.
* - Lọc các món có chiều dài nhỏ nhất và lớn nhất.
* - Tách từ đầu tiên của mỗi món và phân nhóm.
* - Đếm các món có từ đầu tiên là "Bánh".
* - Xuất kết quả.
*/

using System;
using System.Linq;

namespace Lab03
{
    class Bai03_2
    {
        public static void ChayBai03_2()
        {
            // Khai bao bien
            string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
                               "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây",
                               "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói",
                               "Bún chả", "Hủ tiếu Nam vang" };

            // a. Tim phan tu co chieu dai ngan nhat va dai nhat
            int doDaiNhoNhat = monAn.Min(x => x.Length);
            int doDaiLonNhat = monAn.Max(x => x.Length);

            var monNganNhat = monAn.Where(x => x.Length == doDaiNhoNhat);
            var monDaiNhat = monAn.Where(x => x.Length == doDaiLonNhat);

            Console.WriteLine("a. Mon an co chieu dai ngan nhat:");
            foreach (string x in monNganNhat)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nMon an co chieu dai dai nhat:");
            foreach (string x in monDaiNhat)
            {
                Console.WriteLine(x);
            }

            // b. Phan nhom theo tu dau tien
            var nhom = monAn.GroupBy(x => x.Split(' ')[0]);

            Console.WriteLine("\nb. Phan nhom theo tu dau tien:");

            foreach (var group in nhom)
            {
                Console.WriteLine("Nhom " + group.Key + ":");

                foreach (string x in group)
                {
                    Console.WriteLine("- " + x);
                }
            }

            // c. Dem so phan tu co tu dau tien la "Bánh"
            int soMonBanh = monAn.Count(x => x.StartsWith("Bánh"));

            Console.WriteLine("\nc. So phan tu co tu dau tien la \"Bánh\": " + soMonBanh);
        }
    }
}