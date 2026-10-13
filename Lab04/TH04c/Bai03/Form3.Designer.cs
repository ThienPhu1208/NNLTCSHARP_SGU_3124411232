namespace Bai03
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblUCLN;
        private System.Windows.Forms.Label lblBCNN;

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.TextBox txtBCNN;

        private System.Windows.Forms.Button btnThucHien;
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

            this.lblA =
                new System.Windows.Forms.Label();

            this.lblB =
                new System.Windows.Forms.Label();

            this.lblUCLN =
                new System.Windows.Forms.Label();

            this.lblBCNN =
                new System.Windows.Forms.Label();

            this.txtA =
                new System.Windows.Forms.TextBox();

            this.txtB =
                new System.Windows.Forms.TextBox();

            this.txtUCLN =
                new System.Windows.Forms.TextBox();

            this.txtBCNN =
                new System.Windows.Forms.TextBox();

            this.btnThucHien =
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
                new System.Drawing.Point(75, 25);

            this.lblTieuDe.Text =
                "Ước Số Chung - Bội Số Chung";

            // lblA
            this.lblA.AutoSize = true;

            this.lblA.Location =
                new System.Drawing.Point(75, 75);

            this.lblA.Text =
                "Nhập số a :";

            // lblB
            this.lblB.AutoSize = true;

            this.lblB.Location =
                new System.Drawing.Point(75, 112);

            this.lblB.Text =
                "Nhập số b :";

            // lblUCLN
            this.lblUCLN.AutoSize = true;

            this.lblUCLN.Location =
                new System.Drawing.Point(30, 149);

            this.lblUCLN.Text =
                "Ước số chung lớn nhất :";

            // lblBCNN
            this.lblBCNN.AutoSize = true;

            this.lblBCNN.Location =
                new System.Drawing.Point(45, 186);

            this.lblBCNN.Text =
                "Bội số chung nhỏ nhất :";

            // txtA
            this.txtA.Location =
                new System.Drawing.Point(210, 72);

            this.txtA.Name =
                "txtA";

            this.txtA.Size =
                new System.Drawing.Size(150, 23);

            this.txtA.TabIndex = 0;

            this.txtA.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtA_KeyPress
                );

            // txtB
            this.txtB.Location =
                new System.Drawing.Point(210, 109);

            this.txtB.Name =
                "txtB";

            this.txtB.Size =
                new System.Drawing.Size(150, 23);

            this.txtB.TabIndex = 1;

            this.txtB.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtB_KeyPress
                );

            // txtUCLN
            this.txtUCLN.Location =
                new System.Drawing.Point(210, 146);

            this.txtUCLN.Name =
                "txtUCLN";

            this.txtUCLN.ReadOnly = true;

            this.txtUCLN.Size =
                new System.Drawing.Size(80, 23);

            this.txtUCLN.TabIndex = 2;

            // txtBCNN
            this.txtBCNN.Location =
                new System.Drawing.Point(210, 183);

            this.txtBCNN.Name =
                "txtBCNN";

            this.txtBCNN.ReadOnly = true;

            this.txtBCNN.Size =
                new System.Drawing.Size(80, 23);

            this.txtBCNN.TabIndex = 3;

            // btnThucHien
            this.btnThucHien.Location =
                new System.Drawing.Point(30, 225);

            this.btnThucHien.Name =
                "btnThucHien";

            this.btnThucHien.Size =
                new System.Drawing.Size(100, 35);

            this.btnThucHien.Text =
                "Thực Hiện";

            this.btnThucHien.UseVisualStyleBackColor = true;

            this.btnThucHien.Click +=
                new System.EventHandler(
                    this.btnThucHien_Click
                );

            // btnTiepTuc
            this.btnTiepTuc.Location =
                new System.Drawing.Point(145, 225);

            this.btnTiepTuc.Name =
                "btnTiepTuc";

            this.btnTiepTuc.Size =
                new System.Drawing.Size(100, 35);

            this.btnTiepTuc.Text =
                "Tiếp Tục";

            this.btnTiepTuc.UseVisualStyleBackColor = true;

            this.btnTiepTuc.Click +=
                new System.EventHandler(
                    this.btnTiepTuc_Click
                );

            // btnThoat
            this.btnThoat.Location =
                new System.Drawing.Point(260, 225);

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

            // Form3
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(400, 300);

            this.Controls.Add(
                this.btnThoat
            );

            this.Controls.Add(
                this.btnTiepTuc
            );

            this.Controls.Add(
                this.btnThucHien
            );

            this.Controls.Add(
                this.txtBCNN
            );

            this.Controls.Add(
                this.txtUCLN
            );

            this.Controls.Add(
                this.txtB
            );

            this.Controls.Add(
                this.txtA
            );

            this.Controls.Add(
                this.lblBCNN
            );

            this.Controls.Add(
                this.lblUCLN
            );

            this.Controls.Add(
                this.lblB
            );

            this.Controls.Add(
                this.lblA
            );

            this.Controls.Add(
                this.lblTieuDe
            );

            this.Name =
                "Form3";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Ước Số - Bội Số";

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form3_FormClosing
                );

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}