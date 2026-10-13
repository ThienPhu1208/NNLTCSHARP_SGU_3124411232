namespace Bai02
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhau;

        private System.Windows.Forms.Label lblSao1;
        private System.Windows.Forms.Label lblSao2;
        private System.Windows.Forms.Label lblSao3;

        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;

        private System.Windows.Forms.Button btnDangKy;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.lblTieuDe =
                new System.Windows.Forms.Label();

            this.lblTenDangNhap =
                new System.Windows.Forms.Label();

            this.lblEmail =
                new System.Windows.Forms.Label();

            this.lblMatKhau =
                new System.Windows.Forms.Label();

            this.lblXacNhanMatKhau =
                new System.Windows.Forms.Label();

            this.lblSao1 =
                new System.Windows.Forms.Label();

            this.lblSao2 =
                new System.Windows.Forms.Label();

            this.lblSao3 =
                new System.Windows.Forms.Label();

            this.txtTenDangNhap =
                new System.Windows.Forms.TextBox();

            this.txtEmail =
                new System.Windows.Forms.TextBox();

            this.txtMatKhau =
                new System.Windows.Forms.TextBox();

            this.txtXacNhanMatKhau =
                new System.Windows.Forms.TextBox();

            this.btnDangKy =
                new System.Windows.Forms.Button();

            this.errorProvider1 =
                new System.Windows.Forms.ErrorProvider(
                    this.components
                );

            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider1)).BeginInit();

            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;

            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Arial",
                    16F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.DodgerBlue;

            this.lblTieuDe.Location =
                new System.Drawing.Point(125, 20);

            this.lblTieuDe.Text =
                "Đăng ký tài khoản";

            // lblTenDangNhap
            this.lblTenDangNhap.AutoSize = true;

            this.lblTenDangNhap.Location =
                new System.Drawing.Point(30, 70);

            this.lblTenDangNhap.Text =
                "Tên đăng nhập";

            // lblEmail
            this.lblEmail.AutoSize = true;

            this.lblEmail.Location =
                new System.Drawing.Point(30, 105);

            this.lblEmail.Text =
                "Địa chỉ email";

            // lblMatKhau
            this.lblMatKhau.AutoSize = true;

            this.lblMatKhau.Location =
                new System.Drawing.Point(30, 140);

            this.lblMatKhau.Text =
                "Mật khẩu";

            // lblXacNhanMatKhau
            this.lblXacNhanMatKhau.AutoSize = true;

            this.lblXacNhanMatKhau.Location =
                new System.Drawing.Point(30, 175);

            this.lblXacNhanMatKhau.Text =
                "Xác nhận mật khẩu";

            // lblSao1
            this.lblSao1.AutoSize = true;

            this.lblSao1.ForeColor =
                System.Drawing.Color.Red;

            this.lblSao1.Location =
                new System.Drawing.Point(130, 70);

            this.lblSao1.Text = "(*)";

            // lblSao2
            this.lblSao2.AutoSize = true;

            this.lblSao2.ForeColor =
                System.Drawing.Color.Red;

            this.lblSao2.Location =
                new System.Drawing.Point(130, 105);

            this.lblSao2.Text = "(*)";

            // lblSao3
            this.lblSao3.AutoSize = true;

            this.lblSao3.ForeColor =
                System.Drawing.Color.Red;

            this.lblSao3.Location =
                new System.Drawing.Point(130, 140);

            this.lblSao3.Text = "(*)";

            // txtTenDangNhap
            this.txtTenDangNhap.Location =
                new System.Drawing.Point(145, 67);

            this.txtTenDangNhap.Name =
                "txtTenDangNhap";

            this.txtTenDangNhap.Size =
                new System.Drawing.Size(220, 23);

            this.txtTenDangNhap.TabIndex = 0;

            // txtEmail
            this.txtEmail.Location =
                new System.Drawing.Point(145, 102);

            this.txtEmail.Name =
                "txtEmail";

            this.txtEmail.Size =
                new System.Drawing.Size(220, 23);

            this.txtEmail.TabIndex = 1;

            this.txtEmail.Leave +=
                new System.EventHandler(
                    this.txtEmail_Leave
                );

            // txtMatKhau
            this.txtMatKhau.Location =
                new System.Drawing.Point(145, 137);

            this.txtMatKhau.Name =
                "txtMatKhau";

            this.txtMatKhau.Size =
                new System.Drawing.Size(220, 23);

            this.txtMatKhau.TabIndex = 2;

            this.txtMatKhau.UseSystemPasswordChar = true;

            // txtXacNhanMatKhau
            this.txtXacNhanMatKhau.Location =
                new System.Drawing.Point(145, 172);

            this.txtXacNhanMatKhau.Name =
                "txtXacNhanMatKhau";

            this.txtXacNhanMatKhau.Size =
                new System.Drawing.Size(220, 23);

            this.txtXacNhanMatKhau.TabIndex = 3;

            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;

            this.txtXacNhanMatKhau.KeyDown +=
                new System.Windows.Forms.KeyEventHandler(
                    this.txtXacNhanMatKhau_KeyDown
                );

            // btnDangKy
            this.btnDangKy.Location =
                new System.Drawing.Point(145, 215);

            this.btnDangKy.Name =
                "btnDangKy";

            this.btnDangKy.Size =
                new System.Drawing.Size(220, 40);

            this.btnDangKy.Text =
                "Đăng ký";

            this.btnDangKy.UseVisualStyleBackColor = true;

            this.btnDangKy.Click +=
                new System.EventHandler(
                    this.btnDangKy_Click
                );

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // Form2
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(420, 285);

            this.Controls.Add(
                this.btnDangKy
            );

            this.Controls.Add(
                this.txtXacNhanMatKhau
            );

            this.Controls.Add(
                this.txtMatKhau
            );

            this.Controls.Add(
                this.txtEmail
            );

            this.Controls.Add(
                this.txtTenDangNhap
            );

            this.Controls.Add(
                this.lblXacNhanMatKhau
            );

            this.Controls.Add(
                this.lblMatKhau
            );

            this.Controls.Add(
                this.lblEmail
            );

            this.Controls.Add(
                this.lblTenDangNhap
            );

            this.Controls.Add(
                this.lblSao3
            );

            this.Controls.Add(
                this.lblSao2
            );

            this.Controls.Add(
                this.lblSao1
            );

            this.Controls.Add(
                this.lblTieuDe
            );

            this.Name =
                "Form2";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Đăng ký tài khoản";

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form2_FormClosing
                );

            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}