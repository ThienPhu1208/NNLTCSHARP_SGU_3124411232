namespace Bai01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupLuaChon;

        private System.Windows.Forms.RadioButton radBacNhat;
        private System.Windows.Forms.RadioButton radBacHai;

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtKetQua;

        private System.Windows.Forms.Button btnGiai;
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

            this.groupLuaChon =
                new System.Windows.Forms.GroupBox();

            this.radBacNhat =
                new System.Windows.Forms.RadioButton();

            this.radBacHai =
                new System.Windows.Forms.RadioButton();

            this.lblA =
                new System.Windows.Forms.Label();

            this.lblB =
                new System.Windows.Forms.Label();

            this.lblC =
                new System.Windows.Forms.Label();

            this.lblKetQua =
                new System.Windows.Forms.Label();

            this.txtA =
                new System.Windows.Forms.TextBox();

            this.txtB =
                new System.Windows.Forms.TextBox();

            this.txtC =
                new System.Windows.Forms.TextBox();

            this.txtKetQua =
                new System.Windows.Forms.TextBox();

            this.btnGiai =
                new System.Windows.Forms.Button();

            this.btnThoat =
                new System.Windows.Forms.Button();

            this.groupLuaChon.SuspendLayout();
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
                new System.Drawing.Point(65, 15);

            this.lblTieuDe.Text =
                "GIẢI PHƯƠNG TRÌNH";

            // groupLuaChon
            this.groupLuaChon.Controls.Add(
                this.radBacHai
            );

            this.groupLuaChon.Controls.Add(
                this.radBacNhat
            );

            this.groupLuaChon.Location =
                new System.Drawing.Point(25, 55);

            this.groupLuaChon.Size =
                new System.Drawing.Size(335, 75);

            this.groupLuaChon.Text =
                "Bạn vui lòng chọn";

            // radBacNhat
            this.radBacNhat.AutoSize = true;

            this.radBacNhat.Location =
                new System.Drawing.Point(20, 22);

            this.radBacNhat.Text =
                "Phương trình bậc nhất";

            this.radBacNhat.CheckedChanged +=
                new System.EventHandler(
                    this.radBacNhat_CheckedChanged
                );

            // radBacHai
            this.radBacHai.AutoSize = true;

            this.radBacHai.Location =
                new System.Drawing.Point(20, 47);

            this.radBacHai.Text =
                "Phương trình bậc hai";

            this.radBacHai.CheckedChanged +=
                new System.EventHandler(
                    this.radBacHai_CheckedChanged
                );

            // lblA
            this.lblA.AutoSize = true;

            this.lblA.Location =
                new System.Drawing.Point(30, 145);

            this.lblA.Text =
                "Nhập a";

            // txtA
            this.txtA.Location =
                new System.Drawing.Point(85, 142);

            this.txtA.Size =
                new System.Drawing.Size(100, 23);

            this.txtA.TextChanged +=
                new System.EventHandler(
                    this.txtA_TextChanged
                );

            this.txtA.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtA_KeyPress
                );

            // lblB
            this.lblB.AutoSize = true;

            this.lblB.Location =
                new System.Drawing.Point(30, 177);

            this.lblB.Text =
                "Nhập b";

            // txtB
            this.txtB.Location =
                new System.Drawing.Point(85, 174);

            this.txtB.Size =
                new System.Drawing.Size(100, 23);

            this.txtB.TextChanged +=
                new System.EventHandler(
                    this.txtB_TextChanged
                );

            this.txtB.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtB_KeyPress
                );

            // lblC
            this.lblC.AutoSize = true;

            this.lblC.Location =
                new System.Drawing.Point(30, 209);

            this.lblC.Text =
                "Nhập c";

            // txtC
            this.txtC.Location =
                new System.Drawing.Point(85, 206);

            this.txtC.Size =
                new System.Drawing.Size(100, 23);

            this.txtC.TextChanged +=
                new System.EventHandler(
                    this.txtC_TextChanged
                );

            this.txtC.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtC_KeyPress
                );

            // lblKetQua
            this.lblKetQua.AutoSize = true;

            this.lblKetQua.Location =
                new System.Drawing.Point(30, 250);

            this.lblKetQua.Text =
                "Kết quả";

            // txtKetQua
            this.txtKetQua.Location =
                new System.Drawing.Point(85, 247);

            this.txtKetQua.Multiline = true;

            this.txtKetQua.ReadOnly = true;

            this.txtKetQua.Size =
                new System.Drawing.Size(275, 55);

            // btnGiai
            this.btnGiai.Location =
                new System.Drawing.Point(220, 145);

            this.btnGiai.Size =
                new System.Drawing.Size(100, 35);

            this.btnGiai.Text =
                "Giải";

            this.btnGiai.Enabled = false;

            this.btnGiai.Click +=
                new System.EventHandler(
                    this.btnGiai_Click
                );

            // btnThoat
            this.btnThoat.Location =
                new System.Drawing.Point(220, 190);

            this.btnThoat.Size =
                new System.Drawing.Size(100, 35);

            this.btnThoat.Text =
                "Thoát";

            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click
                );

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F
                );

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(
                    390,
                    325
                );

            this.Controls.Add(
                this.btnThoat
            );

            this.Controls.Add(
                this.btnGiai
            );

            this.Controls.Add(
                this.txtKetQua
            );

            this.Controls.Add(
                this.lblKetQua
            );

            this.Controls.Add(
                this.txtC
            );

            this.Controls.Add(
                this.lblC
            );

            this.Controls.Add(
                this.txtB
            );

            this.Controls.Add(
                this.lblB
            );

            this.Controls.Add(
                this.txtA
            );

            this.Controls.Add(
                this.lblA
            );

            this.Controls.Add(
                this.groupLuaChon
            );

            this.Controls.Add(
                this.lblTieuDe
            );

            this.Name =
                "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Giải phương trình bậc 1-2";

            this.Load +=
                new System.EventHandler(
                    this.Form1_Load
                );

            this.FormClosing +=
                new System.Windows.Forms.FormClosingEventHandler(
                    this.Form1_FormClosing
                );

            this.groupLuaChon.ResumeLayout(false);
            this.groupLuaChon.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}