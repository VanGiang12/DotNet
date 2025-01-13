namespace KtraDoAn1
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            hem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtCoQuan = new TextBox();
            txtDC = new TextBox();
            txtsdt = new TextBox();
            dgvDS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDS).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN ĐỘC GIẢ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã ĐG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 88);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên ĐG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 124);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Cơ quan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 162);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 198);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // hem
            // 
            hem.Location = new Point(66, 237);
            hem.Name = "hem";
            hem.Size = new Size(75, 23);
            hem.TabIndex = 6;
            hem.Text = "Thêm";
            hem.UseVisualStyleBackColor = true;
            hem.Click += hem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(164, 237);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(252, 237);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(349, 237);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(108, 49);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(345, 23);
            txtMa.TabIndex = 10;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(109, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(345, 23);
            txtTen.TabIndex = 11;
            // 
            // txtCoQuan
            // 
            txtCoQuan.Location = new Point(108, 121);
            txtCoQuan.Name = "txtCoQuan";
            txtCoQuan.Size = new Size(345, 23);
            txtCoQuan.TabIndex = 12;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(108, 159);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(345, 23);
            txtDC.TabIndex = 13;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(108, 190);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(345, 23);
            txtsdt.TabIndex = 14;
            // 
            // dgvDS
            // 
            dgvDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDS.Location = new Point(26, 266);
            dgvDS.Name = "dgvDS";
            dgvDS.RowTemplate.Height = 25;
            dgvDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDS.Size = new Size(427, 150);
            dgvDS.TabIndex = 15;
            dgvDS.CellClick += dgvDS_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 421);
            Controls.Add(dgvDS);
            Controls.Add(txtsdt);
            Controls.Add(txtDC);
            Controls.Add(txtCoQuan);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(hem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button hem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtCoQuan;
        private TextBox txtDC;
        private TextBox txtsdt;
        private DataGridView dgvDS;
    }
}