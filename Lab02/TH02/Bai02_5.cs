/*
* BÀI 2.5: XÂY DỰNG LỚP ĐA THỨC
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 20/09/2026
*
* Phát biểu đề bài:
* Xây dựng lớp đa thức gồm n+1 đơn thức:
* P(x) = a0.x^0 + a1.x^1 + a2.x^2 + ... + an.x^n
*
* Viết các phương thức:
* - Các loại Constructor.
* - Indexer để truy cập đơn thức thứ i.
* - Nhập / Xuất.
* - Tính giá trị của đa thức với giá trị x được nhập từ bàn phím.
*
* Ý tưởng:
* - Sử dụng mảng DonThucBai25[] để lưu n+1 đơn thức.
* - Đơn thức thứ i có hệ số ai và số mũ i.
* - Xây dựng Constructor mặc nhiên, Constructor có tham số
*   và Constructor sao chép.
* - Sử dụng Indexer để truy cập đơn thức thứ i.
* - Nhập các hệ số của đa thức.
* - Tính giá trị đa thức bằng cách cộng giá trị của từng đơn thức.
*
* Mã giả:
* - Khai báo lớp DonThucBai25.
* - Khai báo lớp DaThuc gồm mảng DonThucBai25[].
* - Xây dựng Constructor mặc nhiên.
* - Xây dựng Constructor có tham số n.
* - Xây dựng Constructor sao chép.
* - Xây dựng Indexer this[i].
* - Nhập các hệ số của đa thức.
* - Xuất đa thức.
* - Nhập x và tính giá trị P(x).
*/

using System;

namespace TH02
{
    // Lớp đơn thức riêng cho Bài 2.5
    class DonThucBai25
    {
        // Field
        private double a;
        private int n;

        // Constructor mac nhien
        public DonThucBai25()
        {
            a = 0;
            n = 0;
        }

        // Constructor co tham so
        public DonThucBai25(double a, int n)
        {
            this.a = a;
            this.n = n;
        }

        // Constructor sao chep
        public DonThucBai25(DonThucBai25 d)
        {
            a = d.a;
            n = d.n;
        }

        // Property A
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        // Property N
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }

        // Tinh gia tri don thuc
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        // Xuat don thuc
        public override string ToString()
        {
            if (n == 0)
                return a.ToString();

            if (n == 1)
                return a + "x";

            return a + "x^" + n;
        }
    }


    class DaThuc
    {
        // Field
        private DonThucBai25[] a;

        // Constructor mac nhien
        public DaThuc()
        {
            a = new DonThucBai25[1];
            a[0] = new DonThucBai25(0, 0);
        }

        // Constructor co tham so
        public DaThuc(int n)
        {
            a = new DonThucBai25[n + 1];

            for (int i = 0; i <= n; i++)
            {
                a[i] = new DonThucBai25(0, i);
            }
        }

        // Constructor sao chep
        public DaThuc(DaThuc p)
        {
            a = new DonThucBai25[p.a.Length];

            for (int i = 0; i < p.a.Length; i++)
            {
                a[i] = new DonThucBai25(p.a[i]);
            }
        }

        // Indexer
        public DonThucBai25 this[int i]
        {
            get
            {
                return a[i];
            }
            set
            {
                a[i] = value;
            }
        }

        // So luong don thuc
        public int SoLuong
        {
            get
            {
                return a.Length;
            }
        }

        // Nhap da thuc
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                double heSo;

                Console.Write("Nhap he so a" + i + ": ");
                heSo = double.Parse(Console.ReadLine());

                a[i] = new DonThucBai25(heSo, i);
            }
        }

        // Xuat da thuc
        public void Output()
        {
            bool daCoDonThuc = false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].A == 0)
                    continue;

                if (daCoDonThuc && a[i].A > 0)
                    Console.Write(" + ");

                Console.Write(a[i]);

                daCoDonThuc = true;
            }

            if (!daCoDonThuc)
                Console.Write("0");

            Console.WriteLine();
        }

        // Tinh gia tri da thuc tai x
        public double TinhGiaTri(double x)
        {
            double ketQua = 0;

            for (int i = 0; i < a.Length; i++)
            {
                ketQua = ketQua + a[i].TinhGiaTri(x);
            }

            return ketQua;
        }
    }


    class Bai02_5
    {
        public static void ChayBai02_5()
        {
            // Khai bao bien
            int n;
            double x;
            DaThuc P;
            DaThuc Q;
            double ketQua;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap bac cua da thuc n: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                    Console.WriteLine("Bac da thuc phai lon hon hoac bang 0!");
            }
            while (n < 0);

            P = new DaThuc(n);

            Console.WriteLine("\nNhap cac he so cua da thuc:");
            P.Input();

            Console.Write("\nNhap gia tri x: ");
            x = double.Parse(Console.ReadLine());

            // Tao da thuc copy de kiem tra Constructor sao chep
            Q = new DaThuc(P);

            // Xu ly
            ketQua = P.TinhGiaTri(x);

            // Xuat ket qua
            Console.Write("\nDa thuc P(x): ");
            P.Output();

            Console.WriteLine("Gia tri P(" + x + ") = " + ketQua);

            // Kiem tra Indexer
            Console.WriteLine("\nDon thuc thu 0 thong qua Indexer: " + P[0]);

            // Kiem tra Constructor sao chep
            Console.Write("Da thuc copy Q(x): ");
            Q.Output();
        }
    }
}


/*
- TEST CASE 1:
Input:
3
1
2
3
4
2

Output:
Da thuc P(x): 1 + 2x + 3x^2 + 4x^3
Gia tri P(2) = 49
Don thuc thu 0 thong qua Indexer: 1
Da thuc copy Q(x): 1 + 2x + 3x^2 + 4x^3


- TEST CASE 2:
Input:
2
5
-2
3
2

Output:
Da thuc P(x): 5 -2x + 3x^2
Gia tri P(2) = 13
Don thuc thu 0 thong qua Indexer: 5
Da thuc copy Q(x): 5 -2x + 3x^2


- TEST CASE 3:
Input:
4
1
0
2
0
3
1

Output:
Da thuc P(x): 1 + 2x^2 + 3x^4
Gia tri P(1) = 6
Don thuc thu 0 thong qua Indexer: 1
Da thuc copy Q(x): 1 + 2x^2 + 3x^4
*/