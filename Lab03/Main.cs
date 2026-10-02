using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai02_1.ChayBai02_1();
            Bai02_2.ChayBai02_2();
            Bai03_1.ChayBai03_1();
            Bai03_2.ChayBai03_2();

            var ds = DuLieu.DS_Mon();

            foreach (var mon in ds)
            {
                Console.WriteLine(
                    mon.MaMon + " - " +
                    mon.TenMon + " - " +
                    mon.He + " - " +
                    mon.SoTiet
                );
            }

            Bai05_1.ChayBai05_1();
            Bai05_2.ChayBai05_2();

            var dsHe = DuLieuHe.DS_He();

            foreach (var he in dsHe)
            {
                Console.WriteLine(
                    he.MaHe + " - " +
                    he.TenHe
                );
            }

            Bai06_2.ChayBai06_2();
        }
    }
}
