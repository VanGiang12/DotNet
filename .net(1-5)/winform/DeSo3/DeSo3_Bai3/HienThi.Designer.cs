namespace DeSo3_Bai3
{
    partial class HienThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTimKiem = new Button();
            btnCapNhat = new Button();
            btnBoSung = new Button();
            dataGridView1 = new DataGridView();
            cboKhoa = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(266, 27);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(361, 119);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 23;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += button2_Click;
            // 
            // btnBoSung
            // 
            btnBoSung.Location = new Point(361, 72);
            btnBoSung.Name = "btnBoSung";
            btnBoSung.Size = new Size(75, 23);
            btnBoSung.TabIndex = 22;
            btnBoSung.Text = "Bổ sung";
            btnBoSung.UseVisualStyleBackColor = true;
            btnBoSung.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(322, 179);
            dataGridView1.TabIndex = 21;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Items.AddRange(new object[] { "cơ khí", "cntt", "điện tử" });
            cboKhoa.Location = new Point(122, 27);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(121, 23);
            cboKhoa.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 30);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 15;
            label3.Text = "Khoa";
            // 
            // HienThi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 264);
            Controls.Add(btnTimKiem);
            Controls.Add(btnCapNhat);
            Controls.Add(btnBoSung);
            Controls.Add(dataGridView1);
            Controls.Add(cboKhoa);
            Controls.Add(label3);
            Name = "HienThi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HienThi";
            Load += HienThi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private Button btnCapNhat;
        private Button btnBoSung;
        private DataGridView dataGridView1;
        private ComboBox cboKhoa;
        private Label label3;
    }
}