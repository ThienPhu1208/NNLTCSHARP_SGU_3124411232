/*
* BÀI 2.6: DÃY PHÂN SỐ
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 20/09/2026
*
* Phát biểu đề bài:
* Xây dựng lớp chứa n phân số.
* Hãy tính tổng của n phân số đó.
*
* Ý tưởng:
* - Xây dựng lớp PhanSoBai26 để lưu một phân số.
* - Xây dựng lớp DayPhanSo để lưu n phân số.
* - Sử dụng mảng PhanSoBai26[] để lưu các phân số.
* - Sử dụng Indexer để truy cập phân số thứ i.
* - Nhập n phân số từ bàn phím.
* - Tính tổng các phân số.
* - Rút gọn phân số sau khi tính tổng.
*
* Mã giả:
* - Khai báo lớp PhanSoBai26.
* - Khai báo lớp DayPhanSo.
* - Xây dựng Constructor mặc nhiên.
* - Xây dựng Constructor có tham số.
* - Xây dựng Indexer this[i].
* - Nhập dãy phân số.
* - Xuất dãy phân số.
* - Tính tổng n phân số.
*/

using System;

namespace TH02
{
    // Lớp phân số riêng cho Bài 2.6
    class PhanSoBai26
    {
        // Field
        private int tu;
        private int mau;

        // Constructor mac nhien
        public PhanSoBai26()
        {
            tu = 0;
            mau = 1;
        }

        // Constructor co tham so
        public PhanSoBai26(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
            RutGon();
        }

        // Constructor sao chep
        public PhanSoBai26(PhanSoBai26 p)
        {
            tu = p.tu;
            mau = p.mau;
        }

        // Rut gon phan so
        public void RutGon()
        {
            int a = Math.Abs(tu);
            int b = Math.Abs(mau);

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            if (a != 0)
            {
                tu = tu / a;
                mau = mau / a;
            }

            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }

        // Nhap phan so
        public void Input()
        {
            Console.Write("Nhap tu so: ");
            tu = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap mau so: ");
                mau = int.Parse(Console.ReadLine());

                if (mau == 0)
                    Console.WriteLine("Mau so phai khac 0!");
            }
            while (mau == 0);

            RutGon();
        }

        // Xuat phan so
        public void Output()
        {
            Console.Write(tu + "/" + mau);
        }

        // Cong hai phan so
        public static PhanSoBai26 operator +(PhanSoBai26 p1, PhanSoBai26 p2)
        {
            return new PhanSoBai26(
                p1.tu * p2.mau + p2.tu * p1.mau,
                p1.mau * p2.mau
            );
        }

        public override string ToString()
        {
            return tu + "/" + mau;
        }
    }


    class DayPhanSo
    {
        // Field
        private PhanSoBai26[] a;

        // Constructor mac nhien
        public DayPhanSo()
        {
            a = new PhanSoBai26[0];
        }

        // Constructor co tham so
        public DayPhanSo(int n)
        {
            a = new PhanSoBai26[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new PhanSoBai26();
            }
        }

        // Constructor sao chep
        public DayPhanSo(DayPhanSo d)
        {
            a = new PhanSoBai26[d.a.Length];

            for (int i = 0; i < d.a.Length; i++)
            {
                a[i] = new PhanSoBai26(d.a[i]);
            }
        }

        // Indexer
        public PhanSoBai26 this[int i]
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

        // So luong phan so
        public int SoLuong
        {
            get
            {
                return a.Length;
            }
        }

        // Nhap day phan so
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("\nNhap phan so thu " + (i + 1) + ":");
                a[i].Input();
            }
        }

        // Xuat day phan so
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);

                if (i < a.Length - 1)
                    Console.Write(" ; ");
            }

            Console.WriteLine();
        }

        // Tinh tong cac phan so
        public PhanSoBai26 TinhTong()
        {
            PhanSoBai26 tong = new PhanSoBai26(0, 1);

            for (int i = 0; i < a.Length; i++)
            {
                tong = tong + a[i];
            }

            return tong;
        }
    }


    class Bai02_6
    {
        public static void ChayBai02_6()
        {
            // Khai bao bien
            int n;
            DayPhanSo day;
            PhanSoBai26 tong;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so luong phan so n: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("n phai lon hon 0!");
            }
            while (n <= 0);

            day = new DayPhanSo(n);

            Console.WriteLine("\nNhap day phan so:");
            day.Input();

            // Xu ly
            tong = day.TinhTong();

            // Xuat ket qua
            Console.Write("\nDay phan so: ");
            day.Output();

            Console.WriteLine("Tong cac phan so: " + tong);

            // Kiem tra Indexer
            Console.WriteLine("Phan so thu 0 thong qua Indexer: " + day[0]);
        }
    }
}


/*
- TEST CASE 1:
Input:
3
1
2
1
3
1
6

Output:
Day phan so: 1/2 ; 1/3 ; 1/6
Tong cac phan so: 1
Phan so thu 0 thong qua Indexer: 1/2


- TEST CASE 2:
Input:
3
1
2
1
4
3
4

Output:
Day phan so: 1/2 ; 1/4 ; 3/4
Tong cac phan so: 3/2
Phan so thu 0 thong qua Indexer: 1/2


- TEST CASE 3:
Input:
4
1
2
1
3
1
4
1
5

Output:
Day phan so: 1/2 ; 1/3 ; 1/4 ; 1/5
Tong cac phan so: 77/60
Phan so thu 0 thong qua Indexer: 1/2
*/