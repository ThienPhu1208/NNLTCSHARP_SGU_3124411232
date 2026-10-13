
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH04d
{
    public class Bai03 : Form
    {
        private TextBox txtTenKhachHang;
        private TextBox txtSoKhachHang;
        private TextBox txtTongKhachHang;
        private TextBox txtTongTien;

        private CheckBox chkSinhVien;

        private RadioButton radCafeDen;
        private RadioButton radCafeDa;
        private RadioButton radCafeSua;
        private RadioButton radCafeSuaDa;
        private RadioButton radCafeKem;

        private CheckBox chkBanhMiTrung;
        private CheckBox chkBanhMiCa;
        private CheckBox chkMyTomTrung;
        private CheckBox chkMyXaoBo;
        private CheckBox chkMyCay;

        private Button btnTinhTien;
        private Button btnNhapLai;
        private Button btnThanhToan;
        private Button btnThoat;

        private decimal tienCanThanhToan = 0;
        private int tongSoKhach = 0;

        public Bai03()
        {
            InitializeComponent();
            DatTrangThaiBanDau();
        }

        private void InitializeComponent()
        {
            this.Text = "Thanh toán tiền";
            this.Size = new Size(550, 570);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Tieu de
            Label lblTieuDe = new Label();
            lblTieuDe.Text = "CAFE SINH VIÊN";
            lblTieuDe.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkOrange;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(50, 15);
            lblTieuDe.Size = new Size(430, 35);

            // Ten khach hang
            Label lblTen = new Label();
            lblTen.Text = "Tên khách hàng";
            lblTen.Location = new Point(30, 65);
            lblTen.Size = new Size(140, 25);

            txtTenKhachHang = new TextBox();
            txtTenKhachHang.Location = new Point(175, 62);
            txtTenKhachHang.Size = new Size(300, 25);
            txtTenKhachHang.TextChanged += KiemTraThongTin;

            // So khach hang
            Label lblSoKhach = new Label();
            lblSoKhach.Text = "Số khách hàng";
            lblSoKhach.Location = new Point(30, 95);
            lblSoKhach.Size = new Size(140, 25);

            txtSoKhachHang = new TextBox();
            txtSoKhachHang.Location = new Point(175, 92);
            txtSoKhachHang.Size = new Size(300, 25);
            txtSoKhachHang.TextChanged += KiemTraThongTin;
            txtSoKhachHang.KeyPress += TxtSoKhachHang_KeyPress;

            // Sinh vien
            chkSinhVien = new CheckBox();
            chkSinhVien.Text = "Sinh viên?";
            chkSinhVien.Location = new Point(175, 125);
            chkSinhVien.Size = new Size(120, 25);

            // Nhom nuoc uong
            GroupBox groupNuoc = new GroupBox();
            groupNuoc.Text = "Nước uống";
            groupNuoc.Location = new Point(20, 155);
            groupNuoc.Size = new Size(220, 150);

            radCafeDen = new RadioButton();
            radCafeDen.Text = "Cafe đen";
            radCafeDen.Location = new Point(12, 25);
            radCafeDen.Size = new Size(100, 25);
            radCafeDen.CheckedChanged += KiemTraThongTin;

            radCafeDa = new RadioButton();
            radCafeDa.Text = "Cafe đá";
            radCafeDa.Location = new Point(120, 25);
            radCafeDa.Size = new Size(90, 25);
            radCafeDa.CheckedChanged += KiemTraThongTin;

            radCafeSua = new RadioButton();
            radCafeSua.Text = "Cafe sữa";
            radCafeSua.Location = new Point(12, 55);
            radCafeSua.Size = new Size(100, 25);
            radCafeSua.CheckedChanged += KiemTraThongTin;

            radCafeKem = new RadioButton();
            radCafeKem.Text = "Cafe kem";
            radCafeKem.Location = new Point(120, 55);
            radCafeKem.Size = new Size(90, 25);
            radCafeKem.CheckedChanged += KiemTraThongTin;

            radCafeSuaDa = new RadioButton();
            radCafeSuaDa.Text = "Cafe sữa đá";
            radCafeSuaDa.Location = new Point(12, 85);
            radCafeSuaDa.Size = new Size(120, 25);
            radCafeSuaDa.CheckedChanged += KiemTraThongTin;

            groupNuoc.Controls.Add(radCafeDen);
            groupNuoc.Controls.Add(radCafeDa);
            groupNuoc.Controls.Add(radCafeSua);
            groupNuoc.Controls.Add(radCafeKem);
            groupNuoc.Controls.Add(radCafeSuaDa);

            // Nhom thuc an
            GroupBox groupThucAn = new GroupBox();
            groupThucAn.Text = "Thức ăn";
            groupThucAn.Location = new Point(250, 155);
            groupThucAn.Size = new Size(260, 150);

            chkBanhMiTrung = new CheckBox();
            chkBanhMiTrung.Text = "Bánh mỳ trứng";
            chkBanhMiTrung.Location = new Point(12, 25);
            chkBanhMiTrung.Size = new Size(125, 25);

            chkMyXaoBo = new CheckBox();
            chkMyXaoBo.Text = "Mỳ xào bò";
            chkMyXaoBo.Location = new Point(140, 25);
            chkMyXaoBo.Size = new Size(110, 25);

            chkBanhMiCa = new CheckBox();
            chkBanhMiCa.Text = "Bánh mỳ cá";
            chkBanhMiCa.Location = new Point(12, 55);
            chkBanhMiCa.Size = new Size(125, 25);

            chkMyCay = new CheckBox();
            chkMyCay.Text = "Mỳ cay";
            chkMyCay.Location = new Point(140, 55);
            chkMyCay.Size = new Size(100, 25);

            chkMyTomTrung = new CheckBox();
            chkMyTomTrung.Text = "Mỳ tôm trứng";
            chkMyTomTrung.Location = new Point(12, 85);
            chkMyTomTrung.Size = new Size(130, 25);

            groupThucAn.Controls.Add(chkBanhMiTrung);
            groupThucAn.Controls.Add(chkBanhMiCa);
            groupThucAn.Controls.Add(chkMyTomTrung);
            groupThucAn.Controls.Add(chkMyXaoBo);
            groupThucAn.Controls.Add(chkMyCay);

            // Cac nut chuc nang
            btnTinhTien = new Button();
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.Location = new Point(35, 320);
            btnTinhTien.Size = new Size(105, 40);
            btnTinhTien.Click += BtnTinhTien_Click;

            btnNhapLai = new Button();
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.Location = new Point(150, 320);
            btnNhapLai.Size = new Size(105, 40);
            btnNhapLai.Click += BtnNhapLai_Click;

            btnThanhToan = new Button();
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Location = new Point(265, 320);
            btnThanhToan.Size = new Size(105, 40);
            btnThanhToan.Click += BtnThanhToan_Click;

            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(380, 320);
            btnThoat.Size = new Size(105, 40);
            btnThoat.Click += BtnThoat_Click;

            // Tong so khach hang
            Label lblTongKhach = new Label();
            lblTongKhach.Text = "Tổng khách hàng";
            lblTongKhach.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTongKhach.Location = new Point(30, 385);
            lblTongKhach.Size = new Size(180, 25);

            txtTongKhachHang = new TextBox();
            txtTongKhachHang.Location = new Point(220, 382);
            txtTongKhachHang.Size = new Size(265, 25);
            txtTongKhachHang.ReadOnly = true;

            // Tong tien thanh toan
            Label lblTongTien = new Label();
            lblTongTien.Text = "Tổng tiền thanh toán";
            lblTongTien.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTongTien.Location = new Point(30, 420);
            lblTongTien.Size = new Size(185, 25);

            txtTongTien = new TextBox();
            txtTongTien.Location = new Point(220, 417);
            txtTongTien.Size = new Size(265, 25);
            txtTongTien.ReadOnly = true;

            this.Controls.Add(lblTieuDe);
            this.Controls.Add(lblTen);
            this.Controls.Add(txtTenKhachHang);
            this.Controls.Add(lblSoKhach);
            this.Controls.Add(txtSoKhachHang);
            this.Controls.Add(chkSinhVien);
            this.Controls.Add(groupNuoc);
            this.Controls.Add(groupThucAn);
            this.Controls.Add(btnTinhTien);
            this.Controls.Add(btnNhapLai);
            this.Controls.Add(btnThanhToan);
            this.Controls.Add(btnThoat);
            this.Controls.Add(lblTongKhach);
            this.Controls.Add(txtTongKhachHang);
            this.Controls.Add(lblTongTien);
            this.Controls.Add(txtTongTien);

            this.Load += Bai03_Load;
            this.FormClosing += Bai03_FormClosing;
        }

        // Trang thai ban dau khi mo Form
        private void Bai03_Load(object sender, EventArgs e)
        {
            DatTrangThaiBanDau();
        }

        private void DatTrangThaiBanDau()
        {
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            txtTenKhachHang.Focus();
        }

        // Chi cho phep nhap chu so va phim dieu khien
        private void TxtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Kiem tra thong tin da du de tinh tien chua
        private void KiemTraThongTin(object sender, EventArgs e)
        {
            int soKhach;

            bool hopLe =
                txtTenKhachHang.Text.Trim() != "" &&
                int.TryParse(txtSoKhachHang.Text, out soKhach) &&
                soKhach > 0 &&
                (radCafeDen.Checked ||
                 radCafeDa.Checked ||
                 radCafeSua.Checked ||
                 radCafeSuaDa.Checked ||
                 radCafeKem.Checked);

            btnTinhTien.Enabled = hopLe;
        }

        // Tinh tien theo mon da chon
        private void BtnTinhTien_Click(object sender, EventArgs e)
        {
            int soKhach = int.Parse(txtSoKhachHang.Text);
            decimal donGia = 0;

            if (radCafeDen.Checked) donGia += 20000;
            if (radCafeDa.Checked) donGia += 25000;
            if (radCafeSua.Checked) donGia += 25000;
            if (radCafeSuaDa.Checked) donGia += 30000;
            if (radCafeKem.Checked) donGia += 35000;

            if (chkBanhMiTrung.Checked) donGia += 15000;
            if (chkBanhMiCa.Checked) donGia += 15000;
            if (chkMyTomTrung.Checked) donGia += 20000;
            if (chkMyXaoBo.Checked) donGia += 30000;
            if (chkMyCay.Checked) donGia += 50000;

            if (donGia == 0)
            {
                MessageBox.Show("Vui lòng chọn nước uống hoặc thức ăn!");
                return;
            }

            decimal tongTien = donGia * soKhach;

            if (chkSinhVien.Checked)
                tongTien = tongTien * 0.8m;

            tienCanThanhToan = tongTien;

            MessageBox.Show(
                "Tên khách hàng: " + txtTenKhachHang.Text.Trim() +
                "\nSố khách hàng: " + soKhach +
                "\nTổng tiền: " + tongTien.ToString("#,##0") + " đ",
                "Thanh toán tiền",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            btnNhapLai.Enabled = true;
            btnThanhToan.Enabled = true;
            btnTinhTien.Enabled = false;
        }

        // Nhap lai thong tin nhom khach hang
        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            XoaThongTinNhap();

            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            txtTenKhachHang.Focus();
        }

        // Thanh toan va cap nhat tong so khach, tong tien
        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            int soKhach = int.Parse(txtSoKhachHang.Text);

            tongSoKhach += soKhach;
            tienTongCong += tienCanThanhToan;

            txtTongKhachHang.Text = tongSoKhach.ToString();
            txtTongTien.Text = tienTongCong.ToString("#,##0") + " đ";

            XoaThongTinNhap();

            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            txtTenKhachHang.Focus();
        }

        private decimal tienTongCong = 0;

        // Xoa cac thong tin dang nhap
        private void XoaThongTinNhap()
        {
            txtTenKhachHang.Clear();
            txtSoKhachHang.Clear();

            chkSinhVien.Checked = false;

            radCafeDen.Checked = false;
            radCafeDa.Checked = false;
            radCafeSua.Checked = false;
            radCafeSuaDa.Checked = false;
            radCafeKem.Checked = false;

            chkBanhMiTrung.Checked = false;
            chkBanhMiCa.Checked = false;
            chkMyTomTrung.Checked = false;
            chkMyXaoBo.Checked = false;
            chkMyCay.Checked = false;

            tienCanThanhToan = 0;
        }

        // Thoat chuong trinh
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hoi xac nhan truoc khi dong Form
        private void Bai03_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.No)
                e.Cancel = true;
        }
    }
}