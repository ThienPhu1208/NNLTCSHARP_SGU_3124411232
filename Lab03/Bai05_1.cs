/*
    * TRUY VẤN LIST<MONHOC> - BÀI 5.1
    * Tác giả : Nguyễn Thiên Phú
    * MSSV: 3124411232
    * Ngày viết: 29/09/2026
    *
    * Phát biểu đề bài:
    * Truy vấn List<MonHoc> bằng LINQ:
    * a. Liệt kê tên các môn học bắt đầu bằng “Lập trình”.
    * b. Liệt kê các môn thuộc hệ “CD”, sắp xếp số tiết giảm dần
    *    rồi mã môn tăng dần.
    * c. Liệt kê các môn có tên chứa từ “web”, chỉ lấy Tên môn và Hệ.
    * d. Liệt kê các môn thuộc hệ “KTV”, sắp xếp tăng dần theo Mã môn.
    *
    * Ý tưởng:
    * - Lấy danh sách môn học từ DuLieu.DS_Mon().
    * - Sử dụng Where để lọc dữ liệu.
    * - Sử dụng OrderByDescending, OrderBy để sắp xếp.
    * - Sử dụng Select để lấy các thuộc tính cần xuất.
    */
    
using System;
using System.Linq;

namespace Lab03
{
    public class Bai05_1
    {
        public static void ChayBai05_1()
        {
            // Khai bao bien
            var ds = DuLieu.DS_Mon();

            // a. Liệt kê tên các môn học bắt đầu bằng "Lập trình"
            Console.WriteLine("a. Cac mon hoc bat dau bang 'Lap trinh':");

            var cauA = ds
                .Where(x => x.TenMon.StartsWith("Lập trình"));

            foreach (var mon in cauA)
            {
                Console.WriteLine(mon.TenMon);
            }


            // b. Liệt kê các môn thuộc hệ "CD"
            // Sắp xếp số tiết giảm dần rồi mã môn tăng dần
            Console.WriteLine("\nb. Cac mon thuoc he CD:");

            var cauB = ds
                .Where(x => x.He == "CD")
                .OrderByDescending(x => x.SoTiet)
                .ThenBy(x => x.MaMon);

            foreach (var mon in cauB)
            {
                Console.WriteLine(
                    mon.MaMon + " - " +
                    mon.TenMon + " - " +
                    mon.He + " - " +
                    mon.SoTiet
                );
            }


            // c. Liệt kê các môn có tên chứa từ "web"
            // Chỉ lấy Tên môn và Hệ
            Console.WriteLine("\nc. Cac mon co ten chua tu 'web':");

            var cauC = ds
                .Where(x => x.TenMon.ToLower().Contains("web"))
                .Select(x => new
                {
                    x.TenMon,
                    x.He
                });

            foreach (var mon in cauC)
            {
                Console.WriteLine(
                    mon.TenMon + " - " +
                    mon.He
                );
            }


            // d. Liệt kê các môn thuộc hệ "KTV"
            // Sắp xếp tăng dần theo Mã môn
            Console.WriteLine("\nd. Cac mon thuoc he KTV:");

            var cauD = ds
                .Where(x => x.He == "KTV")
                .OrderBy(x => x.MaMon);

            foreach (var mon in cauD)
            {
                Console.WriteLine(
                    mon.MaMon + " - " +
                    mon.TenMon + " - " +
                    mon.He + " - " +
                    mon.SoTiet
                );
            }
        }
    }
}