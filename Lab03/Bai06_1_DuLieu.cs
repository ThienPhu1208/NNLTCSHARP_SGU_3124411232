using System.Collections.Generic;

namespace Lab03
{
    public class DuLieuHe
    {
        public static List<He> DS_He()
        {
            List<He> ds = new List<He>();

            ds.Add(new He
            {
                MaHe = "KTV",
                TenHe = "Kỹ thuật viên"
            });

            ds.Add(new He
            {
                MaHe = "CD",
                TenHe = "Chuyên đề"
            });

            ds.Add(new He
            {
                MaHe = "QT",
                TenHe = "Chứng chỉ quốc tế"
            });

            return ds;
        }
    }
}