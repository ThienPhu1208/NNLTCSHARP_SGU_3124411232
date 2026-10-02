    /*
    * JOIN VÀ CÁC TOÁN TỬ TẬP HỢP - BÀI 6.2
    * Tác giả : Nguyễn Thiên Phú
    * MSSV: 3124411232
    * Ngày viết: 29/09/2026
    *
    * Phát biểu đề bài:
    * Thực hiện Join và các toán tử tập hợp trên List<He> và List<MonHoc>.
    *
    * Ý tưởng:
    * - Lấy danh sách hệ từ DuLieuHe.DS_He().
    * - Lấy danh sách môn học từ DuLieu.DS_Mon().
    * - Dùng Join, GroupJoin, DefaultIfEmpty và các toán tử tập hợp.
    */
    
using System;
using System.Linq;

namespace Lab03
{
    public class Bai06_2
    {
        public static void ChayBai06_2()
        {
            // Khai bao bien
            var dsHe = DuLieuHe.DS_He();
            var dsMon = DuLieu.DS_Mon();


            // a. Dùng join để liệt kê:
            // Tên hệ, Mã môn, Tên môn
            Console.WriteLine("a. Ten he - Ma mon - Ten mon:");

            var cauA = dsHe.Join(
                dsMon,
                h => h.MaHe,
                m => m.He,
                (h, m) => new
                {
                    h.TenHe,
                    m.MaMon,
                    m.TenMon
                });

            foreach (var x in cauA)
            {
                Console.WriteLine(
                    x.TenHe + " - " +
                    x.MaMon + " - " +
                    x.TenMon
                );
            }


            // b. Liệt kê cả những hệ chưa có môn học
            // Left outer join với GroupJoin + DefaultIfEmpty
            Console.WriteLine("\nb. Tat ca cac he, ke ca he chua co mon:");

            var cauB = dsHe
                .GroupJoin(
                    dsMon,
                    h => h.MaHe,
                    m => m.He,
                    (h, mon) => new
                    {
                        He = h,
                        Mon = mon
                    })
                .SelectMany(
                    x => x.Mon.DefaultIfEmpty(),
                    (x, m) => new
                    {
                        x.He,
                        Mon = m
                    });

            foreach (var x in cauB)
            {
                if (x.Mon == null)
                {
                    Console.WriteLine(
                        x.He.TenHe + " - " +
                        "Chua co mon hoc"
                    );
                }
                else
                {
                    Console.WriteLine(
                        x.He.TenHe + " - " +
                        x.Mon.MaMon + " - " +
                        x.Mon.TenMon
                    );
                }
            }


            // c. Liệt kê cả hệ chưa có môn học
            // và môn học chưa khai báo hệ
            Console.WriteLine("\nc. He chua co mon va mon chua khai bao he:");

            // Các hệ chưa có môn
            var heChuaCoMon = dsHe
                .GroupJoin(
                    dsMon,
                    h => h.MaHe,
                    m => m.He,
                    (h, mon) => new
                    {
                        He = h,
                        Mon = mon
                    })
                .Where(x => !x.Mon.Any())
                .Select(x => new
                {
                    Loai = "He chua co mon",
                    NoiDung = x.He.MaHe + " - " + x.He.TenHe
                });

            // Các môn chưa khai báo hệ
            var monChuaCoHe = dsMon
                .Where(m => !dsHe.Any(h => h.MaHe == m.He))
                .Select(m => new
                {
                    Loai = "Mon chua khai bao he",
                    NoiDung = m.MaMon + " - " + m.TenMon
                });

            var cauC = heChuaCoMon.Concat(monChuaCoHe);

            foreach (var x in cauC)
            {
                Console.WriteLine(
                    x.Loai + ": " +
                    x.NoiDung
                );
            }


            // d. Chỉ liệt kê những hệ chưa có môn học
            // và những môn học chưa khai báo hệ
            // Đây chính là các phần không có đối tượng ghép tương ứng
            Console.WriteLine("\nd. He chua co mon va mon chua khai bao he:");

            var cauD = heChuaCoMon.Concat(monChuaCoHe);

            foreach (var x in cauD)
            {
                Console.WriteLine(
                    x.Loai + ": " +
                    x.NoiDung
                );
            }


            // e. Lấy 5 môn học đầu tiên có số tiết giảm dần
            // Hiển thị Tên hệ, Mã môn, Tên môn, Số tiết
            Console.WriteLine("\ne. 5 mon hoc co so tiet cao nhat:");

            var cauE = dsMon
                .OrderByDescending(x => x.SoTiet)
                .Take(5)
                .Select(m => new
                {
                    TenHe = dsHe
                        .Where(h => h.MaHe == m.He)
                        .Select(h => h.TenHe)
                        .FirstOrDefault(),

                    m.MaMon,
                    m.TenMon,
                    m.SoTiet
                });

            foreach (var x in cauE)
            {
                Console.WriteLine(
                    x.TenHe + " - " +
                    x.MaMon + " - " +
                    x.TenMon + " - " +
                    x.SoTiet
                );
            }


            // f. Cho biết tổng số môn học của mỗi hệ
            // Mã hệ, Tên hệ, Tổng số môn
            Console.WriteLine("\nf. Tong so mon hoc cua moi he:");

            var cauF = dsHe
                .GroupJoin(
                    dsMon,
                    h => h.MaHe,
                    m => m.He,
                    (h, mon) => new
                    {
                        h.MaHe,
                        h.TenHe,
                        TongSoMon = mon.Count()
                    });

            foreach (var x in cauF)
            {
                Console.WriteLine(
                    x.MaHe + " - " +
                    x.TenHe + " - " +
                    x.TongSoMon
                );
            }


            // g. Cho biết có bao nhiêu loại Số tiết khác nhau
            Console.WriteLine("\ng. So loai So tiet khac nhau:");

            int cauG = dsMon
                .Select(x => x.SoTiet)
                .Distinct()
                .Count();

            Console.WriteLine(cauG);


            // h. Tìm môn học đầu tiên có tên bắt đầu bằng "Lập trình"
            Console.WriteLine("\nh. Mon hoc dau tien bat dau bang 'Lap trinh':");

            var cauH = dsMon
                .FirstOrDefault(x => x.TenMon.StartsWith("Lập trình"));

            if (cauH != null)
            {
                Console.WriteLine(
                    cauH.MaMon + " - " +
                    cauH.TenMon + " - " +
                    cauH.He + " - " +
                    cauH.SoTiet
                );
            }
            else
            {
                Console.WriteLine("Khong tim thay.");
            }


            // i. Liệt kê các môn theo từng hệ
            // Đánh số thứ tự trong mỗi nhóm
            Console.WriteLine("\ni. Cac mon theo tung he:");

            var cauI = dsHe
                .GroupJoin(
                    dsMon,
                    h => h.MaHe,
                    m => m.He,
                    (h, mon) => new
                    {
                        h.MaHe,
                        h.TenHe,
                        Mon = mon
                            .OrderBy(x => x.MaMon)
                            .Select((x, index) => new
                            {
                                SoThuTu = index + 1,
                                x.MaMon,
                                x.TenMon,
                                x.SoTiet
                            })
                    });

            foreach (var nhom in cauI)
            {
                Console.WriteLine("\n" + nhom.MaHe + " - " + nhom.TenHe);

                foreach (var mon in nhom.Mon)
                {
                    Console.WriteLine(
                        mon.SoThuTu + ". " +
                        mon.MaMon + " - " +
                        mon.TenMon + " - " +
                        mon.SoTiet
                    );
                }
            }
        }
    }
}