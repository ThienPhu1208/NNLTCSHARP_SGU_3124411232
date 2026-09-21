/*
* BÀI 15: MẢNG, ARRAYLIST
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 17/09/2026
*
* Phát biểu đề bài:
* - Viết các phương thức thành viên:
*   + Nhập mảng gồm n phần tử.
*   + In mảng ra màn hình.
*   + Tìm phần tử lớn nhất và nhỏ nhất trong mảng.
*   + Trả về mảng các số nguyên tố.
*
* Ý tưởng:
* - Dùng mảng số nguyên để lưu n phần tử.
* - Duyệt mảng để tìm phần tử lớn nhất và nhỏ nhất.
* - Kiểm tra từng phần tử có phải số nguyên tố hay không.
* - Dùng ArrayList để lưu các số nguyên tố.
*
* Mã giả:
* - Nhập n và nhập các phần tử của mảng.
* - In các phần tử trong mảng.
* - Tìm max và min.
* - Duyệt mảng, nếu là số nguyên tố thì thêm vào ArrayList.
* - Trả về ArrayList chứa các số nguyên tố.
*/

using System;
using System.Collections;

namespace TH01
{
    class Bai15
    {
        // Nhap mang
        public static void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // In mang
        public static void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }

        // Tim gia tri lon nhat
        public static int TimMax(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }

            return max;
        }

        // Tim gia tri nho nhat
        public static int TimMin(int[] a)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }

            return min;
        }

        // Kiem tra so nguyen to
        public static bool KiemTraSoNguyenTo(int n)
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

        // Tra ve mang cac so nguyen to
        public static ArrayList TimSoNguyenTo(int[] a)
        {
            ArrayList ketQua = new ArrayList();

            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSoNguyenTo(a[i]))
                {
                    ketQua.Add(a[i]);
                }
            }

            return ketQua;
        }

        public static void ChayBai15()
        {
            // Khai bao bien
            int n;
            int[] a;
            int max, min;
            ArrayList soNguyenTo;

            // Nhap du lieu
            Console.Write("Nhap so phan tu n: ");
            n = int.Parse(Console.ReadLine());

            a = new int[n];

            NhapMang(a);

            // Xuat mang
            Console.Write("Mang vua nhap: ");
            InMang(a);

            // Tim max, min
            max = TimMax(a);
            min = TimMin(a);

            Console.WriteLine("Phan tu lon nhat: " + max);
            Console.WriteLine("Phan tu nho nhat: " + min);

            // Tim so nguyen to
            soNguyenTo = TimSoNguyenTo(a);

            if (soNguyenTo.Count == 0)
            {
                Console.WriteLine("Khong co so nguyen to trong mang.");
            }
            else
            {
                Console.Write("Cac so nguyen to trong mang: ");

                for (int i = 0; i < soNguyenTo.Count; i++)
                {
                    Console.Write(soNguyenTo[i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

/*
- TEST CASE 1:
Input:
n = 5
a = 2 5 8 11 3

Output:
Mang vua nhap: 2 5 8 11 3
Phan tu lon nhat: 11
Phan tu nho nhat: 2
Cac so nguyen to trong mang: 2 5 11 3


- TEST CASE 2:
Input:
n = 6
a = 10 20 30 40 50 60

Output:
Mang vua nhap: 10 20 30 40 50 60
Phan tu lon nhat: 60
Phan tu nho nhat: 10
Cac so nguyen to trong mang:


- TEST CASE 3:
Input:
n = 5
a = -5 7 2 -10 13

Output:
Mang vua nhap: -5 7 2 -10 13
Phan tu lon nhat: 13
Phan tu nho nhat: -10
Cac so nguyen to trong mang: 7 2 13


- TEST CASE 4:
Input:
n = 4
a = 3 3 5 7

Output:
Mang vua nhap: 3 3 5 7
Phan tu lon nhat: 7
Phan tu nho nhat: 3
Cac so nguyen to trong mang: 3 3 5 7


- TEST CASE 5:
Input:
n = 1
a = 17

Output:
Mang vua nhap: 17
Phan tu lon nhat: 17
Phan tu nho nhat: 17
Cac so nguyen to trong mang: 17
*/