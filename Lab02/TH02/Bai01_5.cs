/*
* BÀI 1.5: XÂY DỰNG LỚP ĐƠN THỨC
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 19/09/2026
*
* Phát biểu đề bài:
* Xây dựng lớp Đơn thức thực hiện chức năng:
* - Tính giá trị đơn thức P(x) = a.x^n với giá trị x cho trước.
* - Tính đạo hàm đơn thức P(x) = a.x^n.
*
* Ý tưởng:
* - Sử dụng Field a để lưu hệ số và n để lưu số mũ.
* - Xây dựng Constructor để khởi tạo đơn thức.
* - Dùng Math.Pow() để tính lũy thừa.
* - Tính đạo hàm theo quy tắc:
*   P'(x) = a.n.x^(n-1)
* - Nếu n = 0 thì đạo hàm bằng 0.
*
* Mã giả:
* - Khai báo lớp DonThuc gồm a và n.
* - Xây dựng Constructor mặc nhiên và Constructor có tham số.
* - Xây dựng Property A và N.
* - Xây dựng phương thức TinhGiaTri(x).
* - Xây dựng phương thức DaoHam().
* - Nhập a, n và x từ bàn phím.
* - Xuất giá trị đơn thức và đạo hàm.
*/
using System;

namespace TH02
{
    class DonThuc
    {
        // Field
        private double a;
        private int n;

        // Constructor mac nhien
        public DonThuc()
        {
            a = 0;
            n = 0;
        }

        // Constructor co tham so
        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = n;
        }

        // Property A
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        // Property N
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        // Tinh gia tri don thuc tai x
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        // Tinh dao ham
        public DonThuc DaoHam()
        {
            if (n == 0)
                return new DonThuc(0, 0);

            return new DonThuc(a * n, n - 1);
        }

        // Override ToString()
        public override string ToString()
        {
            if (n == 0)
                return a.ToString();

            if (n == 1)
                return a + "x";

            return a + "x^" + n;
        }
    }

    class Bai01_5
    {
        public static void ChayBai01_5()
        {
            // Khai bao bien
            double a;
            int n;
            double x;
            DonThuc P;
            DonThuc Q;

            // Nhap du lieu
            Console.Write("Nhap he so a: ");
            a = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap so mu n: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                    Console.WriteLine("So mu n phai la so nguyen khong am!");
            }
            while (n < 0);

            Console.Write("Nhap gia tri x: ");
            x = double.Parse(Console.ReadLine());

            // Xu ly
            P = new DonThuc(a, n);
            Q = P.DaoHam();

            // Xuat ket qua
            Console.WriteLine("\nDon thuc P(x): " + P);
            Console.WriteLine("Gia tri P(" + x + ") = " + P.TinhGiaTri(x));
            Console.WriteLine("Dao ham P'(x): " + Q);
        }
    }
}

/*
- TEST CASE 1:
Input:
2
3
2

Output:
Don thuc P(x): 2x^3
Gia tri P(2) = 16
Dao ham P'(x): 6x^2


- TEST CASE 2:
Input:
5
2
3

Output:
Don thuc P(x): 5x^2
Gia tri P(3) = 45
Dao ham P'(x): 10x


- TEST CASE 3:
Input:
7
0
4

Output:
Don thuc P(x): 7
Gia tri P(4) = 7
Dao ham P'(x): 0
*/