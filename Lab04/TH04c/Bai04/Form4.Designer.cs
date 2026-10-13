namespace Bai04
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.Label lblDayVuaNhap;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.Label lblTongLe;

        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtDayVuaNhap;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTongLe;

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnTongChan;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;

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

            this.lblNhapSo =
                new System.Windows.Forms.Label();

            this.lblDayVuaNhap =
                new System.Windows.Forms.Label();

            this.lblTong =
                new System.Windows.Forms.Label();

            this.lblTongChan =
                new System.Windows.Forms.Label();

            this.lblTongLe =
                new System.Windows.Forms.Label();

            this.txtNhapSo =
                new System.Windows.Forms.TextBox();

            this.txtDayVuaNhap =
                new System.Windows.Forms.TextBox();

            this.txtTong =
                new System.Windows.Forms.TextBox();

            this.txtTongChan =
                new System.Windows.Forms.TextBox();

            this.txtTongLe =
                new System.Windows.Forms.TextBox();

            this.btnNhap =
                new System.Windows.Forms.Button();

            this.btnTinhTong =
                new System.Windows.Forms.Button();

            this.btnTongChan =
                new System.Windows.Forms.Button();

            this.btnTongLe =
                new System.Windows.Forms.Button();

            this.btnTiepTuc =
                new System.Windows.Forms.Button();

            this.btnThoat =
                new System.Windows.Forms.Button();

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
                System.Drawing.Color.Red;

            this.lblTieuDe.Location =
                new System.Drawing.Point(45, 20);

            this.lblTieuDe.Text =
                "Nhập Dãy Số và Tính Tổng";

            // lblNhapSo
            this.lblNhapSo.AutoSize = true;

            this.lblNhapSo.Location =
                new System.Drawing.Point(35, 75);

            this.lblNhapSo.Text =
                "Nhập số :";

            // lblDayVuaNhap
            this.lblDayVuaNhap.AutoSize = true;

            this.lblDayVuaNhap.Location =
                new System.Drawing.Point(35, 115);

            this.lblDayVuaNhap.Text =
                "Dãy vừa nhập :";

            // lblTong
            this.lblTong.AutoSize = true;

            this.lblTong.Location =
                new System.Drawing.Point(35, 155);

            this.lblTong.Text =
                "Tổng các phần tử trong dãy :";

            // lblTongChan
            this.lblTongChan.AutoSize = true;

            this.lblTongChan.Location =
                new System.Drawing.Point(35, 195);

            this.lblTongChan.Text =
                "Tổng chẵn :";

            // lblTongLe
            this.lblTongLe.AutoSize = true;

            this.lblTongLe.Location =
                new System.Drawing.Point(210, 195);

            this.lblTongLe.Text =
                "Tổng lẻ :";

            // txtNhapSo
            this.txtNhapSo.Location =
                new System.Drawing.Point(150, 72);

            this.txtNhapSo.Name =
                "txtNhapSo";

            this.txtNhapSo.Size =
                new System.Drawing.Size(80, 23);

            this.txtNhapSo.TabIndex = 0;

            this.txtNhapSo.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtNhapSo_KeyPress
                );

            // txtDayVuaNhap
            this.txtDayVuaNhap.Location =
                new System.Drawing.Point(150, 112);

            this.txtDayVuaNhap.Name =
                "txtDayVuaNhap";

            this.txtDayVuaNhap.ReadOnly = true;

            this.txtDayVuaNhap.Size =
                new System.Drawing.Size(245, 23);

            this.txtDayVuaNhap.TabIndex = 1;

            // txtTong
            this.txtTong.Location =
                new System.Drawing.Point(220, 152);

            this.txtTong.Name =
                "txtTong";

            this.txtTong.ReadOnly = true;

            this.txtTong.Size =
                new System.Drawing.Size(80, 23);

            this.txtTong.TabIndex = 2;

            // txtTongChan
            this.txtTongChan.Location =
                new System.Drawing.Point(105, 192);

            this.txtTongChan.Name =
                "txtTongChan";

            this.txtTongChan.ReadOnly = true;

            this.txtTongChan.Size =
                new System.Drawing.Size(80, 23);

            this.txtTongChan.TabIndex = 3;

            // txtTongLe
            this.txtTongLe.Location =
                new System.Drawing.Point(275, 192);

            this.txtTongLe.Name =
                "txtTongLe";

            this.txtTongLe.ReadOnly = true;

            this.txtTongLe.Size =
                new System.Drawing.Size(80, 23);

            this.txtTongLe.TabIndex = 4;

            // btnNhap
            this.btnNhap.Location =
                new System.Drawing.Point(250, 70);

            this.btnNhap.Name =
                "btnNhap";

            this.btnNhap.Size =
                new System.Drawing.Size(100, 30);

            this.btnNhap.Text =
                "Nhập";

            this.btnNhap.UseVisualStyleBackColor = true;

            this.btnNhap.Click +=
                new System.EventHandler(
                    this.btnNhap_Click
                );

            // btnTinhTong
            this.btnTinhTong.Location =
                new System.Drawing.Point(35, 235);

            this.btnTinhTong.Name =
                "btnTinhTong";

            this.btnTinhTong.Size =
                new System.Drawing.Size(100, 32);

            this.btnTinhTong.Text =
                "Tính tổng";

            this.btnTinhTong.UseVisualStyleBackColor = true;

            this.btnTinhTong.Click +=
                new System.EventHandler(
                    this.btnTinhTong_Click
                );

            // btnTongChan
            this.btnTongChan.Location =
                new System.Drawing.Point(145, 235);

            this.btnTongChan.Name =
                "btnTongChan";

            this.btnTongChan.Size =
                new System.Drawing.Size(100, 32);

            this.btnTongChan.Text =
                "Tổng chẵn";

            this.btnTongChan.UseVisualStyleBackColor = true;

            this.btnTongChan.Click +=
                new System.EventHandler(
                    this.btnTongChan_Click
                );

            // btnTongLe
            this.btnTongLe.Location =
                new System.Drawing.Point(255, 235);

            this.btnTongLe.Name =
                "btnTongLe";

            this.btnTongLe.Size =
                new System.Drawing.Size(100, 32);

            this.btnTongLe.Text =
                "Tổng lẻ";

            this.btnTongLe.UseVisualStyleBackColor = true;

            this.btnTongLe.Click +=
                new System.EventHandler(
                    this.btnTongLe_Click
                );

            // btnTiepTuc
            this.btnTiepTuc.Location =
                new System.Drawing.Point(90, 280);

            this.btnTiepTuc.Name =
                "btnTiepTuc";

            this.btnTiepTuc.Size =
                new System.Drawing.Size(100, 35);

            this.btnTiepTuc.Text =
                "Tiếp tục";

            this.btnTiepTuc.UseVisualStyleBackColor = true;

            this.btnTiepTuc.Click +=
                new System.EventHandler(
                    this.btnTiepTuc_Click
                );

            // btnThoat
            this.btnThoat.Location =
                new System.Drawing.Point(210, 280);

            this.btnThoat.Name =
                "btnThoat";

            this.btnThoat.Size =
                new System.Drawing.Size(100, 35);

            this.btnThoat.Text =
                "Thoát";

            this.btnThoat.UseVisualStyleBackColor = true;

            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click
                );

            // Form4
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(420, 340);

            this.Controls.Add(
                this.btnThoat
            );

            this.Controls.Add(
                this.btnTiepTuc
            );

            this.Controls.Add(
                this.btnTongLe
            );

            this.Controls.Add(
                this.btnTongChan
            );

            this.Controls.Add(
                this.btnTinhTong
            );

            this.Controls.Add(
                this.btnNhap
            );

            this.Controls.Add(
                this.txtTongLe
            );

            this.Controls.Add(
                this.txtTongChan
            );

            this.Controls.Add(
                this.txtTong
            );

            this.Controls.Add(
                this.txtDayVuaNhap
            );

            this.Controls.Add(
                this.txtNhapSo
            );

            this.Controls.Add(
                this.lblTongLe
            );

            this.Controls.Add(
                this.lblTongChan
            );

            this.Controls.Add(
                this.lblTong
            );

            this.Controls.Add(
                this.lblDayVuaNhap
            );

            this.Controls.Add(
                this.lblNhapSo
            );

            this.Controls.Add(
                this.lblTieuDe
            );

            this.Name =
                "Form4";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Dãy số và Tính Tổng";

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form4_FormClosing
                );

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}