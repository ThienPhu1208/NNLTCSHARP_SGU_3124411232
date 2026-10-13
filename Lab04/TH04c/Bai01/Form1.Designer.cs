namespace Bai01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;

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

            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();

            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();

            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();

            this.errorProvider1 =
                new System.Windows.Forms.ErrorProvider(
                    this.components
                );

            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider1)).BeginInit();

            this.SuspendLayout();

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location =
                new System.Drawing.Point(35, 32);
            this.lblA.Name = "lblA";
            this.lblA.Size =
                new System.Drawing.Size(29, 15);
            this.lblA.Text = "a =";

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location =
                new System.Drawing.Point(245, 32);
            this.lblB.Name = "lblB";
            this.lblB.Size =
                new System.Drawing.Size(29, 15);
            this.lblB.Text = "b =";

            // lblKetQua
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location =
                new System.Drawing.Point(35, 75);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size =
                new System.Drawing.Size(49, 15);
            this.lblKetQua.Text = "Kết quả";

            // txtA
            this.txtA.Location =
                new System.Drawing.Point(70, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size =
                new System.Drawing.Size(110, 23);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtA_KeyPress
                );

            // txtB
            this.txtB.Location =
                new System.Drawing.Point(280, 25);
            this.txtB.Name = "txtB";
            this.txtB.Size =
                new System.Drawing.Size(110, 23);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtB_KeyPress
                );

            // txtKetQua
            this.txtKetQua.Location =
                new System.Drawing.Point(90, 70);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size =
                new System.Drawing.Size(300, 23);
            this.txtKetQua.TabIndex = 2;

            // btnCong
            this.btnCong.Location =
                new System.Drawing.Point(40, 115);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size =
                new System.Drawing.Size(75, 35);
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click +=
                new System.EventHandler(
                    this.btnCong_Click
                );

            // btnTru
            this.btnTru.Location =
                new System.Drawing.Point(135, 115);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size =
                new System.Drawing.Size(75, 35);
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click +=
                new System.EventHandler(
                    this.btnTru_Click
                );

            // btnNhan
            this.btnNhan.Location =
                new System.Drawing.Point(230, 115);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size =
                new System.Drawing.Size(75, 35);
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click +=
                new System.EventHandler(
                    this.btnNhan_Click
                );

            // btnChia
            this.btnChia.Location =
                new System.Drawing.Point(325, 115);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size =
                new System.Drawing.Size(75, 35);
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click +=
                new System.EventHandler(
                    this.btnChia_Click
                );

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(440, 180);

            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);

            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);

            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Cộng trừ nhân chia";

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form1_FormClosing
                );

            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}