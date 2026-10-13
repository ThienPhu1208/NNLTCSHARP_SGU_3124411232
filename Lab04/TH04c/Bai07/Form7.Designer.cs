namespace Bai07
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtManHinh;

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;

        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;

        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnC;

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;

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

            this.txtManHinh =
                new System.Windows.Forms.TextBox();

            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();

            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();

            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();

            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;

            this.lblTieuDe.Font =
                new System.Drawing.Font(
                    "Arial",
                    18F,
                    System.Drawing.FontStyle.Bold
                );

            this.lblTieuDe.ForeColor =
                System.Drawing.Color.Red;

            this.lblTieuDe.Location =
                new System.Drawing.Point(70, 15);

            this.lblTieuDe.Text =
                "Máy Tính Bỏ Túi";

            // txtManHinh
            this.txtManHinh.Font =
                new System.Drawing.Font(
                    "Arial",
                    14F
                );

            this.txtManHinh.Location =
                new System.Drawing.Point(25, 60);

            this.txtManHinh.Name =
                "txtManHinh";

            this.txtManHinh.ReadOnly = true;

            this.txtManHinh.Size =
                new System.Drawing.Size(280, 29);

            this.txtManHinh.TabIndex = 0;

            this.txtManHinh.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // btn1
            this.btn1.Location =
                new System.Drawing.Point(30, 105);

            this.btn1.Size =
                new System.Drawing.Size(55, 40);

            this.btn1.Text = "1";

            this.btn1.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn2
            this.btn2.Location =
                new System.Drawing.Point(95, 105);

            this.btn2.Size =
                new System.Drawing.Size(55, 40);

            this.btn2.Text = "2";

            this.btn2.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn3
            this.btn3.Location =
                new System.Drawing.Point(160, 105);

            this.btn3.Size =
                new System.Drawing.Size(55, 40);

            this.btn3.Text = "3";

            this.btn3.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn4
            this.btn4.Location =
                new System.Drawing.Point(225, 105);

            this.btn4.Size =
                new System.Drawing.Size(55, 40);

            this.btn4.Text = "4";

            this.btn4.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn5
            this.btn5.Location =
                new System.Drawing.Point(30, 155);

            this.btn5.Size =
                new System.Drawing.Size(55, 40);

            this.btn5.Text = "5";

            this.btn5.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn6
            this.btn6.Location =
                new System.Drawing.Point(95, 155);

            this.btn6.Size =
                new System.Drawing.Size(55, 40);

            this.btn6.Text = "6";

            this.btn6.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn7
            this.btn7.Location =
                new System.Drawing.Point(160, 155);

            this.btn7.Size =
                new System.Drawing.Size(55, 40);

            this.btn7.Text = "7";

            this.btn7.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn8
            this.btn8.Location =
                new System.Drawing.Point(225, 155);

            this.btn8.Size =
                new System.Drawing.Size(55, 40);

            this.btn8.Text = "8";

            this.btn8.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn9
            this.btn9.Location =
                new System.Drawing.Point(30, 205);

            this.btn9.Size =
                new System.Drawing.Size(55, 40);

            this.btn9.Text = "9";

            this.btn9.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btn0
            this.btn0.Location =
                new System.Drawing.Point(95, 205);

            this.btn0.Size =
                new System.Drawing.Size(55, 40);

            this.btn0.Text = "0";

            this.btn0.Click +=
                new System.EventHandler(
                    this.btnSo_Click
                );

            // btnBang
            this.btnBang.Location =
                new System.Drawing.Point(160, 205);

            this.btnBang.Size =
                new System.Drawing.Size(55, 40);

            this.btnBang.Text = "=";

            this.btnBang.Click +=
                new System.EventHandler(
                    this.btnBang_Click
                );

            // btnC
            this.btnC.Location =
                new System.Drawing.Point(225, 205);

            this.btnC.Size =
                new System.Drawing.Size(55, 40);

            this.btnC.Text = "C";

            this.btnC.Click +=
                new System.EventHandler(
                    this.btnXoa_Click
                );

            // btnCong
            this.btnCong.Location =
                new System.Drawing.Point(30, 255);

            this.btnCong.Size =
                new System.Drawing.Size(55, 40);

            this.btnCong.Text = "+";

            this.btnCong.Click +=
                new System.EventHandler(
                    this.btnPhepTinh_Click
                );

            // btnTru
            this.btnTru.Location =
                new System.Drawing.Point(95, 255);

            this.btnTru.Size =
                new System.Drawing.Size(55, 40);

            this.btnTru.Text = "-";

            this.btnTru.Click +=
                new System.EventHandler(
                    this.btnPhepTinh_Click
                );

            // btnNhan
            this.btnNhan.Location =
                new System.Drawing.Point(160, 255);

            this.btnNhan.Size =
                new System.Drawing.Size(55, 40);

            this.btnNhan.Text = "*";

            this.btnNhan.Click +=
                new System.EventHandler(
                    this.btnPhepTinh_Click
                );

            // btnChia
            this.btnChia.Location =
                new System.Drawing.Point(225, 255);

            this.btnChia.Size =
                new System.Drawing.Size(55, 40);

            this.btnChia.Text = "/";

            this.btnChia.Click +=
                new System.EventHandler(
                    this.btnPhepTinh_Click
                );

            // Form7
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(330, 320);

            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);

            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);

            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);

            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);

            this.Controls.Add(this.txtManHinh);
            this.Controls.Add(this.lblTieuDe);

            this.Name =
                "Form7";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Máy Tính Bỏ Túi";

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form7_FormClosing
                );

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}