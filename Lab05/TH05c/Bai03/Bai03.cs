
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH05c
{
    public class Bai03 : Form
    {
        private TreeView treeDanhBa;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAdd;
        private Button btnExit;

        public Bai03()
        {
            InitializeComponent();
            TaoDanhSachChuCai();
        }

        private void InitializeComponent()
        {
            this.Text = "frmBTVN2";
            this.Size = new Size(650, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // TreeView hien thi danh ba
            treeDanhBa = new TreeView();
            treeDanhBa.Location = new Point(20, 20);
            treeDanhBa.Size = new Size(250, 400);
            treeDanhBa.Font = new Font("Times New Roman", 13);
            treeDanhBa.HideSelection = false;

            // Khung nhap thong tin
            GroupBox groupNhap = new GroupBox();
            groupNhap.Text = "Thông tin danh bạ";
            groupNhap.Location = new Point(285, 35);
            groupNhap.Size = new Size(320, 190);

            // First Name
            Label lblFirstName = new Label();
            lblFirstName.Text = "First Name";
            lblFirstName.Location = new Point(15, 35);
            lblFirstName.Size = new Size(105, 25);

            txtFirstName = new TextBox();
            txtFirstName.Location = new Point(135, 30);
            txtFirstName.Size = new Size(160, 25);

            // Last Name
            Label lblLastName = new Label();
            lblLastName.Text = "Last Name";
            lblLastName.Location = new Point(15, 85);
            lblLastName.Size = new Size(105, 25);

            txtLastName = new TextBox();
            txtLastName.Location = new Point(135, 80);
            txtLastName.Size = new Size(160, 25);

            // Nut Add
            btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Location = new Point(215, 125);
            btnAdd.Size = new Size(80, 32);
            btnAdd.Click += BtnAdd_Click;

            groupNhap.Controls.Add(lblFirstName);
            groupNhap.Controls.Add(txtFirstName);
            groupNhap.Controls.Add(lblLastName);
            groupNhap.Controls.Add(txtLastName);
            groupNhap.Controls.Add(btnAdd);

            // Nut Exit
            btnExit = new Button();
            btnExit.Text = "Exit";
            btnExit.Location = new Point(505, 240);
            btnExit.Size = new Size(100, 35);
            btnExit.Click += BtnExit_Click;

            this.Controls.Add(treeDanhBa);
            this.Controls.Add(groupNhap);
            this.Controls.Add(btnExit);
        }

        // Tao cac node chu cai tu A den Z khi form duoc khoi tao
        private void TaoDanhSachChuCai()
        {
            treeDanhBa.Nodes.Clear();

            for (char kyTu = 'A'; kyTu <= 'Z'; kyTu++)
            {
                TreeNode node = new TreeNode(kyTu.ToString());
                treeDanhBa.Nodes.Add(node);
            }

            treeDanhBa.ExpandAll();
        }

        // Them nguoi vao node theo chu cai dau cua First Name
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (firstName == "" || lastName == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ First Name và Last Name!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            char kyTuDau = char.ToUpper(firstName[0]);

            if (kyTuDau < 'A' || kyTuDau > 'Z')
            {
                MessageBox.Show(
                    "Ký tự đầu của First Name phải từ A đến Z!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Tim node chu cai tuong ung
            TreeNode nodeCha = null;

            foreach (TreeNode node in treeDanhBa.Nodes)
            {
                if (node.Text == kyTuDau.ToString())
                {
                    nodeCha = node;
                    break;
                }
            }

            if (nodeCha != null)
            {
                // Tao node con hien thi ho va ten
                string hoTen = firstName + ", " + lastName;

                TreeNode nodeCon = new TreeNode(hoTen);
                nodeCha.Nodes.Add(nodeCon);

                // Mo node chu cai vua them
                nodeCha.Expand();

                // Chon node vua them
                treeDanhBa.SelectedNode = nodeCon;

                // Xoa noi dung nhap sau khi them
                txtFirstName.Clear();
                txtLastName.Clear();
                txtFirstName.Focus();
            }
        }

        // Dong chuong trinh
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}