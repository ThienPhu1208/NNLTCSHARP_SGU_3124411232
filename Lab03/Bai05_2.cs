    /*
    * THỐNG KÊ TRÊN LIST<MONHOC> - BÀI 5.2
    * Tác giả : Nguyễn Thiên Phú
    * MSSV: 3124411232
    * Ngày viết: 29/09/2026
    *
    * Phát biểu đề bài:
    * Thống kê dữ liệu trên List<MonHoc> bằng LINQ.
    *
    * Ý tưởng:
    * - Lấy danh sách môn học từ DuLieu.DS_Mon().
    * - Sử dụng Count, Sum, Max, Min để thống kê.
    * - Sử dụng GroupBy để phân nhóm.
    * - Sử dụng OrderBy, OrderByDescending để sắp xếp.
    */

using System;
using System.Linq;

namespace Lab03
{
    public class Bai05_2
    {
        public static void ChayBai05_2()
        {
            // Khai bao bien
            var ds = DuLieu.DS_Mon();


            // a. Cho biết tổng số môn hiện có
            Console.WriteLine("a. Tong so mon hien co:");

            int cauA = ds.Count();

            Console.WriteLine(cauA);


            // b. Đếm số môn có tên bắt đầu bằng "Lập trình"
            Console.WriteLine("\nb. So mon bat dau bang 'Lap trinh':");

            int cauB = ds.Count(x => x.TenMon.StartsWith("Lập trình"));

            Console.WriteLine(cauB);


            // c. Tính tổng số tiết của hệ KTV
            Console.WriteLine("\nc. Tong so tiet cua he KTV:");

            int cauC = ds
                .Where(x => x.He == "KTV")
                .Sum(x => x.SoTiet);

            Console.WriteLine(cauC);


            // d. Cho biết tổng số môn của mỗi hệ
            Console.WriteLine("\nd. Tong so mon cua moi he:");

            var cauD = ds
                .GroupBy(x => x.He)
                .Select(g => new
                {
                    He = g.Key,
                    TongSoMon = g.Count()
                });

            foreach (var nhom in cauD)
            {
                Console.WriteLine(
                    nhom.He + " - " +
                    nhom.TongSoMon
                );
            }


            // e. Nhóm theo Số tiết
            // In Số tiết và Tổng số môn
            // Sắp xếp giảm dần theo Số tiết
            Console.WriteLine("\ne. Nhom theo so tiet:");

            var cauE = ds
                .GroupBy(x => x.SoTiet)
                .OrderByDescending(g => g.Key)
                .Select(g => new
                {
                    SoTiet = g.Key,
                    TongSoMon = g.Count()
                });

            foreach (var nhom in cauE)
            {
                Console.WriteLine(
                    nhom.SoTiet + " tiet - " +
                    nhom.TongSoMon + " mon"
                );
            }


            // f. Cho biết thông tin môn học có số tiết cao nhất
            Console.WriteLine("\nf. Mon hoc co so tiet cao nhat:");

            byte maxSoTiet = ds.Max(x => x.SoTiet);

            var cauF = ds
                .Where(x => x.SoTiet == maxSoTiet);

            foreach (var mon in cauF)
            {
                Console.WriteLine(
                    mon.MaMon + " - " +
                    mon.TenMon + " - " +
                    mon.He + " - " +
                    mon.SoTiet
                );
            }


            // g. Thống kê theo Hệ
            // Tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất
            Console.WriteLine("\ng. Thong ke theo He:");

            var cauG = ds
                .GroupBy(x => x.He)
                .Select(g => new
                {
                    He = g.Key,
                    TongSoMon = g.Count(),
                    TongSoTiet = g.Sum(x => x.SoTiet),
                    SoTietCaoNhat = g.Max(x => x.SoTiet),
                    SoTietThapNhat = g.Min(x => x.SoTiet)
                });

            foreach (var nhom in cauG)
            {
                Console.WriteLine(
                    nhom.He + " - " +
                    "So mon: " + nhom.TongSoMon + " - " +
                    "Tong tiet: " + nhom.TongSoTiet + " - " +
                    "Cao nhat: " + nhom.SoTietCaoNhat + " - " +
                    "Thap nhat: " + nhom.SoTietThapNhat
                );
            }


            // h. Liệt kê các môn học được phân nhóm theo Hệ
            Console.WriteLine("\nh. Cac mon hoc phan nhom theo He:");

            var cauH = ds
                .GroupBy(x => x.He);

            foreach (var nhom in cauH)
            {
                Console.WriteLine("\nHe: " + nhom.Key);

                foreach (var mon in nhom)
                {
                    Console.WriteLine(
                        mon.MaMon + " - " +
                        mon.TenMon + " - " +
                        mon.SoTiet
                    );
                }
            }


            // i. Liệt kê các môn học được phân nhóm theo Số tiết
            // Tăng dần theo Số tiết
            Console.WriteLine("\ni. Cac mon hoc phan nhom theo So tiet:");

            var cauI = ds
                .GroupBy(x => x.SoTiet)
                .OrderBy(g => g.Key);

            foreach (var nhom in cauI)
            {
                Console.WriteLine("\nSo tiet: " + nhom.Key);

                foreach (var mon in nhom)
                {
                    Console.WriteLine(
                        mon.MaMon + " - " +
                        mon.TenMon + " - " +
                        mon.He
                    );
                }
            }


            // j. Với hệ KTV, phân nhóm theo HP2, HP3, HP4, HP5
            // Sắp xếp theo Mã môn
            Console.WriteLine("\nj. He KTV phan nhom theo HP2, HP3, HP4, HP5:");

            var cauJ = ds
                .Where(x => x.He == "KTV")
                .GroupBy(x => x.MaMon.Substring(0, 3));

            foreach (var nhom in cauJ)
            {
                Console.WriteLine("\n" + nhom.Key);

                foreach (var mon in nhom.OrderBy(x => x.MaMon))
                {
                    Console.WriteLine(
                        mon.MaMon + " - " +
                        mon.TenMon + " - " +
                        mon.SoTiet
                    );
                }
            }


            // k. Phân nhóm theo Hệ
            // Chỉ lấy các môn có Số tiết > 40
            // Trong mỗi nhóm sắp xếp theo Mã môn
            Console.WriteLine("\nk. Phan nhom theo He, So tiet > 40:");

            var cauK = ds
                .Where(x => x.SoTiet > 40)
                .GroupBy(x => x.He);

            foreach (var nhom in cauK)
            {
                Console.WriteLine("\nHe: " + nhom.Key);

                foreach (var mon in nhom.OrderBy(x => x.MaMon))
                {
                    Console.WriteLine(
                        mon.MaMon + " - " +
                        mon.TenMon + " - " +
                        mon.SoTiet
                    );
                }
            }
        }
    }
}