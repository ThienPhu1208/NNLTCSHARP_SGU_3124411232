using System;

namespace Bai01
{
    public class PhuongTrinhBacHai
    {
        // Thuoc tinh
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Constructor
        public PhuongTrinhBacHai()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        // Giai phuong trinh bac nhat
        public string GiaiBacNhat()
        {
            if (A == 0)
            {
                if (B == 0)
                {
                    return "Phuong trinh vo so nghiem";
                }
                else
                {
                    return "Phuong trinh vo nghiem";
                }
            }

            double x = -B / A;

            return "Phuong trinh co nghiem x = " +
                   x.ToString("0.00");
        }

        // Giai phuong trinh bac hai
        public string GiaiBacHai()
        {
            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        return "Phuong trinh vo so nghiem";
                    }
                    else
                    {
                        return "Phuong trinh vo nghiem";
                    }
                }

                double x = -C / B;

                return "Day la phuong trinh bac nhat, x = " +
                       x.ToString("0.00");
            }

            double delta = B * B - 4 * A * C;

            if (delta < 0)
            {
                return "Phuong trinh vo nghiem";
            }

            if (delta == 0)
            {
                double x = -B / (2 * A);

                return "Phuong trinh co nghiem kep x = " +
                       x.ToString("0.00");
            }

            double x1 =
                (-B + Math.Sqrt(delta)) / (2 * A);

            double x2 =
                (-B - Math.Sqrt(delta)) / (2 * A);

            return "Phuong trinh co 2 nghiem x1 = " +
                   x1.ToString("0.00") +
                   "; x2 = " +
                   x2.ToString("0.00");
        }
    }
}