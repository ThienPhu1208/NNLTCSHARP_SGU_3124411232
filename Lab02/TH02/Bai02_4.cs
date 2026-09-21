/*
* BÀI 2.4: LỚP CHỨA MẢNG 2 CHIỀU
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 20/09/2026
*
* Phát biểu đề bài:
* Xây dựng lớp mảng 2 chiều có kích thước n x m.
* Viết các phương thức:
* - Các loại Constructor.
* - Indexer để truy cập phần tử tại (i, j).
* - Nhập / Xuất mảng.
* - Tìm các số nguyên tố trong mảng.
*
* Ý tưởng:
* - Sử dụng mảng hai chiều int[,] để lưu các số nguyên.
* - Xây dựng Constructor mặc nhiên, có tham số và sao chép.
* - Sử dụng Indexer để truy cập phần tử tại dòng i, cột j.
* - Duyệt mảng để tìm các số nguyên tố.
*
* Mã giả:
* - Khai báo lớp MangHaiChieu gồm mảng int[,] a.
* - Xây dựng các Constructor.
* - Xây dựng Indexer this[i, j].
* - Xây dựng Input() và Output().
* - Kiểm tra từng phần tử có phải số nguyên tố hay không.
* - Lưu các số nguyên tố tìm được vào ArrayList.
*/

using System;
using System.Collections;

namespace TH02
{
    class MangHaiChieu
    {
        // Field
        private int[,] a;

        // Constructor mac nhien
        public MangHaiChieu()
        {
            a = new int[0, 0];
        }

        // Constructor co tham so
        public MangHaiChieu(int n, int m)
        {
            a = new int[n, m];
        }

        // Constructor sao chep
        public MangHaiChieu(MangHaiChieu b)
        {
            int n = b.SoDong;
            int m = b.SoCot;

            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = b.a[i, j];
                }
            }
        }

        // Indexer
        public int this[int i, int j]
        {
            get
            {
                return a[i, j];
            }
            set
            {
                a[i, j] = value;
            }
        }

        // So dong
        public int SoDong
        {
            get
            {
                return a.GetLength(0);
            }
        }

        // So cot
        public int SoCot
        {
            get
            {
                return a.GetLength(1);
            }
        }

        // Nhap mang
        public void Input()
        {
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write("Nhap a[" + i + "," + j + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Xuat mang
        public void Output()
        {
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        // Kiem tra so nguyen to
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // Tim cac so nguyen to
        public ArrayList TimSoNguyenTo()
        {
            ArrayList ketQua = new ArrayList();

            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    if (LaSoNguyenTo(a[i, j]))
                        ketQua.Add(a[i, j]);
                }
            }

            return ketQua;
        }
    }

    class Bai02_4
    {
        public static void ChayBai02_4()
        {
            // Khai bao bien
            int n;
            int m;
            MangHaiChieu mang;
            ArrayList soNguyenTo;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so dong n: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("n phai lon hon 0!");
            }
            while (n <= 0);

            do
            {
                Console.Write("Nhap so cot m: ");
                m = int.Parse(Console.ReadLine());

                if (m <= 0)
                    Console.WriteLine("m phai lon hon 0!");
            }
            while (m <= 0);

            mang = new MangHaiChieu(n, m);

            Console.WriteLine("\nNhap mang:");
            mang.Input();

            // Xu ly
            soNguyenTo = mang.TimSoNguyenTo();

            // Xuat ket qua
            Console.WriteLine("\nMang vua nhap:");
            mang.Output();

            Console.WriteLine("\nCac so nguyen to trong mang:");

            if (soNguyenTo.Count == 0)
            {
                Console.WriteLine("Khong co so nguyen to trong mang.");
            }
            else
            {
                for (int i = 0; i < soNguyenTo.Count; i++)
                {
                    Console.Write(soNguyenTo[i] + " ");
                }

                Console.WriteLine();
            }

            // Kiem tra Indexer
            Console.WriteLine("\nPhan tu tai [0,0] thong qua Indexer: " + mang[0, 0]);
        }
    }
}

/*
- TEST CASE 1:
Input:
2
3
1
2
3
4
5
6

Output:
Mang vua nhap:
1   2   3
4   5   6

Cac so nguyen to trong mang:
2 3 5

Phan tu tai [0,0] thong qua Indexer: 1


- TEST CASE 2:
Input:
3
3
10
11
12
13
14
15
16
17
18

Output:
Mang vua nhap:
10  11  12
13  14  15
16  17  18

Cac so nguyen to trong mang:
11 13 17

Phan tu tai [0,0] thong qua Indexer: 10


- TEST CASE 3:
Input:
2
2
4
6
8
10

Output:
Mang vua nhap:
4   6
8   10

Cac so nguyen to trong mang:
Khong co so nguyen to trong mang.

Phan tu tai [0,0] thong qua Indexer: 4
*/