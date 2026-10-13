
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH05d
{
    public class Bai01 : Form
    {
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private RadioButton radNam;
        private RadioButton radNu;
        private CheckBox chkAnh;
        private CheckBox chkPhap;
        private CheckBox chkHoa;
        private ComboBox cboDanToc;
        private ListView lvSinhVien;

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;

        private ContextMenuStrip menuChuotPhai;

        // Kiem tra dang sua sinh vien hay khong
        private bool dangSua = false;

        public Bai01()
        {
            InitializeComponent();
            NapDanToc();
        }

        private void InitializeComponent()
        {
            this.Text = "frmBaitap1";
            this.Size = new Size(700, 570);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Ho va ten
            Label lblHoTen = new Label();
            lblHoTen.Text = "Họ và Tên";
            lblHoTen.Location = new Point(65, 25);
            lblHoTen.Size = new Size(100, 25);

            txtHoTen = new TextBox();
            txtHoTen.Location = new Point(200, 22);
            txtHoTen.Size = new Size(250, 25);

            // Ma sinh vien
            Label lblMaSV = new Label();
            lblMaSV.Text = "Mã sinh viên";
            lblMaSV.Location = new Point(65, 60);
            lblMaSV.Size = new Size(110, 25);

            txtMaSV = new TextBox();
            txtMaSV.Location = new Point(200, 57);
            txtMaSV.Size = new Size(250, 25);

            // Gioi tinh
            Label lblGioiTinh = new Label();
            lblGioiTinh.Text = "Giới tính";
            lblGioiTinh.Location = new Point(65, 95);
            lblGioiTinh.Size = new Size(100, 25);

            radNam = new RadioButton();
            radNam.Text = "Nam";
            radNam.Location = new Point(200, 94);
            radNam.Size = new Size(70, 25);
            radNam.Checked = true;

            radNu = new RadioButton();
            radNu.Text = "Nữ";
            radNu.Location = new Point(280, 94);
            radNu.Size = new Size(70, 25);

            // Ngoai ngu
            Label lblNgoaiNgu = new Label();
            lblNgoaiNgu.Text = "Ngoại ngữ";
            lblNgoaiNgu.Location = new Point(65, 130);
            lblNgoaiNgu.Size = new Size(100, 25);

            chkAnh = new CheckBox();
            chkAnh.Text = "Anh";
            chkAnh.Location = new Point(200, 129);
            chkAnh.Size = new Size(65, 25);

            chkPhap = new CheckBox();
            chkPhap.Text = "Pháp";
            chkPhap.Location = new Point(275, 129);
            chkPhap.Size = new Size(70, 25);

            chkHoa = new CheckBox();
            chkHoa.Text = "Hoa";
            chkHoa.Location = new Point(355, 129);
            chkHoa.Size = new Size(65, 25);

            // Dan toc
            Label lblDanToc = new Label();
            lblDanToc.Text = "Dân tộc";
            lblDanToc.Location = new Point(65, 165);
            lblDanToc.Size = new Size(100, 25);

            cboDanToc = new ComboBox();
            cboDanToc.Location = new Point(200, 162);
            cboDanToc.Size = new Size(250, 25);
            cboDanToc.DropDownStyle = ComboBoxStyle.DropDownList;

            // ListView hien thi sinh vien
            lvSinhVien = new ListView();
            lvSinhVien.Location = new Point(30, 205);
            lvSinhVien.Size = new Size(625, 240);
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.MultiSelect = false;

            lvSinhVien.Columns.Add("Họ tên", 140);
            lvSinhVien.Columns.Add("Mã sinh viên", 125);
            lvSinhVien.Columns.Add("Giới tính", 95);
            lvSinhVien.Columns.Add("Ngoại ngữ", 145);
            lvSinhVien.Columns.Add("Dân tộc", 110);

            // Menu chuot phai
            menuChuotPhai = new ContextMenuStrip();

            ToolStripMenuItem itemXoa = new ToolStripMenuItem("Xóa sinh viên");
            itemXoa.Click += ItemXoa_Click;

            menuChuotPhai.Items.Add(itemXoa);
            lvSinhVien.ContextMenuStrip = menuChuotPhai;

            // Nut Them
            btnThem = new Button();
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(105, 465);
            btnThem.Size = new Size(125, 40);
            btnThem.Click += BtnThem_Click;

            // Nut Xoa
            btnXoa = new Button();
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(285, 465);
            btnXoa.Size = new Size(125, 40);
            btnXoa.Click += BtnXoa_Click;

            // Nut Sua
            btnSua = new Button();
            btnSua.Text = "Sửa";
            btnSua.Location = new Point(465, 465);
            btnSua.Size = new Size(125, 40);
            btnSua.Click += BtnSua_Click;

            // Chon sinh vien trong ListView de sua
            lvSinhVien.SelectedIndexChanged += LvSinhVien_SelectedIndexChanged;

            // Them dieu khien vao Form
            this.Controls.Add(lblHoTen);
            this.Controls.Add(txtHoTen);
            this.Controls.Add(lblMaSV);
            this.Controls.Add(txtMaSV);
            this.Controls.Add(lblGioiTinh);
            this.Controls.Add(radNam);
            this.Controls.Add(radNu);
            this.Controls.Add(lblNgoaiNgu);
            this.Controls.Add(chkAnh);
            this.Controls.Add(chkPhap);
            this.Controls.Add(chkHoa);
            this.Controls.Add(lblDanToc);
            this.Controls.Add(cboDanToc);
            this.Controls.Add(lvSinhVien);
            this.Controls.Add(btnThem);
            this.Controls.Add(btnXoa);
            this.Controls.Add(btnSua);

            this.FormClosing += Bai01_FormClosing;
        }

        // Nap danh sach dan toc khi khoi tao Form
        private void NapDanToc()
        {
            cboDanToc.Items.Clear();

            cboDanToc.Items.Add("Kinh");
            cboDanToc.Items.Add("Tày");
            cboDanToc.Items.Add("Thái");
            cboDanToc.Items.Add("Mường");
            cboDanToc.Items.Add("Khmer");
            cboDanToc.Items.Add("Hoa");
            cboDanToc.Items.Add("Nùng");
            cboDanToc.Items.Add("H'Mông");
            cboDanToc.Items.Add("Dao");
            cboDanToc.Items.Add("Gia Rai");
            cboDanToc.Items.Add("Ê Đê");
            cboDanToc.Items.Add("Ba Na");
            cboDanToc.Items.Add("Chăm");
            cboDanToc.Items.Add("Sán Dìu");
            cboDanToc.Items.Add("Khác");

            cboDanToc.SelectedIndex = 0;
        }

        // Lay danh sach ngoai ngu da chon
        private string LayNgoaiNgu()
        {
            string ngoaiNgu = "";

            if (chkAnh.Checked)
                ngoaiNgu += "Anh, ";

            if (chkPhap.Checked)
                ngoaiNgu += "Pháp, ";

            if (chkHoa.Checked)
                ngoaiNgu += "Hoa, ";

            if (ngoaiNgu.Length > 0)
                ngoaiNgu = ngoaiNgu.Substring(0, ngoaiNgu.Length - 2);

            return ngoaiNgu;
        }

        // Kiem tra thong tin nhap
        private bool KiemTraDuLieu()
        {
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                txtMaSV.Focus();
                return false;
            }

            if (cboDanToc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn dân tộc!");
                return false;
            }

            return true;
        }

        // Them sinh vien
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (dangSua)
            {
                MessageBox.Show("Bạn đang sửa sinh viên. Vui lòng hoàn tất sửa trước!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            string maSV = txtMaSV.Text.Trim();

            // Kiem tra trung ma sinh vien
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (string.Equals(
                    item.SubItems[1].Text,
                    maSV,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    txtMaSV.Focus();
                    return;
                }
            }

            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = LayNgoaiNgu();

            ListViewItem dong = new ListViewItem(txtHoTen.Text.Trim());
            dong.SubItems.Add(maSV);
            dong.SubItems.Add(gioiTinh);
            dong.SubItems.Add(ngoaiNgu);
            dong.SubItems.Add(cboDanToc.Text);

            lvSinhVien.Items.Add(dong);

            XoaTrang();
        }

        // Xoa sinh vien duoc chon
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVienDuocChon();
        }

        private void ItemXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVienDuocChon();
        }

        private void XoaSinhVienDuocChon()
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                lvSinhVien.SelectedItems[0].Remove();
                XoaTrang();
            }
        }

        // Chon sinh vien trong ListView de dua len cac o nhap
        private void LvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;

            ListViewItem dong = lvSinhVien.SelectedItems[0];

            txtHoTen.Text = dong.SubItems[0].Text;
            txtMaSV.Text = dong.SubItems[1].Text;
            txtMaSV.ReadOnly = true;

            radNam.Checked = dong.SubItems[2].Text == "Nam";
            radNu.Checked = dong.SubItems[2].Text == "Nữ";

            string ngoaiNgu = dong.SubItems[3].Text;

            chkAnh.Checked = ngoaiNgu.Contains("Anh");
            chkPhap.Checked = ngoaiNgu.Contains("Pháp");
            chkHoa.Checked = ngoaiNgu.Contains("Hoa");

            if (cboDanToc.Items.Contains(dong.SubItems[4].Text))
                cboDanToc.SelectedItem = dong.SubItems[4].Text;

            dangSua = true;
        }

        // Sua thong tin sinh vien, khong sua ma sinh vien
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            ListViewItem dong = lvSinhVien.SelectedItems[0];

            dong.SubItems[0].Text = txtHoTen.Text.Trim();
            // Khong thay doi SubItems[1] vi khong duoc sua ma sinh vien
            dong.SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
            dong.SubItems[3].Text = LayNgoaiNgu();
            dong.SubItems[4].Text = cboDanToc.Text;

            MessageBox.Show("Cập nhật thông tin sinh viên thành công!");

            XoaTrang();
        }

        // Xoa trang cac o nhap
        private void XoaTrang()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;

            radNam.Checked = true;
            radNu.Checked = false;

            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;

            if (cboDanToc.Items.Count > 0)
                cboDanToc.SelectedIndex = 0;

            lvSinhVien.SelectedItems.Clear();

            dangSua = false;
            txtHoTen.Focus();
        }

        // Xac nhan truoc khi dong Form
        private void Bai01_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.No)
                e.Cancel = true;
        }
    }
}