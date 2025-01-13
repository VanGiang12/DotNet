namespace Bai1_2_Trang113
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstWeb = new ListBox();
            txtKetQua = new TextBox();
            btnOK = new Button();
            btnReset = new Button();
            cboWeb = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Liên kết Website";
            // 
            // lstWeb
            // 
            lstWeb.FormattingEnabled = true;
            lstWeb.ItemHeight = 15;
            lstWeb.Items.AddRange(new object[] { "Tuổi Trẻ", "Thanh niên", "VNExpress", "Dân trí", "Quân đội" });
            lstWeb.Location = new Point(12, 37);
            lstWeb.Name = "lstWeb";
            lstWeb.Size = new Size(156, 64);
            lstWeb.TabIndex = 1;
            lstWeb.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(174, 37);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(155, 121);
            txtKetQua.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 135);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 3;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(93, 135);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cboWeb
            // 
            cboWeb.FormattingEnabled = true;
            cboWeb.Items.AddRange(new object[] { "Tuổi trẻ", "Thanh niên", "VNExpress", "Dân trí", "Quân đội" });
            cboWeb.Location = new Point(12, 107);
            cboWeb.Name = "cboWeb";
            cboWeb.Size = new Size(156, 23);
            cboWeb.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 170);
            Controls.Add(cboWeb);
            Controls.Add(btnReset);
            Controls.Add(btnOK);
            Controls.Add(txtKetQua);
            Controls.Add(lstWeb);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstWeb;
        private TextBox txtKetQua;
        private Button btnOK;
        private Button btnReset;
        private ComboBox cboWeb;
    }
}