/*
* BÀI 2.1: XÂY DỰNG LỚP ARRAYPOINT
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 19/09/2026
*
* Phát biểu đề bài: Thiết kế lớp ArrayPoint có chức năng lưu trữ các Point:
* - Field: Một ArrayList các Point.
* - Indexer cho phép truy cập Point thứ i của ArrayList.
*
* Ý tưởng:
* - Khai báo một ArrayList để lưu các đối tượng Point.
* - Xây dựng phương thức thêm Point vào ArrayList.
* - Xây dựng Indexer để truy cập Point theo vị trí.
*
* Mã giả:
* - Khai báo lớp ArrayPoint.
* - Khai báo Field ArrayList để lưu các Point.
* - Xây dựng phương thức ThemPoint().
* - Xây dựng Indexer this[i].
* - Nhập các Point.
* - Xuất các Point thông qua Indexer.
*/
using System;
using System.Collections;

namespace TH02
{
    class ArrayPoint
    {
        // Field
        private ArrayList dsPoint;

        // Constructor mac nhien
        public ArrayPoint()
        {
            dsPoint = new ArrayList();
        }

        // Them Point vao ArrayList
        public void ThemPoint(Point p)
        {
            dsPoint.Add(p);
        }

        // Indexer
        public Point this[int i]
        {
            get
            {
                return (Point)dsPoint[i];
            }
            set
            {
                dsPoint[i] = value;
            }
        }

        // So luong Point
        public int SoLuong
        {
            get
            {
                return dsPoint.Count;
            }
        }
    }

    class Bai02_1
    {
        public static void ChayBai02_1()
        {
            // Khai bao bien
            ArrayPoint danhSach;
            int n;
            Point p;

            // Nhap du lieu
            Console.Write("Nhap so luong Point: ");
            n = int.Parse(Console.ReadLine());

            // Xu ly
            danhSach = new ArrayPoint();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap Point thu " + (i + 1) + ":");

                p = new Point();
                p.Input();

                danhSach.ThemPoint(p);
            }

            // Xuat ket qua
            Console.WriteLine("\nDanh sach Point:");

            for (int i = 0; i < danhSach.SoLuong; i++)
            {
                Console.WriteLine("Point thu " + (i + 1) + ": " + danhSach[i]);
            }
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
5
6

Output:
Danh sach Point:
Point thu 1: (1, 2)
Point thu 2: (3, 4)
Point thu 3: (5, 6)


- TEST CASE 2:
Input:
2
-1
3
4
-2

Output:
Danh sach Point:
Point thu 1: (-1, 3)
Point thu 2: (4, -2)


- TEST CASE 3:
Input:
1
5
7

Output:
Danh sach Point:
Point thu 1: (5, 7)
*/