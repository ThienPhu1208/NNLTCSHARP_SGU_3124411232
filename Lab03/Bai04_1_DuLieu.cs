/*
* DANH SÁCH DỮ LIỆU MÔN HỌC
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 29/09/2026
*
* Phát biểu đề bài:
* Tạo lớp DuLieu có phương thức tĩnh DS_Mon()
* trả về List<MonHoc>.
*
* Sử dụng danh sách môn học được cung cấp trong đề bài.
*/

using System.Collections.Generic;

namespace Lab03
{
    public class DuLieu
    {
        public static List<MonHoc> DS_Mon()
        {
            List<MonHoc> ds = new List<MonHoc>();

            ds.Add(new MonHoc
            {
                MaMon = "HP2_1",
                TenMon = "Nền tảng C#",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "HP2_2",
                TenMon = "Công nghệ ADO.NET",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "HP3_1",
                TenMon = "Lập trình Windows Forms",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "HP3_2",
                TenMon = "Xây dựng ứng dụng Windows Forms",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "HP4_1",
                TenMon = "Lập trình Web với HTML, CSS và JavaScript",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "HP4_2",
                TenMon = "Xây dựng ứng dụng Web với ASP.NET",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "HP5_1",
                TenMon = "Lập trình CSDL SQL Server căn bản",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "HP5_2",
                TenMon = "Lập trình CSDL SQL Server nâng cao",
                He = "KTV",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "JLCB",
                TenMon = "Joomla cơ bản",
                He = "CD",
                SoTiet = 72
            });

            ds.Add(new MonHoc
            {
                MaMon = "LINQ",
                TenMon = "Language-Integrated Query",
                He = "CD",
                SoTiet = 64
            });

            ds.Add(new MonHoc
            {
                MaMon = "DAWEB",
                TenMon = "Đồ án thực tế Web với ASP.NET",
                He = "CD",
                SoTiet = 40
            });

            ds.Add(new MonHoc
            {
                MaMon = "DAWIN",
                TenMon = "Đồ án thực tế Windows Forms",
                He = "CD",
                SoTiet = 40
            });

            ds.Add(new MonHoc
            {
                MaMon = "CC++",
                TenMon = "Lập trình hướng đối tượng với C/C++",
                He = "CD",
                SoTiet = 128
            });

            ds.Add(new MonHoc
            {
                MaMon = "JQUE",
                TenMon = "JQuery",
                He = "CD",
                SoTiet = 22
            });

            ds.Add(new MonHoc
            {
                MaMon = "XML",
                TenMon = "Công nghệ XML",
                He = "CD",
                SoTiet = 32
            });

            ds.Add(new MonHoc
            {
                MaMon = "CRYS",
                TenMon = "Crystal Report trong Visual Studio",
                He = "CD",
                SoTiet = 32
            });

            ds.Add(new MonHoc
            {
                MaMon = "BWEB",
                TenMon = "HTML, CSS và JavaScript",
                He = "CD",
                SoTiet = 32
            });

            ds.Add(new MonHoc
            {
                MaMon = "XYZ",
                TenMon = "Chưa đặt tên môn",
                He = "",
                SoTiet = 0
            });

            return ds;
        }
    }
}