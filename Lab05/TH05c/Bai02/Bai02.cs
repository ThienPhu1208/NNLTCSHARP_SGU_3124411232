
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH05c
{
    public class Bai02 : Form
    {
        private TextBox txtN;
        private ListBox lstSo;
        private Button btnNhap;
        private Button btnTong;
        private Button btnXoaDauCuoi;
        private Button btnXoaChon;
        private Button btnTang2;
        private Button btnBinhPhuong;
        private Button btnSoChan;
        private Button btnSoLe;
        private Button btnKetThuc;

        private Random random = new Random();

        public Bai02()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "frmListbox";
            this.Size = new Size(650, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Tieu de
            Label lblTieuDe = new Label();
            lblTieuDe.Text = "LISTBOX";
            lblTieuDe.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkOrange;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Size = new Size(590, 55);

            // Khung ListBox
            GroupBox groupList = new GroupBox();
            groupList.Text = "Listbox";
            groupList.Location = new Point(25, 85);
            groupList.Size = new Size(200, 345);

            // O nhap N
            txtN = new TextBox();
            txtN.Location = new Point(10, 25);
            txtN.Size = new Size(160, 25);
            txtN.Text = "12";

            // Nut Nhap
            btnNhap = new Button();
            btnNhap.Text = "Nhập";
            btnNhap.Location = new Point(10, 60);
            btnNhap.Size = new Size(160, 35);
            btnNhap.Click += BtnNhap_Click;

            // Danh sach so
            lstSo = new ListBox();
            lstSo.Location = new Point(10, 105);
            lstSo.Size = new Size(160, 225);
            lstSo.SelectionMode = SelectionMode.MultiExtended;

            groupList.Controls.Add(txtN);
            groupList.Controls.Add(btnNhap);
            groupList.Controls.Add(lstSo);

            // Khung xu ly
            GroupBox groupXuLy = new GroupBox();
            groupXuLy.Text = "Xử Lý Listbox";
            groupXuLy.Location = new Point(245, 85);
            groupXuLy.Size = new Size(355, 345);

            // Nut tong
            btnTong = new Button();
            btnTong.Text = "Tổng các phần tử trong List";
            btnTong.Location = new Point(10, 20);
            btnTong.Size = new Size(325, 35);
            btnTong.Click += BtnTong_Click;

            // Nut xoa dau va cuoi
            btnXoaDauCuoi = new Button();
            btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            btnXoaDauCuoi.Location = new Point(10, 62);
            btnXoaDauCuoi.Size = new Size(325, 35);
            btnXoaDauCuoi.Click += BtnXoaDauCuoi_Click;

            // Nut xoa phan tu dang chon
            btnXoaChon = new Button();
            btnXoaChon.Text = "Xóa Phần tử đang chọn";
            btnXoaChon.Location = new Point(10, 104);
            btnXoaChon.Size = new Size(325, 35);
            btnXoaChon.Click += BtnXoaChon_Click;

            // Nut tang 2
            btnTang2 = new Button();
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.Location = new Point(10, 146);
            btnTang2.Size = new Size(325, 35);
            btnTang2.Click += BtnTang2_Click;

            // Nut binh phuong
            btnBinhPhuong = new Button();
            btnBinhPhuong.Text = "Thay bằng bình phương";
            btnBinhPhuong.Location = new Point(10, 188);
            btnBinhPhuong.Size = new Size(325, 35);
            btnBinhPhuong.Click += BtnBinhPhuong_Click;

            // Nut chon so chan
            btnSoChan = new Button();
            btnSoChan.Text = "Chọn số chẵn";
            btnSoChan.Location = new Point(10, 230);
            btnSoChan.Size = new Size(325, 35);
            btnSoChan.Click += BtnSoChan_Click;

            // Nut chon so le
            btnSoLe = new Button();
            btnSoLe.Text = "Chọn số lẻ";
            btnSoLe.Location = new Point(10, 272);
            btnSoLe.Size = new Size(325, 35);
            btnSoLe.Click += BtnSoLe_Click;

            groupXuLy.Controls.Add(btnTong);
            groupXuLy.Controls.Add(btnXoaDauCuoi);
            groupXuLy.Controls.Add(btnXoaChon);
            groupXuLy.Controls.Add(btnTang2);
            groupXuLy.Controls.Add(btnBinhPhuong);
            groupXuLy.Controls.Add(btnSoChan);
            groupXuLy.Controls.Add(btnSoLe);

            // Nut ket thuc
            btnKetThuc = new Button();
            btnKetThuc.Text = "KẾT THÚC";
            btnKetThuc.Location = new Point(35, 445);
            btnKetThuc.Size = new Size(565, 40);
            btnKetThuc.Click += BtnKetThuc_Click;

            this.Controls.Add(lblTieuDe);
            this.Controls.Add(groupList);
            this.Controls.Add(groupXuLy);
            this.Controls.Add(btnKetThuc);
        }

        // Nhap N phan tu ngau nhien vao ListBox
        private void BtnNhap_Click(object sender, EventArgs e)
        {
            int n;

            if (!int.TryParse(txtN.Text, out n) || n <= 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập N là số nguyên dương!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtN.Focus();
                return;
            }

            if (n > 1000)
            {
                MessageBox.Show("Vui lòng nhập N không lớn hơn 1000!");
                return;
            }

            lstSo.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                lstSo.Items.Add(random.Next(1, 101));
            }
        }

        // Tinh tong cac phan tu
        private void BtnTong_Click(object sender, EventArgs e)
        {
            long tong = 0;

            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                tong += Convert.ToInt32(lstSo.Items[i]);
            }

            MessageBox.Show(
                "Tổng các phần tử trong ListBox là: " + tong,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Xoa phan tu dau va cuoi
        private void BtnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("ListBox không có phần tử!");
                return;
            }

            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);

            if (lstSo.Items.Count > 0)
            {
                lstSo.Items.RemoveAt(0);
            }
        }

        // Xoa cac phan tu dang chon
        private void BtnXoaChon_Click(object sender, EventArgs e)
        {
            if (lstSo.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!");
                return;
            }

            for (int i = lstSo.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[i]);
            }
        }

        // Tang moi phan tu len 2
        private void BtnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = so + 2;
            }
        }

        // Binh phuong moi phan tu
        private void BtnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                long so = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = so * so;
            }
        }

        // Chon cac so chan
        private void BtnSoChan_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();

            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lstSo.Items[i]);

                if (so % 2 == 0)
                {
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // Chon cac so le
        private void BtnSoLe_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected();

            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int so = Convert.ToInt32(lstSo.Items[i]);

                if (so % 2 != 0)
                {
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // Ket thuc chuong trinh
        private void BtnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}