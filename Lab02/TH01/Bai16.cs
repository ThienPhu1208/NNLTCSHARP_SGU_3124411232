/*
* BÀI 16: SẮP XẾP MẢNG HỌ TÊN
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 18/09/2026
*
* Phát biểu đề bài:
* - Nhập vào một mảng họ tên của n người.
* - Sắp xếp mảng theo thứ tự tăng dần.
*
* Ý tưởng:
* - Nhập số lượng người n.
* - Nhập họ tên của từng người vào mảng.
* - Dùng Array.Sort() để sắp xếp mảng theo thứ tự tăng dần.
* - Xuất mảng sau khi sắp xếp.
*
* Mã giả:
* - Nhập n.
* - Nhập n họ tên.
* - Sắp xếp mảng.
* - Xuất mảng sau khi sắp xếp.
*/

using System;

namespace TH01
{
    class Bai16
    {
        public static void NhapMang(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap ho ten nguoi thu " + (i + 1) + ": ");
                a[i] = Console.ReadLine();
            }
        }

        public static void SapXep(string[] a)
        {
            Array.Sort(a);
        }

        public static void XuatMang(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static void ChayBai16()
        {
            // Khai bao bien
            int n;
            string[] a;

            // Nhap du lieu
            Console.Write("Nhap so nguoi n: ");
            n = int.Parse(Console.ReadLine());

            a = new string[n];

            NhapMang(a);

            // Xu ly
            SapXep(a);

            // Xuat ket qua
            Console.WriteLine("\nDanh sach sau khi sap xep tang dan:");
            XuatMang(a);
        }
    }
}

/*
- TEST CASE 1:
Input:
n = 4
Nguyen Van An
Tran Thi Binh
Le Van Cuong
Pham Minh Anh

Output:
Danh sach sau khi sap xep tang dan:
Le Van Cuong
Nguyen Van An
Pham Minh Anh
Tran Thi Binh

- TEST CASE 2:
Input:
n = 3
Zoe
Anna
Bob

Output:
Danh sach sau khi sap xep tang dan:
Anna
Bob
Zoe

- TEST CASE 3:
Input:
n = 3
Nguyen Van An
Nguyen Van An
Tran Van Binh

Output:
Danh sach sau khi sap xep tang dan:
Nguyen Van An
Nguyen Van An
Tran Van Binh

- TEST CASE 4:
Input:
n = 1
Nguyen Thien Phu

Output:
Danh sach sau khi sap xep tang dan:
Nguyen Thien Phu
*/