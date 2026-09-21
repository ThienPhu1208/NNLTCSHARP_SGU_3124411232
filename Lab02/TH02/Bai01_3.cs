/*
* BÀI 1.3: XÂY DỰNG LỚP PERSON
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 18/09/2026
*
* Phát biểu đề bài:
* - Xây dựng lớp Person quản lý thông tin của một người.
* - Dữ liệu gồm: id, name, yob, yod.
* - Có Default Constructor, Copy Constructor.
* - Có Input(), Output().
* - Có IsLiving() kiểm tra người còn sống hay đã mất.
*
* Ý tưởng:
* - id: mã của người.
* - name: họ tên.
* - yob: năm sinh.
* - yod: năm mất.
* - Nếu yod = 0 thì người đó còn sống.
* - Nếu yod khác 0 thì người đó đã mất.
*
* Mã giả:
* - Khai báo lớp Person.
* - Khai báo các dữ liệu thành viên.
* - Xây dựng Default Constructor.
* - Xây dựng Copy Constructor.
* - Xây dựng Input() và Output().
* - Xây dựng IsLiving().
*/

using System;

namespace TH02
{
    class Person
    {
        // Field
        private int id;
        private string name;
        private int yob;
        private int yod;

        // Default Constructor
        public Person()
        {
            id = 0;
            name = "";
            yob = 0;
            yod = 0;
        }

        // Copy Constructor
        public Person(Person p)
        {
            id = p.id;
            name = p.name;
            yob = p.yob;
            yod = p.yod;
        }

        // Input
        public void Input()
        {
            Console.Write("Nhap id: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhap name: ");
            name = Console.ReadLine();

            Console.Write("Nhap yob: ");
            yob = int.Parse(Console.ReadLine());

            Console.Write("Nhap yod (nhap 0 neu con song): ");
            yod = int.Parse(Console.ReadLine());
        }

        // Output
        public void Output()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("YOB: " + yob);
            Console.WriteLine("YOD: " + yod);
        }

        // IsLiving
        public bool IsLiving()
        {
            if (yod == 0)
                return true;

            return false;
        }
    }

    class Bai01_3
    {
        public static void ChayBai01_3()
        {
            // Khai bao bien
            Person p1 = new Person();
            Person p2;

            // Nhap du lieu
            Console.WriteLine("Nhap thong tin Person:");
            p1.Input();

            // Copy Constructor
            p2 = new Person(p1);

            // Xuat ket qua
            Console.WriteLine("\nThong tin Person:");
            p1.Output();

            if (p1.IsLiving())
                Console.WriteLine("Trang thai: Con song");
            else
                Console.WriteLine("Trang thai: Da mat");

            Console.WriteLine("\nThong tin Person copy:");
            p2.Output();
        }
    }
}

/*
- TEST CASE 1:
Input:
id = 1
name = Nguyen Van An
yob = 2000
yod = 0

Output:
ID: 1
Name: Nguyen Van An
YOB: 2000
YOD: 0
Trang thai: Con song


- TEST CASE 2:
Input:
id = 2
name = Tran Van Binh
yob = 1980
yod = 2020

Output:
ID: 2
Name: Tran Van Binh
YOB: 1980
YOD: 2020
Trang thai: Da mat


- TEST CASE 3:
Input:
id = 3
name = Le Thi Hoa
yob = 1995
yod = 0

Output:
ID: 3
Name: Le Thi Hoa
YOB: 1995
YOD: 0
Trang thai: Con song
*/