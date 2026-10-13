using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form6 : Form
    {
        // Luu cac ghe dang chon
        List<int> gheDangChon = new List<int>();

        // Luu cac ghe da ban
        List<int> gheDaBan = new List<int>();

        public Form6()
        {
            InitializeComponent();
        }

        // Lay gia ve theo so ghe
        private int GiaVe(int soGhe)
        {
            if (soGhe >= 1 && soGhe <= 5)
            {
                return 1000;
            }

            if (soGhe >= 6 && soGhe <= 10)
            {
                return 1500;
            }

            return 2000;
        }

        // Xu ly khi click vao ghe
        private void Ghe_Click(object sender, EventArgs e)
        {
            Button ghe = (Button)sender;

            int soGhe = int.Parse(ghe.Text);

            // Neu ghe da ban
            if (gheDaBan.Contains(soGhe))
            {
                MessageBox.Show(
                    "Ghe " + soGhe + " da ban!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Neu ghe dang duoc chon
            if (gheDangChon.Contains(soGhe))
            {
                gheDangChon.Remove(soGhe);

                ghe.BackColor = Color.White;
                ghe.ForeColor = Color.Black;
            }
            else
            {
                gheDangChon.Add(soGhe);

                ghe.BackColor = Color.Blue;
                ghe.ForeColor = Color.White;
            }
        }

        // Nut Chon
        private void btnChon_Click(
            object sender,
            EventArgs e)
        {
            int thanhTien = 0;

            foreach (int soGhe in gheDangChon)
            {
                thanhTien += GiaVe(soGhe);

                gheDaBan.Add(soGhe);
            }

            // Doi ghe dang chon thanh ghe da ban
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button ghe = (Button)control;

                    int soGhe;

                    if (int.TryParse(ghe.Text, out soGhe))
                    {
                        if (gheDangChon.Contains(soGhe))
                        {
                            ghe.BackColor = Color.Yellow;
                            ghe.ForeColor = Color.Black;
                        }
                    }
                }
            }

            txtThanhTien.Text = thanhTien.ToString();

            gheDangChon.Clear();
        }

        // Nut Huy Bo
        private void btnHuyBo_Click(
            object sender,
            EventArgs e)
        {
            // Doi ghe dang chon ve mau trang
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button ghe = (Button)control;

                    int soGhe;

                    if (int.TryParse(ghe.Text, out soGhe))
                    {
                        if (gheDangChon.Contains(soGhe))
                        {
                            ghe.BackColor = Color.White;
                            ghe.ForeColor = Color.Black;
                        }
                    }
                }
            }

            gheDangChon.Clear();

            txtThanhTien.Text = "0";
        }

        // Nut Ket Thuc
        private void btnKetThuc_Click(
            object sender,
            EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Ban co muon ket thuc chuong trinh khong?",
                "Xac nhan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Hoi xac nhan khi dong Form
        private void Form6_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Ban co muon ket thuc chuong trinh khong?",
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