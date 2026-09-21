/*
* BÀI 1.2: XÂY DỰNG LỚP POINT
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 18/09/2026
*
* Phát biểu đề bài:
* - Xây dựng lớp Point có tọa độ x, y.
* - Có Property X, Y.
* - Constructor mặc định khởi tạo x, y bằng 0.
* - Có phương thức Input, Output.
* - Override hàm ToString().
* - Nạp chồng các phép toán +, -, lấy âm (-).
* - Tính khoảng cách và trung điểm của hai điểm
*   bằng phương thức thành viên và phương thức tĩnh.
*
* Ý tưởng:
* - Dùng Field x, y để lưu tọa độ.
* - Dùng Property X, Y để truy xuất tọa độ.
* - Dùng Input() để nhập tọa độ và Output() để xuất tọa độ.
* - Dùng ToString() để trả về tọa độ của Point.
* - Nạp chồng +, -, - để thực hiện các phép toán với Point.
* - Dùng công thức khoảng cách giữa hai điểm.
* - Dùng công thức trung điểm của hai điểm.
*/

using System;

namespace TH02
{
    class Point
    {
        // Field
        private double x;
        private double y;

        // Constructor mac dinh
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Property
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Method Input
        public void Input()
        {
            Console.Write("Nhap x: ");
            X = double.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            Y = double.Parse(Console.ReadLine());
        }

        // Method Output
        public void Output()
        {
            Console.WriteLine("(" + X + ", " + Y + ")");
        }

        // Override ToString()
        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

        // Phep toan +
        public static Point operator +(Point A, Point B)
        {
            Point C = new Point();

            C.X = A.X + B.X;
            C.Y = A.Y + B.Y;

            return C;
        }

        // Phep toan -
        public static Point operator -(Point A, Point B)
        {
            Point C = new Point();

            C.X = A.X - B.X;
            C.Y = A.Y - B.Y;

            return C;
        }

        // Phep lay am
        public static Point operator -(Point A)
        {
            Point B = new Point();

            B.X = -A.X;
            B.Y = -A.Y;

            return B;
        }

        // Khoang cach - phuong thuc thanh vien
        public double KhoangCach(Point B)
        {
            double dx = X - B.X;
            double dy = Y - B.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Khoang cach - phuong thuc tinh
        public static double KhoangCach(Point A, Point B)
        {
            double dx = A.X - B.X;
            double dy = A.Y - B.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Trung diem - phuong thuc thanh vien
        public Point TrungDiem(Point B)
        {
            Point I = new Point();

            I.X = (X + B.X) / 2;
            I.Y = (Y + B.Y) / 2;

            return I;
        }

        // Trung diem - phuong thuc tinh
        public static Point TrungDiem(Point A, Point B)
        {
            Point I = new Point();

            I.X = (A.X + B.X) / 2;
            I.Y = (A.Y + B.Y) / 2;

            return I;
        }
    }

    class Bai01_2
    {
        public static void ChayBai01_2()
        {
            // Khai bao bien
            Point A = new Point();
            Point B = new Point();
            Point I1;
            Point I2;
            Point C;
            Point D;
            Point E;
            double kc1;
            double kc2;

            // Nhap du lieu
            Console.WriteLine("Nhap diem A:");
            A.Input();

            Console.WriteLine("\nNhap diem B:");
            B.Input();

            // Khoang cach - phuong thuc thanh vien
            kc1 = A.KhoangCach(B);

            // Khoang cach - phuong thuc tinh
            kc2 = Point.KhoangCach(A, B);

            // Trung diem - phuong thuc thanh vien
            I1 = A.TrungDiem(B);

            // Trung diem - phuong thuc tinh
            I2 = Point.TrungDiem(A, B);

            // Phep toan
            C = A + B;
            D = A - B;
            E = -A;

            // Xuat ket qua
            Console.WriteLine("\nDiem A: " + A);
            Console.WriteLine("Diem B: " + B);

            Console.WriteLine("\nKhoang cach AB - phuong thuc thanh vien: " + kc1);
            Console.WriteLine("Khoang cach AB - phuong thuc tinh: " + kc2);

            Console.WriteLine("\nTrung diem I - phuong thuc thanh vien: " + I1);
            Console.WriteLine("Trung diem I - phuong thuc tinh: " + I2);

            Console.WriteLine("\nA + B = " + C);
            Console.WriteLine("A - B = " + D);
            Console.WriteLine("-A = " + E);
        }
    }
}

/*
- TEST CASE 1:
Input:
Diem A:
x = 0
y = 0

Diem B:
x = 3
y = 4

Output:
Diem A: (0, 0)
Diem B: (3, 4)
Khoang cach AB - phuong thuc thanh vien: 5
Khoang cach AB - phuong thuc tinh: 5
Trung diem I - phuong thuc thanh vien: (1.5, 2)
Trung diem I - phuong thuc tinh: (1.5, 2)
A + B = (3, 4)
A - B = (-3, -4)
-A = (0, 0)


- TEST CASE 2:
Input:
Diem A:
x = 2
y = 3

Diem B:
x = 4
y = 5

Output:
Diem A: (2, 3)
Diem B: (4, 5)
Khoang cach AB - phuong thuc thanh vien: 2.8284271247461903
Khoang cach AB - phuong thuc tinh: 2.8284271247461903
Trung diem I - phuong thuc thanh vien: (3, 4)
Trung diem I - phuong thuc tinh: (3, 4)
A + B = (6, 8)
A - B = (-2, -2)
-A = (-2, -3)


- TEST CASE 3:
Input:
Diem A:
x = -2
y = 5

Diem B:
x = 4
y = -1

Output:
Diem A: (-2, 5)
Diem B: (4, -1)
Khoang cach AB - phuong thuc thanh vien: 8.485281374238571
Khoang cach AB - phuong thuc tinh: 8.485281374238571
Trung diem I - phuong thuc thanh vien: (1, 2)
Trung diem I - phuong thuc tinh: (1, 2)
A + B = (2, 4)
A - B = (-6, 6)
-A = (2, -5)
*/