/*
* BÀI 2.3: LỚP CHỨA MẢNG 1 CHIỀU
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 19/09/2026
*
* Phát biểu đề bài:
* Xây dựng lớp dãy số chứa n số nguyên.
* Viết các phương thức:
* - Các loại Constructor.
* - Indexer để truy cập phần tử thứ i trong dãy.
* - Nhập / Xuất dãy số.
* - Tìm các số chẵn.
*
* Ý tưởng:
* - Sử dụng mảng một chiều int[] để lưu các số nguyên.
* - Constructor mặc nhiên tạo dãy rỗng.
* - Constructor có tham số tạo dãy có n phần tử.
* - Constructor sao chép sao chép dữ liệu từ một dãy khác.
* - Sử dụng Indexer để truy cập phần tử thứ i.
* - Duyệt mảng để tìm các số chẵn.
*
* Mã giả:
* - Khai báo lớp DaySo gồm mảng int[].
* - Xây dựng các Constructor.
* - Xây dựng Indexer this[i].
* - Xây dựng Input() và Output().
* - Duyệt mảng, nếu phần tử chia hết cho 2 thì đó là số chẵn.
*/

using System;
using System.Collections;

namespace TH02
{
    class DaySo
    {
        // Field
        private int[] a;

        // Constructor mac nhien
        public DaySo()
        {
            a = new int[0];
        }

        // Constructor co tham so
        public DaySo(int n)
        {
            a = new int[n];
        }

        // Constructor sao chep
        public DaySo(DaySo d)
        {
            a = new int[d.a.Length];

            for (int i = 0; i < d.a.Length; i++)
            {
                a[i] = d.a[i];
            }
        }

        // Indexer
        public int this[int i]
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

        // So luong phan tu
        public int SoLuong
        {
            get
            {
                return a.Length;
            }
        }

        // Nhap day so
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Xuat day so
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }

        // Tim cac so chan
        public ArrayList TimSoChan()
        {
            ArrayList ketQua = new ArrayList();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    ketQua.Add(a[i]);
            }

            return ketQua;
        }
    }

    class Bai02_3
    {
        public static void ChayBai02_3()
        {
            // Khai bao bien
            int n;
            DaySo day;
            ArrayList soChan;

            // Nhap du lieu
            do
            {
                Console.Write("Nhap so luong phan tu n: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                    Console.WriteLine("n phai lon hon hoac bang 0!");
            }
            while (n < 0);

            day = new DaySo(n);

            Console.WriteLine("\nNhap day so:");
            day.Input();

            // Xu ly
            soChan = day.TimSoChan();

            // Xuat ket qua
            Console.Write("\nDay so vua nhap: ");
            day.Output();

            Console.Write("Cac so chan: ");

            if (soChan.Count == 0)
            {
                Console.WriteLine("Khong co so chan trong day.");
            }
            else
            {
                for (int i = 0; i < soChan.Count; i++)
                {
                    Console.Write(soChan[i] + " ");
                }

                Console.WriteLine();
            }

            // Kiem tra Indexer
            if (day.SoLuong > 0)
            {
                Console.WriteLine("\nPhan tu dau tien thong qua Indexer: " + day[0]);
            }
        }
    }
}

/*
- TEST CASE 1:
Input:
5
1
2
3
4
5

Output:
Day so vua nhap: 1 2 3 4 5
Cac so chan: 2 4
Phan tu dau tien thong qua Indexer: 1


- TEST CASE 2:
Input:
6
10
15
20
25
30
35

Output:
Day so vua nhap: 10 15 20 25 30 35
Cac so chan: 10 20 30
Phan tu dau tien thong qua Indexer: 10


- TEST CASE 3:
Input:
4
1
3
5
7

Output:
Day so vua nhap: 1 3 5 7
Cac so chan: Khong co so chan trong day.
Phan tu dau tien thong qua Indexer: 1
*/