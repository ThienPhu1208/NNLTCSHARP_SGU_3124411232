namespace Bai05
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNhapSo;

        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtKetQua;

        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnXoa;
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

            this.txtNhapSo =
                new System.Windows.Forms.TextBox();

            this.txtKetQua =
                new System.Windows.Forms.TextBox();

            this.btnThucHien =
                new System.Windows.Forms.Button();

            this.btnXoa =
                new System.Windows.Forms.Button();

            this.btnThoat =
                new System.Windows.Forms.Button();

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
                new System.Drawing.Point(80, 20);

            this.lblTieuDe.Text =
                "Đọc Số Thành Chữ";

            // lblNhapSo
            this.lblNhapSo.AutoSize = true;

            this.lblNhapSo.Location =
                new System.Drawing.Point(30, 75);

            this.lblNhapSo.Text =
                "Nhập dãy số : (từ 1 đến 999)";

            // txtNhapSo
            this.txtNhapSo.Location =
                new System.Drawing.Point(285, 72);

            this.txtNhapSo.Name =
                "txtNhapSo";

            this.txtNhapSo.Size =
                new System.Drawing.Size(80, 23);

            this.txtNhapSo.TabIndex = 0;

            this.txtNhapSo.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtNhapSo_KeyPress
                );

            // btnThucHien
            this.btnThucHien.Location =
                new System.Drawing.Point(30, 115);

            this.btnThucHien.Name =
                "btnThucHien";

            this.btnThucHien.Size =
                new System.Drawing.Size(90, 35);

            this.btnThucHien.Text =
                "Thực hiện";

            this.btnThucHien.UseVisualStyleBackColor = true;

            this.btnThucHien.Click +=
                new System.EventHandler(
                    this.btnThucHien_Click
                );

            // btnXoa
            this.btnXoa.Location =
                new System.Drawing.Point(140, 115);

            this.btnXoa.Name =
                "btnXoa";

            this.btnXoa.Size =
                new System.Drawing.Size(90, 35);

            this.btnXoa.Text =
                "Xóa";

            this.btnXoa.UseVisualStyleBackColor = true;

            this.btnXoa.Click +=
                new System.EventHandler(
                    this.btnXoa_Click
                );

            // btnThoat
            this.btnThoat.Location =
                new System.Drawing.Point(250, 115);

            this.btnThoat.Name =
                "btnThoat";

            this.btnThoat.Size =
                new System.Drawing.Size(90, 35);

            this.btnThoat.Text =
                "Thoát";

            this.btnThoat.UseVisualStyleBackColor = true;

            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click
                );

            // txtKetQua
            this.txtKetQua.BackColor =
                System.Drawing.Color.MistyRose;

            this.txtKetQua.Location =
                new System.Drawing.Point(30, 165);

            this.txtKetQua.Name =
                "txtKetQua";

            this.txtKetQua.ReadOnly = true;

            this.txtKetQua.Size =
                new System.Drawing.Size(345, 23);

            this.txtKetQua.TabIndex = 1;

            // Form5
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(405, 215);

            this.Controls.Add(
                this.txtKetQua
            );

            this.Controls.Add(
                this.btnThoat
            );

            this.Controls.Add(
                this.btnXoa
            );

            this.Controls.Add(
                this.btnThucHien
            );

            this.Controls.Add(
                this.txtNhapSo
            );

            this.Controls.Add(
                this.lblNhapSo
            );

            this.Controls.Add(
                this.lblTieuDe
            );

            this.Name =
                "Form5";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Tâm Gà - Đọc Chữ Số";

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form5_FormClosing
                );

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}