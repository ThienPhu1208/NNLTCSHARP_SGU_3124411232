using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form4 : Form
    {
        // Luu day so
        List<int> daySo = new List<int>();

        public Form4()
        {
            InitializeComponent();
        }

        // Nut Nhap
        private void btnNhap_Click(
            object sender,
            EventArgs e)
        {
            int so;

            if (!int.TryParse(txtNhapSo.Text, out so))
            {
                MessageBox.Show(
                    "Vui long nhap mot so nguyen!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNhapSo.Focus();
                return;
            }

            daySo.Add(so);

            // Xuat day so vua nhap
            txtDayVuaNhap.Text =
                string.Join(" ", daySo);

            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // Nut Tinh Tong
        private void btnTinhTong_Click(
            object sender,
            EventArgs e)
        {
            int tong = 0;

            foreach (int so in daySo)
            {
                tong += so;
            }

            txtTong.Text = tong.ToString();
        }

        // Nut Tong Chan
        private void btnTongChan_Click(
            object sender,
            EventArgs e)
        {
            int tongChan = 0;

            foreach (int so in daySo)
            {
                if (so % 2 == 0)
                {
                    tongChan += so;
                }
            }

            txtTongChan.Text = tongChan.ToString();
        }

        // Nut Tong Le
        private void btnTongLe_Click(
            object sender,
            EventArgs e)
        {
            int tongLe = 0;

            foreach (int so in daySo)
            {
                if (so % 2 != 0)
                {
                    tongLe += so;
                }
            }

            txtTongLe.Text = tongLe.ToString();
        }

        // Nut Tiep Tuc
        private void btnTiepTuc_Click(
            object sender,
            EventArgs e)
        {
            daySo.Clear();

            txtNhapSo.Clear();
            txtDayVuaNhap.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtNhapSo.Focus();
        }

        // Nut Thoat
        private void btnThoat_Click(
            object sender,
            EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Ban co muon thoat chuong trinh khong?",
                "Xac nhan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Hoi xac nhan truoc khi dong Form
        private void Form4_FormClosing(
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

        // Chi cho nhap so nguyen
        private void txtNhapSo_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}