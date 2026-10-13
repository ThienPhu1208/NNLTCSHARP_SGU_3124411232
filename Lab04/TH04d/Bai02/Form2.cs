using System;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form2 : Form
    {
        MangSoNguyen mang = new MangSoNguyen();

        public Form2()
        {
            InitializeComponent();
        }

        // Khi Form duoc load
private void Form2_Load(
    object sender,
    EventArgs e)
{
    radTang.Checked = true;

    radTimGiaTri.Checked = true;
    radXoaGiaTri.Checked = true;
    radThayGiaTri.Checked = true;

    txtTimViTri.Enabled = false;
    txtXoaViTri.Enabled = false;
    txtThayViTri.Enabled = false;
}

        // Doc mang tu textbox
        private bool DocMang()
        {
            if (txtNhapMang.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui long nhap mang!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNhapMang.Focus();
                return false;
            }

            string[] danhSach =
                txtNhapMang.Text.Split(
                    new char[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries
                );

            int[] a = new int[danhSach.Length];

            for (int i = 0; i < danhSach.Length; i++)
            {
                if (!int.TryParse(danhSach[i], out a[i]))
                {
                    MessageBox.Show(
                        "Mang chi duoc nhap so nguyen!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtNhapMang.Focus();
                    return false;
                }
            }

            mang = new MangSoNguyen(a);

            return true;
        }

        // Kiem tra da co mang chua
        private bool KiemTraMang()
        {
            if (mang.A.Length == 0)
            {
                return DocMang();
            }

            return true;
        }

        // Hien thi mang
        private void HienThiMang()
        {
            txtKetQuaMang.Text = mang.XuatMang();
        }

        // Cap nhat cac ket qua
        private void CapNhatKetQua()
        {
            if (mang.A.Length == 0)
            {
                txtKetQuaMang.Clear();
                txtTongMang.Clear();
                txtTongChan.Clear();
                txtTongLe.Clear();
                txtMax.Clear();
                txtMin.Clear();

                return;
            }

            HienThiMang();

            txtTongMang.Text =
                mang.TongMang().ToString();

            txtTongChan.Text =
                mang.TongChan().ToString();

            txtTongLe.Text =
                mang.TongLe().ToString();

            txtMax.Text =
                mang.TimMax().ToString();

            txtMin.Text =
                mang.TimMin().ToString();
        }

        // Thuc hien sap xep
        private void btnThucHien_Click(
            object sender,
            EventArgs e)
        {
            if (!DocMang())
            {
                return;
            }

            if (radTang.Checked)
            {
                mang.SapXepTang();
            }
            else
            {
                mang.SapXepGiam();
            }

            CapNhatKetQua();
        }

        // Tim gia tri
        private void radTimGiaTri_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radTimGiaTri.Checked)
            {
                txtTimGiaTri.Enabled = true;
                txtTimViTri.Enabled = false;
            }
        }

        // Tim vi tri
        private void radTimViTri_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radTimViTri.Checked)
            {
                txtTimGiaTri.Enabled = false;
                txtTimViTri.Enabled = true;
            }
        }

        // Tim kiem
        private void btnTim_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraMang())
            {
                return;
            }

            // Tim theo gia tri
            if (radTimGiaTri.Checked)
            {
                int giaTri;

                if (!int.TryParse(
                    txtTimGiaTri.Text,
                    out giaTri))
                {
                    MessageBox.Show(
                        "Vui long nhap gia tri can tim!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtTimGiaTri.Focus();
                    return;
                }

                int viTri =
                    mang.TimViTri(giaTri);

                if (viTri == -1)
                {
                    MessageBox.Show(
                        "Khong tim thay gia tri!",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    txtSoTimDuoc.Clear();
                }
                else
                {
                    txtSoTimDuoc.Text =
                        viTri.ToString();
                }
            }
            // Tim theo vi tri
            else
            {
                int viTri;

                if (!int.TryParse(
                    txtTimViTri.Text,
                    out viTri))
                {
                    MessageBox.Show(
                        "Vui long nhap vi tri can tim!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtTimViTri.Focus();
                    return;
                }

                if (viTri < 0 ||
                    viTri >= mang.A.Length)
                {
                    MessageBox.Show(
                        "Vi tri khong hop le!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                txtSoTimDuoc.Text =
                    mang.A[viTri].ToString();
            }
        }

        // Chon xoa theo gia tri
        private void radXoaGiaTri_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radXoaGiaTri.Checked)
            {
                txtXoaGiaTri.Enabled = true;
                txtXoaViTri.Enabled = false;
            }
        }

        // Chon xoa theo vi tri
        private void radXoaViTri_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radXoaViTri.Checked)
            {
                txtXoaGiaTri.Enabled = false;
                txtXoaViTri.Enabled = true;
            }
        }

        // Xoa
        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraMang())
            {
                return;
            }

            // Xoa theo gia tri
            if (radXoaGiaTri.Checked)
            {
                int giaTri;

                if (!int.TryParse(
                    txtXoaGiaTri.Text,
                    out giaTri))
                {
                    MessageBox.Show(
                        "Vui long nhap gia tri can xoa!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtXoaGiaTri.Focus();
                    return;
                }

                if (!mang.XoaGiaTri(giaTri))
                {
                    MessageBox.Show(
                        "Khong tim thay gia tri can xoa!",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }
            }
            // Xoa theo vi tri
            else
            {
                int viTri;

                if (!int.TryParse(
                    txtXoaViTri.Text,
                    out viTri))
                {
                    MessageBox.Show(
                        "Vui long nhap vi tri can xoa!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtXoaViTri.Focus();
                    return;
                }

                if (viTri < 0 ||
                    viTri >= mang.A.Length)
                {
                    MessageBox.Show(
                        "Vi tri khong hop le!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                mang.XoaViTri(viTri);
            }

            CapNhatKetQua();
        }

        // Them
        private void btnThem_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraMang())
            {
                return;
            }

            int giaTri;
            int viTri;

            if (!int.TryParse(
                txtThemGiaTri.Text,
                out giaTri))
            {
                MessageBox.Show(
                    "Vui long nhap gia tri can them!",
                    "Loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtThemGiaTri.Focus();
                return;
            }

            if (!int.TryParse(
                txtThemViTri.Text,
                out viTri))
            {
                MessageBox.Show(
                    "Vui long nhap vi tri can them!",
                    "Loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtThemViTri.Focus();
                return;
            }

            if (viTri < 0 ||
                viTri > mang.A.Length)
            {
                MessageBox.Show(
                    "Vi tri khong hop le!",
                    "Loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            mang.Them(
                giaTri,
                viTri
            );

            CapNhatKetQua();
        }

        // Tong
        private void btnTong_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraMang())
            {
                return;
            }

            txtTongMang.Text =
                mang.TongMang().ToString();

            txtTongChan.Text =
                mang.TongChan().ToString();

            txtTongLe.Text =
                mang.TongLe().ToString();
        }

        // Max Min
        private void btnMaxMin_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraMang())
            {
                return;
            }

            txtMax.Text =
                mang.TimMax().ToString();

            txtMin.Text =
                mang.TimMin().ToString();
        }

        // Chon thay theo gia tri
        private void radThayGiaTri_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radThayGiaTri.Checked)
            {
                txtThayGiaTri.Enabled = true;
                txtThayViTri.Enabled = false;
            }
        }

        // Chon thay theo vi tri
        private void radThayViTri_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radThayViTri.Checked)
            {
                txtThayGiaTri.Enabled = false;
                txtThayViTri.Enabled = true;
            }
        }

        // Thay the
        private void btnThayThe_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraMang())
            {
                return;
            }

            int soThay;

            if (!int.TryParse(
                txtSoThay.Text,
                out soThay))
            {
                MessageBox.Show(
                    "Vui long nhap so thay the!",
                    "Loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSoThay.Focus();
                return;
            }

            // Thay theo gia tri
            if (radThayGiaTri.Checked)
            {
                int giaTri;

                if (!int.TryParse(
                    txtThayGiaTri.Text,
                    out giaTri))
                {
                    MessageBox.Show(
                        "Vui long nhap gia tri can thay!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtThayGiaTri.Focus();
                    return;
                }

                if (!mang.ThayTheGiaTri(
                    giaTri,
                    soThay))
                {
                    MessageBox.Show(
                        "Khong tim thay gia tri!",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }
            }
            // Thay theo vi tri
            else
            {
                int viTri;

                if (!int.TryParse(
                    txtThayViTri.Text,
                    out viTri))
                {
                    MessageBox.Show(
                        "Vui long nhap vi tri can thay!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtThayViTri.Focus();
                    return;
                }

                if (!mang.ThayTheViTri(
                    viTri,
                    soThay))
                {
                    MessageBox.Show(
                        "Vi tri khong hop le!",
                        "Loi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }

            CapNhatKetQua();
        }

        // Reset
        private void btnReset_Click(
            object sender,
            EventArgs e)
        {
            mang =
                new MangSoNguyen();

            txtNhapMang.Clear();
            txtKetQuaMang.Clear();

            txtTimGiaTri.Clear();
            txtTimViTri.Clear();
            txtSoTimDuoc.Clear();

            txtXoaGiaTri.Clear();
            txtXoaViTri.Clear();

            txtThemGiaTri.Clear();
            txtThemViTri.Clear();

            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtMax.Clear();
            txtMin.Clear();

            txtThayGiaTri.Clear();
            txtThayViTri.Clear();
            txtSoThay.Clear();

            radTang.Checked = true;

            radTimGiaTri.Checked = true;
            radXoaGiaTri.Checked = true;
            radThayGiaTri.Checked = true;
        }

        // Thoat
        private void btnThoat_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        // Xac nhan truoc khi dong
        private void Form2_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult ketQua =
                MessageBox.Show(
                    "Ban co muon thoat chuong trinh khong?",
                    "Xac nhan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (ketQua == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}