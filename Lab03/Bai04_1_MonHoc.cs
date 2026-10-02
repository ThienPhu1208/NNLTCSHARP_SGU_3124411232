/*
* LỚP MÔN HỌC
* Tác giả : Nguyễn Thiên Phú
* MSSV: 3124411232
* Ngày viết: 29/09/2026
*
* Phát biểu đề bài:
* Tạo lớp MonHoc gồm các thuộc tính:
* - MaMon: string
* - TenMon: string
* - He: string
* - SoTiet: byte
*/

namespace Lab03
{
    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }
}