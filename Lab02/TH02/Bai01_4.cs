/*
* BÀI 1.4: XÂY DỰNG LỚP PHÂN SỐ
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 19/09/2026
*
* Phát biểu đề bài:
* Thiết kế lớp Phân số có chức năng:
* - Constructor mặc nhiên, Constructor sao chép và một số constructor khác.
* - Override hàm ToString() để xuất phân số.
* - Overload các toán tử một ngôi: +, -
* - Overload các toán tử hai ngôi: +, -, *, /
* - Overload các toán tử so sánh: >, <, >=, <=, ==, !=
*
* Ý tưởng:
* - Sử dụng hai Field tử số và mẫu số để lưu phân số.
* - Xây dựng các Constructor để khởi tạo phân số.
* - Rút gọn phân số về dạng tối giản.
* - Override ToString() để xuất phân số.
* - Overload các toán tử để thực hiện tính toán và so sánh phân số.
*
* Mã giả:
* - Khai báo lớp PhanSo gồm tử số và mẫu số.
* - Xây dựng Constructor mặc nhiên, có tham số và sao chép.
* - Xây dựng phương thức rút gọn phân số.
* - Xây dựng ToString().
* - Xây dựng các toán tử +, -, *, /, +, -.
* - Xây dựng các toán tử >, <, >=, <=, ==, !=.
*/
using System;

namespace TH02
{
    class PhanSo
    {
        // Field
        private int tu;
        private int mau;

        // Constructor mac nhien
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }

        // Constructor co tham so
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
            RutGon();
        }

        // Constructor sao chep
        public PhanSo(PhanSo p)
        {
            tu = p.tu;
            mau = p.mau;
        }

        // Phuong thuc rut gon phan so
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

        // Override ToString()
        public override string ToString()
        {
            return tu + "/" + mau;
        }

        // Toan tu mot ngoi +
        public static PhanSo operator +(PhanSo p)
        {
            return new PhanSo(p.tu, p.mau);
        }

        // Toan tu mot ngoi -
        public static PhanSo operator -(PhanSo p)
        {
            return new PhanSo(-p.tu, p.mau);
        }

        // Toan tu hai ngoi +
        public static PhanSo operator +(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.mau + p2.tu * p1.mau,
                p1.mau * p2.mau
            );
        }

        // Toan tu hai ngoi -
        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.mau - p2.tu * p1.mau,
                p1.mau * p2.mau
            );
        }

        // Toan tu hai ngoi *
        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.tu,
                p1.mau * p2.mau
            );
        }

        // Toan tu hai ngoi /
        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.mau,
                p1.mau * p2.tu
            );
        }

        // Toan tu >
        public static bool operator >(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau > p2.tu * p1.mau;
        }

        // Toan tu <
        public static bool operator <(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau < p2.tu * p1.mau;
        }

        // Toan tu >=
        public static bool operator >=(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau >= p2.tu * p1.mau;
        }

        // Toan tu <=
        public static bool operator <=(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau <= p2.tu * p1.mau;
        }

        // Toan tu ==
        public static bool operator ==(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau == p2.tu * p1.mau;
        }

        // Toan tu !=
        public static bool operator !=(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau != p2.tu * p1.mau;
        }

        // Override Equals
        public override bool Equals(object obj)
        {
            PhanSo p = obj as PhanSo;

            if (p == null)
                return false;

            return this == p;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return tu.GetHashCode() ^ mau.GetHashCode();
        }
    }

    class Bai01_4
    {
        public static void ChayBai01_4()
        {
            // Khai bao bien
            int tu1;
            int mau1;
            int tu2;
            int mau2;

            PhanSo p1;
            PhanSo p2;
            PhanSo p3;

            // Nhap du lieu
            Console.WriteLine("Nhap phan so p1:");

            Console.Write("Nhap tu so: ");
            tu1 = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap mau so: ");
                mau1 = int.Parse(Console.ReadLine());

                if (mau1 == 0)
                    Console.WriteLine("Mau so phai khac 0!");
            }
            while (mau1 == 0);

            Console.WriteLine("\nNhap phan so p2:");

            Console.Write("Nhap tu so: ");
            tu2 = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap mau so: ");
                mau2 = int.Parse(Console.ReadLine());

                if (mau2 == 0)
                    Console.WriteLine("Mau so phai khac 0!");
            }
            while (mau2 == 0);

            // Xu ly
            p1 = new PhanSo(tu1, mau1);
            p2 = new PhanSo(tu2, mau2);

            // Xuat ket qua
            Console.WriteLine("\nPhan so p1: " + p1);
            Console.WriteLine("Phan so p2: " + p2);

            Console.WriteLine("\nToan tu mot ngoi:");
            Console.WriteLine("+p1 = " + (+p1));
            Console.WriteLine("-p1 = " + (-p1));

            Console.WriteLine("\nToan tu hai ngoi:");
            Console.WriteLine("p1 + p2 = " + (p1 + p2));
            Console.WriteLine("p1 - p2 = " + (p1 - p2));
            Console.WriteLine("p1 * p2 = " + (p1 * p2));
            Console.WriteLine("p1 / p2 = " + (p1 / p2));

            Console.WriteLine("\nSo sanh:");
            Console.WriteLine("p1 > p2: " + (p1 > p2));
            Console.WriteLine("p1 < p2: " + (p1 < p2));
            Console.WriteLine("p1 >= p2: " + (p1 >= p2));
            Console.WriteLine("p1 <= p2: " + (p1 <= p2));
            Console.WriteLine("p1 == p2: " + (p1 == p2));
            Console.WriteLine("p1 != p2: " + (p1 != p2));

            // Constructor sao chep
            p3 = new PhanSo(p1);

            Console.WriteLine("\nPhan so copy p3: " + p3);
        }
    }
}

/*
- TEST CASE 1:
Input:
1
2
1
3

Output:
Phan so p1: 1/2
Phan so p2: 1/3
+p1 = 1/2
-p1 = -1/2
p1 + p2 = 5/6
p1 - p2 = 1/6
p1 * p2 = 1/6
p1 / p2 = 3/2
p1 > p2: True
p1 < p2: False
p1 >= p2: True
p1 <= p2: False
p1 == p2: False
p1 != p2: True


- TEST CASE 2:
Input:
-2
3
1
3

Output:
Phan so p1: -2/3
Phan so p2: 1/3
+p1 = -2/3
-p1 = 2/3
p1 + p2 = -1/3
p1 - p2 = -1
p1 * p2 = -2/9
p1 / p2 = -2
p1 > p2: False
p1 < p2: True
p1 >= p2: False
p1 <= p2: True
p1 == p2: False
p1 != p2: True


- TEST CASE 3:
Input:
2
4
1
2

Output:
Phan so p1: 1/2
Phan so p2: 1/2
+p1 = 1/2
-p1 = -1/2
p1 + p2 = 1/1
p1 - p2 = 0/1
p1 * p2 = 1/4
p1 / p2 = 1/1
p1 > p2: False
p1 < p2: False
p1 >= p2: True
p1 <= p2: True
p1 == p2: True
p1 != p2: False
*/