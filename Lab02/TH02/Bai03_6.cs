/*
* BÀI 3.6: TÍNH ĐIỂM THÍ SINH
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 21/09/2026
*
* Phát biểu đề bài: Một cuộc thi tin học có hai đối tượng thí sinh:
* - Chuyên: dành cho thí sinh chưa có giải trước đây.
* - Siêu cúp: dành cho thí sinh đã đoạt giải trước đây.
*
* Các thí sinh đều phải làm 3 bài thi lập trình.
* - Thí sinh Chuyên làm thêm bài thi tiếng Anh.
* - Thí sinh Siêu cúp làm thêm bài cơ sở dữ liệu.
*
* Cách tính điểm:
* - Chuyên:
*   + Tổng 3 bài lập trình.
*   + Tiếng Anh từ 7 đến 8: cộng 1 điểm.
*   + Tiếng Anh từ 9 đến 10: cộng 2 điểm.
*
* - Siêu cúp:
*   + Tổng điểm của 4 bài thi.
*
* Ý tưởng:
* - Xây dựng lớp ThiSinhBai36 làm lớp cha.
* - Xây dựng lớp ThiSinhChuyen kế thừa ThiSinhBai36.
* - Xây dựng lớp ThiSinhSieuCup kế thừa ThiSinhBai36.
* - Mỗi lớp con override phương thức TinhTongDiem().
* - Sử dụng mảng kiểu ThiSinhBai36 để lưu cả hai loại thí sinh.
* - Gọi TinhTongDiem() để thể hiện tính đa hình.
*
* Mã giả:
* - Khai báo lớp ThiSinhBai36.
* - Nhập thông tin chung.
* - Xây dựng lớp ThiSinhChuyen.
* - Xây dựng lớp ThiSinhSieuCup.
* - Override phương thức tính tổng điểm.
* - Nhập danh sách thí sinh.
* - Tính tổng điểm từng thí sinh.
* - Xuất kết quả.
*/

using System;

namespace TH02
{
    // Lớp cha
    class ThiSinhBai36
    {
        protected string sbd;
        protected string hoTen;
        protected double bai1;
        protected double bai2;
        protected double bai3;

        // Constructor mặc nhiên
        public ThiSinhBai36()
        {
            sbd = "";
            hoTen = "";
            bai1 = 0;
            bai2 = 0;
            bai3 = 0;
        }

        // Constructor có tham số
        public ThiSinhBai36(
            string sbd,
            string hoTen,
            double bai1,
            double bai2,
            double bai3)
        {
            this.sbd = sbd;
            this.hoTen = hoTen;
            this.bai1 = bai1;
            this.bai2 = bai2;
            this.bai3 = bai3;
        }

        // Nhập thông tin chung
        public virtual void Input()
        {
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap diem bai 1: ");
            bai1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 2: ");
            bai2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 3: ");
            bai3 = double.Parse(Console.ReadLine());
        }

        // Tính tổng điểm
        public virtual double TinhTongDiem()
        {
            return bai1 + bai2 + bai3;
        }

        // Xuất thông tin
        public virtual void Output()
        {
            Console.WriteLine("SBD: " + sbd);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Bai 1: " + bai1);
            Console.WriteLine("Bai 2: " + bai2);
            Console.WriteLine("Bai 3: " + bai3);
            Console.WriteLine("Tong diem: " + TinhTongDiem());
        }
    }

    // Thí sinh Chuyên
    class ThiSinhChuyen : ThiSinhBai36
    {
        private double tiengAnh;

        // Constructor mặc nhiên
        public ThiSinhChuyen()
        {
            tiengAnh = 0;
        }

        // Constructor có tham số
        public ThiSinhChuyen(
            string sbd,
            string hoTen,
            double bai1,
            double bai2,
            double bai3,
            double tiengAnh)
            : base(sbd, hoTen, bai1, bai2, bai3)
        {
            this.tiengAnh = tiengAnh;
        }

        // Nhập thông tin
        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem tieng Anh: ");
            tiengAnh = double.Parse(Console.ReadLine());
        }

        // Tính tổng điểm
        public override double TinhTongDiem()
        {
            double tongDiem;

            tongDiem = bai1 + bai2 + bai3;

            if (tiengAnh >= 7 && tiengAnh <= 8)
                tongDiem = tongDiem + 1;
            else if (tiengAnh >= 9 && tiengAnh <= 10)
                tongDiem = tongDiem + 2;

            return tongDiem;
        }

