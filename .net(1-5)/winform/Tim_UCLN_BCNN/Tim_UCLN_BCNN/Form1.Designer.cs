namespace Tim_UCLN_BCNN
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
            label2 = new Label();
            txtNhap1 = new TextBox();
            txtNhap2 = new TextBox();
            btnUCLN = new Button();
            btnBCNN = new Button();
            txtInUCLN = new TextBox();
            txtInBCNN = new TextBox();
            btnNhap = new Button();
            btnThoat = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập số thứ hai";
            // 
            // txtNhap1
            // 
            txtNhap1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhap1.Location = new Point(127, 61);
            txtNhap1.Name = "txtNhap1";
            txtNhap1.Size = new Size(64, 21);
            txtNhap1.TabIndex = 2;
            // 
            // txtNhap2
            // 
            txtNhap2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNhap2.Location = new Point(127, 100);
            txtNhap2.Name = "txtNhap2";
            txtNhap2.Size = new Size(64, 21);
            txtNhap2.TabIndex = 3;
            // 
            // btnUCLN
            // 
            btnUCLN.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUCLN.Location = new Point(197, 61);
            btnUCLN.Name = "btnUCLN";
            btnUCLN.Size = new Size(75, 23);
            btnUCLN.TabIndex = 4;
            btnUCLN.Text = "Tìm UCLN";
            btnUCLN.UseVisualStyleBackColor = true;
            btnUCLN.Click += btnUCLN_Click;
            // 
            // btnBCNN
            // 
            btnBCNN.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBCNN.Location = new Point(197, 100);
            btnBCNN.Name = "btnBCNN";
            btnBCNN.Size = new Size(75, 23);
            btnBCNN.TabIndex = 5;
            btnBCNN.Text = "Tìm BCNN";
            btnBCNN.UseVisualStyleBackColor = true;
            btnBCNN.Click += btnBCNN_Click;
            // 
            // txtInUCLN
            // 
            txtInUCLN.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtInUCLN.Location = new Point(278, 62);
            txtInUCLN.Name = "txtInUCLN";
            txtInUCLN.Size = new Size(83, 21);
            txtInUCLN.TabIndex = 6;
            // 
            // txtInBCNN
            // 
            txtInBCNN.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtInBCNN.Location = new Point(278, 103);
            txtInBCNN.Name = "txtInBCNN";
            txtInBCNN.Size = new Size(83, 21);
            txtInBCNN.TabIndex = 7;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhap.Location = new Point(142, 139);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(223, 139);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(78, 9);
            label3.Name = "label3";
            label3.Size = new Size(234, 17);
            label3.TabIndex = 10;
            label3.Text = "Chương trình tìm UCLN và BCNN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 185);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(btnNhap);
            Controls.Add(txtInBCNN);
            Controls.Add(txtInUCLN);
            Controls.Add(btnBCNN);
            Controls.Add(btnUCLN);
            Controls.Add(txtNhap2);
            Controls.Add(txtNhap1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tìm UCLN, BCNN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNhap1;
        private TextBox txtNhap2;
        private Button btnUCLN;
        private Button btnBCNN;
        private TextBox txtInUCLN;
        private TextBox txtInBCNN;
        private Button btnNhap;
        private Button btnThoat;
        private Label label3;
    }
}