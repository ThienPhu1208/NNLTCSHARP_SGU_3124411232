
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TH05c
{
    public class Bai01 : Form
    {
        // Luu tu dien Anh - Viet
        private List<string> danhSachAnh = new List<string>()
        {
            "student", "teacher", "worker", "hat",
            "head", "mouse", "cat", "dog",
            "snake", "lamb", "loan", "frog", "sheep"
        };

        private Dictionary<string, string> tuDienAnh = new Dictionary<string, string>()
        {
            { "student", "Sinh viên, học sinh" },
            { "teacher", "Giáo viên" },
            { "worker", "Công nhân, người lao động" },
            { "hat", "Cái mũ" },
            { "head", "Cái đầu" },
            { "mouse", "Con chuột" },
            { "cat", "Con mèo" },
            { "dog", "Con chó" },
            { "snake", "Con rắn" },
            { "lamb", "Thịt cừu non, con cừu non" },
            { "loan", "Khoản vay" },
            { "frog", "Con ếch" },
            { "sheep", "Con cừu" }
        };

        // Luu tu dien Viet - Anh
        private List<string> danhSachViet = new List<string>()
        {
            "Cái đầu", "Cái mũ", "Cái chuột", "Con chó",
            "Con cừu", "Con ếch", "Con mèo", "Con rắn",
            "Công nhân", "Giáo viên", "Khoản vay",
            "Sinh viên", "Thịt cừu non"
        };

        private Dictionary<string, string> tuDienViet = new Dictionary<string, string>()
        {
            { "Cái đầu", "head" },
            { "Cái mũ", "hat" },
            { "Cái chuột", "mouse" },
            { "Con chó", "dog" },
            { "Con cừu", "sheep" },
            { "Con ếch", "frog" },
            { "Con mèo", "cat" },
            { "Con rắn", "snake" },
            { "Công nhân", "worker" },
            { "Giáo viên", "teacher" },
            { "Khoản vay", "loan" },
            { "Sinh viên", "student" },
            { "Thịt cừu non", "lamb" }
        };

        private TabControl tabControl;
        private ComboBox cboAnh;
        private ComboBox cboViet;
        private ListBox lstAnh;
        private ListBox lstViet;
        private TextBox txtNghiaAnh;
        private TextBox txtNghiaViet;
        private Button btnThoat;

        public Bai01()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.Size = new Size(650, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            tabControl = new TabControl();
            tabControl.Location = new Point(20, 20);
            tabControl.Size = new Size(590, 355);

            TabPage tabAnh = new TabPage("ANH - VIỆT");
            TabPage tabViet = new TabPage("VIỆT - ANH");

            tabControl.TabPages.Add(tabAnh);
            tabControl.TabPages.Add(tabViet);

            // Tab Anh - Viet
            Label lblAnh = new Label();
            lblAnh.Text = "Tiếng Anh";
            lblAnh.Location = new Point(15, 15);
            lblAnh.AutoSize = true;

            Label lblVietNghia = new Label();
            lblVietNghia.Text = "Tiếng Việt";
            lblVietNghia.Location = new Point(300, 15);
            lblVietNghia.AutoSize = true;

            cboAnh = new ComboBox();
            cboAnh.Location = new Point(15, 40);
            cboAnh.Size = new Size(230, 25);
            cboAnh.DropDownStyle = ComboBoxStyle.DropDown;
            cboAnh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboAnh.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboAnh.KeyDown += CboAnh_KeyDown;
            cboAnh.KeyUp += CboAnh_KeyUp;

            lstAnh = new ListBox();
            lstAnh.Location = new Point(15, 75);
            lstAnh.Size = new Size(230, 220);
            lstAnh.DoubleClick += LstAnh_DoubleClick;
            lstAnh.KeyDown += LstAnh_KeyDown;

            txtNghiaAnh = new TextBox();
            txtNghiaAnh.Location = new Point(300, 40);
            txtNghiaAnh.Size = new Size(250, 255);
            txtNghiaAnh.Multiline = true;
            txtNghiaAnh.ReadOnly = true;
            txtNghiaAnh.ScrollBars = ScrollBars.Vertical;

            tabAnh.Controls.Add(lblAnh);
            tabAnh.Controls.Add(lblVietNghia);
            tabAnh.Controls.Add(cboAnh);
            tabAnh.Controls.Add(lstAnh);
            tabAnh.Controls.Add(txtNghiaAnh);

            // Tab Viet - Anh
            Label lblViet = new Label();
            lblViet.Text = "Tiếng Việt";
            lblViet.Location = new Point(15, 15);
            lblViet.AutoSize = true;

            Label lblAnhNghia = new Label();
            lblAnhNghia.Text = "Tiếng Anh";
            lblAnhNghia.Location = new Point(300, 15);
            lblAnhNghia.AutoSize = true;

            cboViet = new ComboBox();
            cboViet.Location = new Point(15, 40);
            cboViet.Size = new Size(230, 25);
            cboViet.DropDownStyle = ComboBoxStyle.DropDown;
            cboViet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboViet.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboViet.KeyDown += CboViet_KeyDown;
            cboViet.KeyUp += CboViet_KeyUp;

            lstViet = new ListBox();
            lstViet.Location = new Point(15, 75);
            lstViet.Size = new Size(230, 220);
            lstViet.DoubleClick += LstViet_DoubleClick;
            lstViet.KeyDown += LstViet_KeyDown;

            txtNghiaViet = new TextBox();
            txtNghiaViet.Location = new Point(300, 40);
            txtNghiaViet.Size = new Size(250, 255);
            txtNghiaViet.Multiline = true;
            txtNghiaViet.ReadOnly = true;
            txtNghiaViet.ScrollBars = ScrollBars.Vertical;

            tabViet.Controls.Add(lblViet);
            tabViet.Controls.Add(lblAnhNghia);
            tabViet.Controls.Add(cboViet);
            tabViet.Controls.Add(lstViet);
            tabViet.Controls.Add(txtNghiaViet);

            // Nut thoat
            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(490, 385);
            btnThoat.Size = new Size(120, 35);
            btnThoat.Click += BtnThoat_Click;

            this.Controls.Add(tabControl);
            this.Controls.Add(btnThoat);

            // Nap danh sach tu
            foreach (string tu in danhSachAnh)
            {
                cboAnh.Items.Add(tu);
                lstAnh.Items.Add(tu);
            }

            foreach (string tu in danhSachViet)
            {
                cboViet.Items.Add(tu);
                lstViet.Items.Add(tu);
            }
        }

        // Tra tu Anh - Viet khi nhan Enter
        private void CboAnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraTuAnh();
                e.SuppressKeyPress = true;
            }
        }

        // Tra tu Anh - Viet khi chon tu trong danh sach
        private void CboAnh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                string tuNhap = cboAnh.Text.Trim();

                if (tuNhap == "")
                {
                    lstAnh.ClearSelected();
                    return;
                }

                for (int i = 0; i < lstAnh.Items.Count; i++)
                {
                    if (lstAnh.Items[i].ToString().StartsWith(
                        tuNhap, StringComparison.OrdinalIgnoreCase))
                    {
                        lstAnh.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void TraTuAnh()
        {
            string tu = cboAnh.Text.Trim().ToLower();

            if (tuDienAnh.ContainsKey(tu))
            {
                txtNghiaAnh.Text = tuDienAnh[tu];
                cboAnh.Text = tu;
            }
            else
            {
                txtNghiaAnh.Text = "Không tìm thấy từ này.";
            }
        }

        private void LstAnh_DoubleClick(object sender, EventArgs e)
        {
            if (lstAnh.SelectedItem != null)
            {
                cboAnh.Text = lstAnh.SelectedItem.ToString();
                TraTuAnh();
            }
        }

        private void LstAnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstAnh.SelectedItem != null)
                {
                    cboAnh.Text = lstAnh.SelectedItem.ToString();
                    TraTuAnh();
                }
            }
        }

        // Tra tu Viet - Anh khi nhan Enter
        private void CboViet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraTuViet();
                e.SuppressKeyPress = true;
            }
        }

        private void CboViet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                string tuNhap = cboViet.Text.Trim();

                if (tuNhap == "")
                {
                    lstViet.ClearSelected();
                    return;
                }

                for (int i = 0; i < lstViet.Items.Count; i++)
                {
                    if (lstViet.Items[i].ToString().StartsWith(
                        tuNhap, StringComparison.CurrentCultureIgnoreCase))
                    {
                        lstViet.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void TraTuViet()
        {
            string tu = cboViet.Text.Trim();

            foreach (KeyValuePair<string, string> item in tuDienViet)
            {
                if (string.Equals(
                    item.Key, tu, StringComparison.CurrentCultureIgnoreCase))
                {
                    txtNghiaViet.Text = item.Value;
                    return;
                }
            }

            txtNghiaViet.Text = "Không tìm thấy từ này.";
        }

        private void LstViet_DoubleClick(object sender, EventArgs e)
        {
            if (lstViet.SelectedItem != null)
            {
                cboViet.Text = lstViet.SelectedItem.ToString();
                TraTuViet();
            }
        }

        private void LstViet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstViet.SelectedItem != null)
                {
                    cboViet.Text = lstViet.SelectedItem.ToString();
                    TraTuViet();
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}