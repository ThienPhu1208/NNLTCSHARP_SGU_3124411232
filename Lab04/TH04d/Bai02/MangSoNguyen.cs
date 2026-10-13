
using System;

namespace Bai02
{
    public class MangSoNguyen
    {
        // Mang so nguyen
        public int[] A { get; set; }

        // Khoi tao mang rong
        public MangSoNguyen()
        {
            A = new int[0];
        }

        // Khoi tao mang
        public MangSoNguyen(int[] a)
        {
            A = a;
        }

        // Sap xep tang
        public void SapXepTang()
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        int tam = A[i];
                        A[i] = A[j];
                        A[j] = tam;
                    }
                }
            }
        }

        // Sap xep giam
        public void SapXepGiam()
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        int tam = A[i];
                        A[i] = A[j];
                        A[j] = tam;
                    }
                }
            }
        }

        // Tim vi tri dau tien cua gia tri
        public int TimViTri(int giaTri)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == giaTri)
                {
                    return i;
                }
            }

            return -1;
        }

        // Kiem tra gia tri co ton tai
        public bool TimGiaTri(int giaTri)
        {
            return TimViTri(giaTri) != -1;
        }

        // Them gia tri tai vi tri
        public void Them(int giaTri, int viTri)
        {
            if (viTri < 0 || viTri > A.Length)
            {
                return;
            }

            int[] mangMoi = new int[A.Length + 1];

            for (int i = 0; i < viTri; i++)
            {
                mangMoi[i] = A[i];
            }

            mangMoi[viTri] = giaTri;

            for (int i = viTri; i < A.Length; i++)
            {
                mangMoi[i + 1] = A[i];
            }

            A = mangMoi;
        }

        // Xoa gia tri tai vi tri
        public void XoaViTri(int viTri)
        {
            if (viTri < 0 || viTri >= A.Length)
            {
                return;
            }

            int[] mangMoi = new int[A.Length - 1];

            for (int i = 0; i < viTri; i++)
            {
                mangMoi[i] = A[i];
            }

            for (int i = viTri + 1; i < A.Length; i++)
            {
                mangMoi[i - 1] = A[i];
            }

            A = mangMoi;
        }

        // Xoa gia tri
        public bool XoaGiaTri(int giaTri)
        {
            int viTri = TimViTri(giaTri);

            if (viTri == -1)
            {
                return false;
            }

            XoaViTri(viTri);
            return true;
        }

        // Tinh tong mang
        public int TongMang()
        {
            int tong = 0;

            for (int i = 0; i < A.Length; i++)
            {
                tong += A[i];
            }

            return tong;
        }

        // Tinh tong chan
        public int TongChan()
        {
            int tong = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    tong += A[i];
                }
            }

            return tong;
        }

        // Tinh tong le
        public int TongLe()
        {
            int tong = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    tong += A[i];
                }
            }

            return tong;
        }

        // Tim max
        public int TimMax()
        {
            if (A.Length == 0)
            {
                return 0;
            }

            int max = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            return max;
        }

        // Tim min
        public int TimMin()
        {
            if (A.Length == 0)
            {
                return 0;
            }

            int min = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                }
            }

            return min;
        }

        // Thay the gia tri dau tien
        public bool ThayTheGiaTri(int giaTriCu, int giaTriMoi)
        {
            int viTri = TimViTri(giaTriCu);

            if (viTri == -1)
            {
                return false;
            }

            A[viTri] = giaTriMoi;
            return true;
        }

        // Thay the theo vi tri
        public bool ThayTheViTri(int viTri, int giaTriMoi)
        {
            if (viTri < 0 || viTri >= A.Length)
            {
                return false;
            }

            A[viTri] = giaTriMoi;
            return true;
        }

        // Kiem tra mang da sap xep tang
        public bool DaSapXepTang()
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        // Xuat mang thanh chuoi
        public string XuatMang()
        {
            string ketQua = "";

            for (int i = 0; i < A.Length; i++)
            {
                ketQua += A[i];

                if (i < A.Length - 1)
                {
                    ketQua += " ";
                }
            }

            return ketQua;
        }
    }
}

