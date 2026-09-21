/*
* BÀI 17: MẢNG 2 CHIỀU
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 18/09/2026
*
* Phát biểu đề bài:
* - Sinh ngẫu nhiên mảng A[nxm] trong đoạn [10, 100] với n, m nhập từ bàn phím.
* - In mảng ra màn hình.
* - Trả về hai mảng: mảng các số chẵn và mảng các số lẻ.
*
* Ý tưởng:
* - Nhập n, m.
* - Dùng Random để sinh các phần tử từ 10 đến 100.
* - Duyệt mảng để in các phần tử.
* - Nếu phần tử chia hết cho 2 thì thêm vào mảng số chẵn.
* - Nếu không thì thêm vào mảng số lẻ.
*
* Mã giả:
* - Nhập n, m.
* - Sinh ngẫu nhiên mảng A[n,m].
* - In mảng.
* - Duyệt từng phần tử:
*   + Nếu chia hết cho 2 thì thêm vào mảng chẵn.
*   + Ngược lại thêm vào mảng lẻ.
* - Xuất mảng chẵn và mảng lẻ.
*/

using System;
using System.Collections;

namespace TH01
{
    class Bai17
    {
        // Sinh ngau nhien mang
        public static void SinhMang(int[,] a)
        {
            Random rd = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rd.Next(10, 101);
                }
            }
        }

        // In mang
        public static void InMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        // Tra ve mang so chan va mang so le
        public static void TimChanLe(int[,] a, out ArrayList soChan, out ArrayList soLe)
        {
            soChan = new ArrayList();
            soLe = new ArrayList();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 == 0)
                        soChan.Add(a[i, j]);
                    else
                        soLe.Add(a[i, j]);
                }
            }
        }

        public static void ChayBai17()
        {
            // Khai bao bien
            int n, m;
            int[,] a;
            ArrayList soChan, soLe;

            // Nhap du lieu
            Console.Write("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot m: ");
            m = int.Parse(Console.ReadLine());

            a = new int[n, m];

            // Sinh mang
            SinhMang(a);

            // Xuat mang
            Console.WriteLine("\nMang A:");
            InMang(a);

            // Tim so chan va so le
            TimChanLe(a, out soChan, out soLe);

            // Xuat so chan
            if (soChan.Count == 0)
            {
                Console.WriteLine("\nKhong co so chan trong mang.");
            }
            else
            {
                Console.Write("\nMang cac so chan: ");

                for (int i = 0; i < soChan.Count; i++)
                {
                    Console.Write(soChan[i] + " ");
                }

                Console.WriteLine();
            }

            // Xuat so le
            if (soLe.Count == 0)
            {
                Console.WriteLine("Khong co so le trong mang.");
            }
            else
            {
                Console.Write("Mang cac so le: ");

                for (int i = 0; i < soLe.Count; i++)
                {
                    Console.Write(soLe[i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

/*
- TEST CASE 1:
Input:
n = 2
m = 3

Output:
Mang A: gồm 2 dòng, 3 cột.
Các phần tử nằm trong đoạn [10, 100].
Mang cac so chan: các số chẵn được sinh ra.
Mang cac so le: các số lẻ được sinh ra.

- TEST CASE 2:
Input:
n = 3
m = 3

Output:
Mang A: gồm 3 dòng, 3 cột.
Các phần tử nằm trong đoạn [10, 100].
Mang cac so chan: các số chẵn được sinh ra.
Mang cac so le: các số lẻ được sinh ra.

- TEST CASE 3:
Input:
n = 1
m = 5

Output:
Mang A: gồm 1 dòng, 5 cột.
Các phần tử nằm trong đoạn [10, 100].
Mang cac so chan: các số chẵn được sinh ra.
Mang cac so le: các số lẻ được sinh ra.

- TEST CASE 4:
Input:
n = 4
m = 2

Output:
Mang A: gồm 4 dòng, 2 cột.
Các phần tử nằm trong đoạn [10, 100].
Mang cac so chan: các số chẵn được sinh ra.
Mang cac so le: các số lẻ được sinh ra.

- TEST CASE 5:
Input:
n = 5
m = 5

Output:
Mang A: gồm 5 dòng, 5 cột.
Các phần tử nằm trong đoạn [10, 100].
Mang cac so chan: các số chẵn được sinh ra.
Mang cac so le: các số lẻ được sinh ra.
*/