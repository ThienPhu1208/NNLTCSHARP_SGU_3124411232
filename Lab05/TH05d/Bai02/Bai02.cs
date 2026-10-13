
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TH05d
{
    public class Bai02 : Form
    {
        private TextBox txtSoTaiKhoan;
        private TextBox txtTenKhachHang;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private TextBox txtTongTien;

        private ListView lvTaiKhoan;

        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;

        private bool dangThem = false;
        private int viTriDangSua = -1;

        public Bai02()
        {
            InitializeComponent();
            CapNhatSTT();
            CapNhatTongTien();
        }

        private void InitializeComponent()
        {
            this.Text = "frmBaiTap2";
            this.Size = new Size(700, 510);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Label lblTieuDe = new Label();
            lblTieuDe.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblTieuDe.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Size = new Size(640, 40);

            Label lblSoTK = new Label();
            lblSoTK.Text = "Số tài khoản";
            lblSoTK.Location = new Point(80, 70);
            lblSoTK.Size = new Size(130, 25);
            lblSoTK.TextAlign = ContentAlignment.MiddleRight;

            txtSoTaiKhoan = new TextBox();
            txtSoTaiKhoan.Location = new Point(220, 70);
            txtSoTaiKhoan.Size = new Size(310, 25);

            Label lblTen = new Label();
            lblTen.Text = "Tên khách hàng";
            lblTen.Location = new Point(80, 100);
            lblTen.Size = new Size(130, 25);
            lblTen.TextAlign = ContentAlignment.MiddleRight;

            txtTenKhachHang = new TextBox();
            txtTenKhachHang.Location = new Point(220, 100);
            txtTenKhachHang.Size = new Size(310, 25);

            Label lblDiaChi = new Label();
            lblDiaChi.Text = "Địa chỉ khách hàng";
            lblDiaChi.Location = new Point(60, 130);
            lblDiaChi.Size = new Size(150, 25);
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;

            txtDiaChi = new TextBox();
            txtDiaChi.Location = new Point(220, 130);
            txtDiaChi.Size = new Size(310, 25);

            Label lblSoTien = new Label();
            lblSoTien.Text = "Số tiền trong tài khoản";
            lblSoTien.Location = new Point(35, 160);
            lblSoTien.Size = new Size(175, 25);
            lblSoTien.TextAlign = ContentAlignment.MiddleRight;

            txtSoTien = new TextBox();
            txtSoTien.Location = new Point(220, 160);
            txtSoTien.Size = new Size(310, 25);

            // Cac nut chuc nang
            btnThem = new Button();
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(220, 195);
            btnThem.Size = new Size(65, 30);
            btnThem.Click += BtnThem_Click;

            btnLuu = new Button();
            btnLuu.Text = "Lưu";
            btnLuu.Location = new Point(295, 195);
            btnLuu.Size = new Size(65, 30);
            btnLuu.Enabled = false;
            btnLuu.Click += BtnLuu_Click;

            btnXoa = new Button();
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(370, 195);
            btnXoa.Size = new Size(65, 30);
            btnXoa.Enabled = false;
            btnXoa.Click += BtnXoa_Click;

            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(445, 195);
            btnThoat.Size = new Size(85, 30);
            btnThoat.Click += BtnThoat_Click;

            // ListView tai khoan
            lvTaiKhoan = new ListView();
            lvTaiKhoan.Location = new Point(25, 235);
            lvTaiKhoan.Size = new Size(625, 175);
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.MultiSelect = false;

            lvTaiKhoan.Columns.Add("STT", 55);
            lvTaiKhoan.Columns.Add("Số tài khoản", 125);
            lvTaiKhoan.Columns.Add("Tên khách hàng", 130);
            lvTaiKhoan.Columns.Add("Địa chỉ", 120);
            lvTaiKhoan.Columns.Add("Số tiền", 150);

            lvTaiKhoan.SelectedIndexChanged += LvTaiKhoan_SelectedIndexChanged;

            // Tong tien
            Label lblTongTien = new Label();
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.Location = new Point(370, 420);
            lblTongTien.Size = new Size(90, 25);
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;

            txtTongTien = new TextBox();
            txtTongTien.Location = new Point(465, 420);
            txtTongTien.Size = new Size(185, 25);
            txtTongTien.ReadOnly = true;
            txtTongTien.TextAlign = HorizontalAlignment.Right;

            this.Controls.Add(lblTieuDe);
            this.Controls.Add(lblSoTK);
            this.Controls.Add(txtSoTaiKhoan);
            this.Controls.Add(lblTen);
            this.Controls.Add(txtTenKhachHang);
            this.Controls.Add(lblDiaChi);
            this.Controls.Add(txtDiaChi);
            this.Controls.Add(lblSoTien);
            this.Controls.Add(txtSoTien);
            this.Controls.Add(btnThem);
            this.Controls.Add(btnLuu);
            this.Controls.Add(btnXoa);
            this.Controls.Add(btnThoat);
            this.Controls.Add(lvTaiKhoan);
            this.Controls.Add(lblTongTien);
            this.Controls.Add(txtTongTien);
        }

        // Chuyen chuoi tien thanh so
        private bool DocSoTien(string chuoi, out decimal soTien)
        {
            chuoi = chuoi.Trim().Replace(",", "").Replace(".", "");

            return decimal.TryParse(
                chuoi,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out soTien
            ) && soTien >= 0;
        }

        // Nut Them chuyen sang che do nhap moi
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!dangThem)
            {
                dangThem = true;
                viTriDangSua = -1;

                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;

                lvTaiKhoan.SelectedItems.Clear();
                XoaTrang();

                txtSoTaiKhoan.Focus();
            }
            else
            {
                // Huy them moi
                dangThem = false;
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;

                XoaTrang();
            }
        }

        // Luu tai khoan vao ListView
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoTaiKhoan.Text.Trim() == "" ||
                txtTenKhachHang.Text.Trim() == "" ||
                txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            decimal soTien;

            if (!DocSoTien(txtSoTien.Text, out soTien))
            {
                MessageBox.Show("Số tiền phải là số không âm!");
                txtSoTien.Focus();
                return;
            }

            string soTK = txtSoTaiKhoan.Text.Trim();

            // Khong cho trung so tai khoan
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == soTK)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại!");
                    txtSoTaiKhoan.Focus();
                    return;
                }
            }

            ListViewItem dong = new ListViewItem("");
            dong.SubItems.Add(soTK);
            dong.SubItems.Add(txtTenKhachHang.Text.Trim());
            dong.SubItems.Add(txtDiaChi.Text.Trim());
            dong.SubItems.Add(soTien.ToString("#,##0"));

            lvTaiKhoan.Items.Add(dong);

            dangThem = false;
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;

            XoaTrang();
            CapNhatSTT();
            CapNhatTongTien();
        }

        // Chon tai khoan de hien thi len cac TextBox
        private void LvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                if (!dangThem)
                    btnXoa.Enabled = false;

                return;
            }

            ListViewItem dong = lvTaiKhoan.SelectedItems[0];

            if (!dangThem)
            {
                txtSoTaiKhoan.Text = dong.SubItems[1].Text;
                txtTenKhachHang.Text = dong.SubItems[2].Text;
                txtDiaChi.Text = dong.SubItems[3].Text;
                txtSoTien.Text = dong.SubItems[4].Text.Replace(",", "");

                txtSoTaiKhoan.ReadOnly = true;
                btnXoa.Enabled = true;
            }
        }

        // Xoa tai khoan dang chon
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
                return;

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài khoản này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                lvTaiKhoan.SelectedItems[0].Remove();

                XoaTrang();
                CapNhatSTT();
                CapNhatTongTien();
                btnXoa.Enabled = false;
            }
        }

        // Cap nhat lai STT
        private void CapNhatSTT()
        {
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                lvTaiKhoan.Items[i].Text = (i + 1).ToString();
            }
        }

        // Tinh tong tien tai khoan
        private void CapNhatTongTien()
        {
            decimal tong = 0;

            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                decimal soTien;

                if (DocSoTien(item.SubItems[4].Text, out soTien))
                    tong += soTien;
            }

            txtTongTien.Text = tong.ToString("#,##0");
        }

        // Xoa trang cac o nhap
        private void XoaTrang()
        {
            txtSoTaiKhoan.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();

            txtSoTaiKhoan.ReadOnly = false;
            lvTaiKhoan.SelectedItems.Clear();

            btnXoa.Enabled = false;
        }

        // Dong chuong trinh
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xac nhan truoc khi thoat
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            base.OnFormClosing(e);
        }
    }
}