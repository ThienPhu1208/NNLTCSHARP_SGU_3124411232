using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Kiem tra ten dang nhap
        private bool KiemTraTenDangNhap()
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtTenDangNhap,
                    "Vui long nhap ten dang nhap!"
                );

                txtTenDangNhap.Focus();
                return false;
            }

            errorProvider1.SetError(txtTenDangNhap, "");
            return true;
        }

        // Kiem tra email
        private bool KiemTraEmail()
        {
            if (txtEmail.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Vui long nhap dia chi email!"
                );

                return false;
            }

            string mauEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text, mauEmail))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email khong dung dinh dang!"
                );

                return false;
            }

            errorProvider1.SetError(txtEmail, "");
            return true;
        }

        // Kiem tra mat khau
        private bool KiemTraMatKhau()
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Vui long nhap mat khau!"
                );

                txtMatKhau.Focus();
                return false;
            }

            errorProvider1.SetError(txtMatKhau, "");
            return true;
        }

        // Kiem tra email khi roi khoi textbox
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            KiemTraEmail();
        }

        // Xu ly nut Dang ky
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraTenDangNhap())
                return;

            if (!KiemTraEmail())
                return;

            if (!KiemTraMatKhau())
                return;

            string thongTin =
                "Ten dang nhap: " + txtTenDangNhap.Text +
                "\nDia chi email: " + txtEmail.Text +
                "\nMat khau: " + txtMatKhau.Text +
                "\nXac nhan mat khau: " + txtXacNhanMatKhau.Text;

            MessageBox.Show(
                thongTin,
                "Thong tin dang ky",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Nhan Enter tai textbox Xac nhan mat khau
        private void txtXacNhanMatKhau_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        // Hoi xac nhan truoc khi dong Form
        private void Form2_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
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