        // Xuất thông tin
        public override void Output()
        {
            Console.WriteLine("Loai: Thi sinh Chuyen");
            base.Output();
            Console.WriteLine("Tieng Anh: " + tiengAnh);
        }
    }

    // Thí sinh Siêu cúp
    class ThiSinhSieuCup : ThiSinhBai36
    {
        private double csdl;

        // Constructor mặc nhiên
        public ThiSinhSieuCup()
        {
            csdl = 0;
        }

        // Constructor có tham số
        public ThiSinhSieuCup(
            string sbd,
            string hoTen,
            double bai1,
            double bai2,
            double bai3,
            double csdl)
            : base(sbd, hoTen, bai1, bai2, bai3)
        {
            this.csdl = csdl;
        }

        // Nhập thông tin
        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem CSDL: ");
            csdl = double.Parse(Console.ReadLine());
        }

        // Tính tổng điểm
        public override double TinhTongDiem()
        {
            return bai1 + bai2 + bai3 + csdl;
        }

        // Xuất thông tin
        public override void Output()
        {
            Console.WriteLine("Loai: Thi sinh Sieu cup");
            base.Output();
            Console.WriteLine("CSDL: " + csdl);
        }
    }

    class Bai03_6
    {
        public static void ChayBai03_6()
        {
            int n;
            int loai;
            ThiSinhBai36[] dsThiSinh;

            // Nhap so luong
            do
            {
                Console.Write("Nhap so luong thi sinh: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("So luong thi sinh phai lon hon 0!");
            }
            while (n <= 0);

            dsThiSinh = new ThiSinhBai36[n];

            // Nhap danh sach
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nThi sinh thu " + (i + 1));
                Console.WriteLine("1. Thi sinh Chuyen");
                Console.WriteLine("2. Thi sinh Sieu cup");

                do
                {
                    Console.Write("Chon loai thi sinh: ");
                    loai = int.Parse(Console.ReadLine());

                    if (loai != 1 && loai != 2)
                        Console.WriteLine("Loai thi sinh khong hop le!");
                }
                while (loai != 1 && loai != 2);

                if (loai == 1)
                {
                    dsThiSinh[i] = new ThiSinhChuyen();
                }
                else
                {
                    dsThiSinh[i] = new ThiSinhSieuCup();
                }

                dsThiSinh[i].Input();
            }

            // Xuat ket qua
            Console.WriteLine("\n========== KET QUA ==========");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nThi sinh thu " + (i + 1) + ":");

                dsThiSinh[i].Output();
            }
        }
    }
}

/*
- TEST CASE 1:
Input:
2
1
TS01
Nguyen Van A
8
7
9
8
2
TS02
Tran Van B
8
8
9
9

Output:
Thi sinh thu 1:
Loai: Thi sinh Chuyen
SBD: TS01
Ho ten: Nguyen Van A
Bai 1: 8
Bai 2: 7
Bai 3: 9
Tong diem: 25
Tieng Anh: 8

Thi sinh thu 2:
Loai: Thi sinh Sieu cup
SBD: TS02
Ho ten: Tran Van B
Bai 1: 8
Bai 2: 8
Bai 3: 9
Tong diem: 34
CSDL: 9


- TEST CASE 2:
Input:
2
1
TS03
Le Van C
7
8
8
9
2
TS04
Pham Van D
9
9
8
10

Output:
Thi sinh thu 1:
Loai: Thi sinh Chuyen
SBD: TS03
Ho ten: Le Van C
Bai 1: 7
Bai 2: 8
Bai 3: 8
Tong diem: 25
Tieng Anh: 9

Thi sinh thu 2:
Loai: Thi sinh Sieu cup
SBD: TS04
Ho ten: Pham Van D
Bai 1: 9
Bai 2: 9
Bai 3: 8
Tong diem: 36
CSDL: 10


- TEST CASE 3:
Input:
1
1
TS05
Hoang Van E
6
7
8
6

Output:
Thi sinh thu 1:
Loai: Thi sinh Chuyen
SBD: TS05
Ho ten: Hoang Van E
Bai 1: 6
Bai 2: 7
Bai 3: 8
Tong diem: 21
Tieng Anh: 6
*/