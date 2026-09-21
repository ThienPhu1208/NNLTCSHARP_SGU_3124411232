/*
* BÀI 2.2: XÂY DỰNG LỚP PERSONLIST
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 19/09/2026
*
* Phát biểu đề bài:
* Một địa phương cần quản lý nhân khẩu nên đã thiết kế lớp PersonList
* dùng để quản lý nhiều người khác nhau.
*
* Lớp PersonList có các phương thức:
* - Default Constructor, Copy Constructor.
* - Input(), Output(): Nhập, xuất dữ liệu của PersonList.
* - Add(Person x): Thêm một Person vào PersonList.
* - LivingPeople(): Trả về một PersonList những người còn sống.
*
* Ý tưởng:
* - Sử dụng ArrayList để lưu danh sách các Person.
* - Dùng Add() để thêm Person vào danh sách.
* - Dùng Input() để nhập nhiều Person.
* - Dùng Output() để xuất danh sách Person.
* - Dùng IsLiving() của lớp Person để kiểm tra người còn sống.
* - LivingPeople() tạo một PersonList mới và thêm những người còn sống vào.
*
* Mã giả:
* - Khai báo lớp PersonList chứa ArrayList.
* - Xây dựng Constructor mặc nhiên.
* - Xây dựng Copy Constructor.
* - Xây dựng phương thức Add().
* - Xây dựng phương thức Input().
* - Xây dựng phương thức Output().
* - Xây dựng phương thức LivingPeople().
*/
using System;
using System.Collections;

namespace TH02
{
    class PersonList
    {
        // Field
        private ArrayList dsPerson;

        // Constructor mac nhien
        public PersonList()
        {
            dsPerson = new ArrayList();
        }

        // Constructor sao chep
        public PersonList(PersonList p)
        {
            dsPerson = new ArrayList();

            for (int i = 0; i < p.dsPerson.Count; i++)
            {
                Person person = (Person)p.dsPerson[i];
                dsPerson.Add(new Person(person));
            }
        }

        // Them Person vao danh sach
        public void Add(Person x)
        {
            dsPerson.Add(x);
        }

        // Nhap danh sach Person
        public void Input()
        {
            int n;
            Person p;

            Console.Write("Nhap so luong Person: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap Person thu " + (i + 1) + ":");

                p = new Person();
                p.Input();

                Add(p);
            }
        }

        // Xuat danh sach Person
        public void Output()
        {
            for (int i = 0; i < dsPerson.Count; i++)
            {
                Console.WriteLine("\nPerson thu " + (i + 1) + ":");

                Person p = (Person)dsPerson[i];
                p.Output();

                if (p.IsLiving())
                    Console.WriteLine("Trang thai: Con song");
                else
                    Console.WriteLine("Trang thai: Da mat");
            }
        }

        // Tra ve danh sach nhung nguoi con song
        public PersonList LivingPeople()
        {
            PersonList ketQua = new PersonList();

            for (int i = 0; i < dsPerson.Count; i++)
            {
                Person p = (Person)dsPerson[i];

                if (p.IsLiving())
                    ketQua.Add(p);
            }

            return ketQua;
        }
    }

    class Bai02_2
    {
        public static void ChayBai02_2()
        {
            // Khai bao bien
            PersonList danhSach;
            PersonList nguoiConSong;

            // Nhap du lieu
            danhSach = new PersonList();

            Console.WriteLine("Nhap danh sach Person:");
            danhSach.Input();

            // Xu ly
            nguoiConSong = danhSach.LivingPeople();

            // Xuat ket qua
            Console.WriteLine("\nDANH SACH PERSON:");
            danhSach.Output();

            Console.WriteLine("\nDANH SACH NGUOI CON SONG:");
            nguoiConSong.Output();
        }
    }
}

/*
- TEST CASE 1:
Input:
3

Person 1:
1
Nguyen Van A
2000
0

Person 2:
2
Nguyen Van B
1990
2020

Person 3:
3
Nguyen Van C
2002
0

Output:
DANH SACH NGUOI CON SONG:

Person thu 1:
ID: 1
Name: Nguyen Van A
YOB: 2000
YOD: 0
Trang thai: Con song

Person thu 2:
ID: 3
Name: Nguyen Van C
YOB: 2002
YOD: 0
Trang thai: Con song


- TEST CASE 2:
Input:
2

Person 1:
1
Nguyen Van A
2000
2020

Person 2:
2
Nguyen Van B
1995
2018

Output:
DANH SACH NGUOI CON SONG:
(Khong co Person con song)


- TEST CASE 3:
Input:
1

Person 1:
1
Nguyen Van A
2005
0

Output:
DANH SACH NGUOI CON SONG:

Person thu 1:
ID: 1
Name: Nguyen Van A
YOB: 2005
YOD: 0
Trang thai: Con song
*/