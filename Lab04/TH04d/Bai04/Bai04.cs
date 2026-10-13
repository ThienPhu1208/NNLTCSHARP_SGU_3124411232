
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH04d
{
    public class Bai04 : Form
    {
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtSoNgay;

        private RadioButton radPhongDon;
        private RadioButton radPhongDoi;
        private RadioButton radPhongBa;

        private CheckBox chkTivi;
        private CheckBox chkInternet;
        private CheckBox chkMayNuocNong;

        private CheckBox chkKaraoke;
        private CheckBox chkAnSang;

        private Label lblThanhTien;
        private Label lblTongLuot;
        private Label lblTongTien;

        private Button btnThanhToan;
        private Button btnNhapMoi;
        private Button btnTongKet;
        private Button btnThoat;

        private decimal tongTienTrongNgay = 0;
        private int tongLuotKhach = 0;

        private decimal tienKhachHienTai = 0;
        private bool daThanhToan = false;

        public Bai04()
        {
            InitializeComponent();
            DatTrangThaiBanDau();
        }

        private void InitializeComponent()
        {
            this.Text = "frmDangKyKS";
            this.Size = new Size(740, 430);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Tieu de
            Label lblTieuDe = new Label();
            lblTieuDe.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            lblTieuDe.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkOrange;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(10, 10);
            lblTieuDe.Size = new Size(700, 40);

            // Thong tin khach hang
            Label lblHoTen = new Label();
            lblHoTen.Text = "Họ và tên:";
            lblHoTen.Location = new Point(30, 70);
            lblHoTen.Size = new Size(90, 25);

            txtHoTen = new TextBox();
            txtHoTen.Location = new Point(125, 67);
            txtHoTen.Size = new Size(300, 25);
            txtHoTen.TextChanged += KiemTraThongTin;

            Label lblDiaChi = new Label();
            lblDiaChi.Text = "Địa chỉ:";
            lblDiaChi.Location = new Point(30, 105);
            lblDiaChi.Size = new Size(90, 25);

            txtDiaChi = new TextBox();
            txtDiaChi.Location = new Point(125, 102);
            txtDiaChi.Size = new Size(300, 25);
            txtDiaChi.TextChanged += KiemTraThongTin;

            Label lblSoNgay = new Label();
            lblSoNgay.Text = "Số ngày ở:";
            lblSoNgay.Location = new Point(30, 140);
            lblSoNgay.Size = new Size(90, 25);

            txtSoNgay = new TextBox();
            txtSoNgay.Location = new Point(125, 137);
            txtSoNgay.Size = new Size(80, 25);
            txtSoNgay.TextChanged += KiemTraThongTin;
            txtSoNgay.KeyPress += TxtSoNgay_KeyPress;

            // Nhom loai phong
            GroupBox groupPhong = new GroupBox();
            groupPhong.Text = "Loại phòng";
            groupPhong.Location = new Point(20, 175);
            groupPhong.Size = new Size(130, 140);

            radPhongDon = new RadioButton();
            radPhongDon.Text = "Phòng đơn";
            radPhongDon.Location = new Point(10, 25);
            radPhongDon.Size = new Size(110, 25);
            radPhongDon.CheckedChanged += KiemTraThongTin;

            radPhongDoi = new RadioButton();
            radPhongDoi.Text = "Phòng đôi";
            radPhongDoi.Location = new Point(10, 60);
            radPhongDoi.Size = new Size(110, 25);
            radPhongDoi.CheckedChanged += KiemTraThongTin;

            radPhongBa = new RadioButton();
            radPhongBa.Text = "Phòng ba";
            radPhongBa.Location = new Point(10, 95);
            radPhongBa.Size = new Size(110, 25);
            radPhongBa.CheckedChanged += KiemTraThongTin;

            groupPhong.Controls.Add(radPhongDon);
            groupPhong.Controls.Add(radPhongDoi);
            groupPhong.Controls.Add(radPhongBa);

            // Nhom tien nghi
            GroupBox groupTienNghi = new GroupBox();
            groupTienNghi.Text = "Tiện nghi";
            groupTienNghi.Location = new Point(160, 175);
            groupTienNghi.Size = new Size(150, 140);

            chkTivi = new CheckBox();
            chkTivi.Text = "Tivi";
            chkTivi.Location = new Point(10, 25);
            chkTivi.Size = new Size(120, 25);

            chkInternet = new CheckBox();
            chkInternet.Text = "Internet";
            chkInternet.Location = new Point(10, 60);
            chkInternet.Size = new Size(120, 25);

            chkMayNuocNong = new CheckBox();
            chkMayNuocNong.Text = "Máy nước nóng";
            chkMayNuocNong.Location = new Point(10, 95);
            chkMayNuocNong.Size = new Size(130, 25);

            groupTienNghi.Controls.Add(chkTivi);
            groupTienNghi.Controls.Add(chkInternet);
            groupTienNghi.Controls.Add(chkMayNuocNong);

            // Nhom dich vu
            GroupBox groupDichVu = new GroupBox();
            groupDichVu.Text = "Dịch vụ";
            groupDichVu.Location = new Point(320, 175);
            groupDichVu.Size = new Size(130, 140);

            chkKaraoke = new CheckBox();
            chkKaraoke.Text = "Karaoke";
            chkKaraoke.Location = new Point(10, 25);
            chkKaraoke.Size = new Size(110, 25);

            chkAnSang = new CheckBox();
            chkAnSang.Text = "Ăn sáng";
            chkAnSang.Location = new Point(10, 60);
            chkAnSang.Size = new Size(110, 25);

            groupDichVu.Controls.Add(chkKaraoke);
            groupDichVu.Controls.Add(chkAnSang);

            // Nut Thanh toan
            btnThanhToan = new Button();
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Location = new Point(465, 60);
            btnThanhToan.Size = new Size(110, 32);
            btnThanhToan.Click += BtnThanhToan_Click;

            // Nut Nhap moi
            btnNhapMoi = new Button();
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.Location = new Point(585, 60);
            btnNhapMoi.Size = new Size(110, 32);
            btnNhapMoi.Click += BtnNhapMoi_Click;

            // Thanh tien
            Label lblThanhTienText = new Label();
            lblThanhTienText.Text = "Thành tiền:";
            lblThanhTienText.Location = new Point(465, 100);
            lblThanhTienText.Size = new Size(90, 25);

            lblThanhTien = new Label();
            lblThanhTien.Text = "0 VNĐ";
            lblThanhTien.BorderStyle = BorderStyle.Fixed3D;
            lblThanhTien.TextAlign = ContentAlignment.MiddleLeft;
            lblThanhTien.Location = new Point(555, 97);
            lblThanhTien.Size = new Size(140, 28);

            // Nut Tong ket
            btnTongKet = new Button();
            btnTongKet.Text = "Tổng Kết";
            btnTongKet.Location = new Point(465, 140);
            btnTongKet.Size = new Size(110, 32);
            btnTongKet.Click += BtnTongKet_Click;

            // Thong tin tong ket
            Label lblThongTinTongKet = new Label();
            lblThongTinTongKet.Text = "Thông tin tổng kết";
            lblThongTinTongKet.Location = new Point(465, 180);
            lblThongTinTongKet.Size = new Size(180, 25);

            Label lblTongLuotText = new Label();
            lblTongLuotText.Text = "Số lượt người:";
            lblTongLuotText.Location = new Point(465, 210);
            lblTongLuotText.Size = new Size(100, 25);

            lblTongLuot = new Label();
            lblTongLuot.Text = "0";
            lblTongLuot.BorderStyle = BorderStyle.Fixed3D;
            lblTongLuot.TextAlign = ContentAlignment.MiddleLeft;
            lblTongLuot.Location = new Point(565, 207);
            lblTongLuot.Size = new Size(130, 28);

            Label lblTongTienText = new Label();
            lblTongTienText.Text = "Tổng số tiền:";
            lblTongTienText.Location = new Point(465, 245);
            lblTongTienText.Size = new Size(100, 25);

            lblTongTien = new Label();
            lblTongTien.Text = "0 VNĐ";
            lblTongTien.BorderStyle = BorderStyle.Fixed3D;
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            lblTongTien.Location = new Point(565, 242);
            lblTongTien.Size = new Size(130, 28);

            // Nut Thoat
            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(465, 285);
            btnThoat.Size = new Size(110, 32);
            btnThoat.Click += BtnThoat_Click;

            // Them cac control vao Form
            this.Controls.Add(lblTieuDe);
            this.Controls.Add(lblHoTen);
            this.Controls.Add(txtHoTen);
            this.Controls.Add(lblDiaChi);
            this.Controls.Add(txtDiaChi);
            this.Controls.Add(lblSoNgay);
            this.Controls.Add(txtSoNgay);
            this.Controls.Add(groupPhong);
            this.Controls.Add(groupTienNghi);
            this.Controls.Add(groupDichVu);
            this.Controls.Add(btnThanhToan);
            this.Controls.Add(btnNhapMoi);
            this.Controls.Add(lblThanhTienText);
            this.Controls.Add(lblThanhTien);
            this.Controls.Add(btnTongKet);
            this.Controls.Add(lblThongTinTongKet);
            this.Controls.Add(lblTongLuotText);
            this.Controls.Add(lblTongLuot);
            this.Controls.Add(lblTongTienText);
            this.Controls.Add(lblTongTien);
            this.Controls.Add(btnThoat);

            this.Load += Bai04_Load;
            this.FormClosing += Bai04_FormClosing;
        }

        // Trang thai ban dau
        private void Bai04_Load(object sender, EventArgs e)
        {
            DatTrangThaiBanDau();
        }

        private void DatTrangThaiBanDau()
        {
            btnTongKet.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnThanhToan.Enabled = false;

            txtHoTen.Focus();
        }

        // Chi cho nhap so ngay
        private void TxtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Kiem tra da nhap du thong tin chua
        private void KiemTraThongTin(object sender, EventArgs e)
        {
            int soNgay;

            bool hopLe =
                txtHoTen.Text.Trim() != "" &&
                txtDiaChi.Text.Trim() != "" &&
                int.TryParse(txtSoNgay.Text, out soNgay) &&
                soNgay > 0 &&
                (radPhongDon.Checked || radPhongDoi.Checked || radPhongBa.Checked);

            btnThanhToan.Enabled = hopLe && !daThanhToan;
        }

        // Tinh tien phong va dich vu
        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            int soNgay = int.Parse(txtSoNgay.Text);

            decimal giaPhongMoiNgay = 0;

            if (radPhongDon.Checked)
                giaPhongMoiNgay = 300000;
            else if (radPhongDoi.Checked)
                giaPhongMoiNgay = 350000;
            else if (radPhongBa.Checked)
                giaPhongMoiNgay = 400000;

            decimal tien = giaPhongMoiNgay * soNgay;

            // Moi tien nghi cong them 10.000 dong
            if (chkTivi.Checked)
                tien += 10000;

            if (chkInternet.Checked)
                tien += 10000;

            if (chkMayNuocNong.Checked)
                tien += 10000;

            // Karaoke tinh mot lan
            if (chkKaraoke.Checked)
                tien += 50000;

            // An sang tinh theo so ngay o
            if (chkAnSang.Checked)
                tien += 15000 * soNgay;

            tienKhachHienTai = tien;
            tongTienTrongNgay += tien;
            tongLuotKhach++;

            lblThanhTien.Text = tien.ToString("#,##0") + " VNĐ";

            daThanhToan = true;
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = true;
            btnTongKet.Enabled = true;
        }

        // Khoi tao lai de nhap khach moi
        private void BtnNhapMoi_Click(object sender, EventArgs e)
        {
            XoaThongTin();

            daThanhToan = false;

            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = tongLuotKhach > 0;

            txtHoTen.Focus();
        }

        // Hien thi tong ket va dat bo dem ve 0
        private void BtnTongKet_Click(object sender, EventArgs e)
        {
            lblTongLuot.Text = tongLuotKhach.ToString();
            lblTongTien.Text = tongTienTrongNgay.ToString("#,##0") + " VNĐ";

            tongLuotKhach = 0;
            tongTienTrongNgay = 0;

            btnTongKet.Enabled = false;
        }

        // Xoa thong tin khach hien tai
        private void XoaThongTin()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgay.Clear();

            radPhongDon.Checked = false;
            radPhongDoi.Checked = false;
            radPhongBa.Checked = false;

            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            lblThanhTien.Text = "0 VNĐ";
            tienKhachHienTai = 0;

            KiemTraThongTin(null, EventArgs.Empty);
        }

        // Thoat chuong trinh
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xac nhan truoc khi thoat
        private void Bai04_FormClosing(object sender, FormClosingEventArgs e)
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
