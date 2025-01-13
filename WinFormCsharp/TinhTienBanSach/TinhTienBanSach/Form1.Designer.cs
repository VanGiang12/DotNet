namespace TinhTienBanSach
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtThanhTien = new TextBox();
            txtSoLuong = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            chkSV = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            btnThanhTien = new Button();
            btnTiepTheo = new Button();
            btnThongKe = new Button();
            btnKetThuc = new Button();
            groupBox2 = new GroupBox();
            txtTongDoanhThu = new TextBox();
            txtTongSV = new TextBox();
            txtTongKH = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(461, 36);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính tiền bán sách";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chkSV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 189);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(169, 137);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(261, 29);
            txtThanhTien.TabIndex = 6;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(169, 73);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(261, 29);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(169, 29);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(261, 29);
            txtTen.TabIndex = 1;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 145);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 5;
            label4.Text = "Thành Tiền";
            // 
            // chkSV
            // 
            chkSV.AutoSize = true;
            chkSV.Location = new Point(37, 106);
            chkSV.Name = "chkSV";
            chkSV.RightToLeft = RightToLeft.Yes;
            chkSV.Size = new Size(149, 25);
            chkSV.TabIndex = 4;
            chkSV.Text = "Khách hàng là SV";
            chkSV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 70);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 2;
            label3.Text = "Số lượng sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 32);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên Khách Hàng";
            // 
            // btnThanhTien
            // 
            btnThanhTien.Location = new Point(31, 244);
            btnThanhTien.Name = "btnThanhTien";
            btnThanhTien.Size = new Size(88, 31);
            btnThanhTien.TabIndex = 2;
            btnThanhTien.Text = "Tính TT";
            btnThanhTien.UseVisualStyleBackColor = true;
            btnThanhTien.Click += btnThanhTien_Click;
            // 
            // btnTiepTheo
            // 
            btnTiepTheo.Location = new Point(130, 244);
            btnTiepTheo.Name = "btnTiepTheo";
            btnTiepTheo.Size = new Size(88, 31);
            btnTiepTheo.TabIndex = 3;
            btnTiepTheo.Text = "Tiếp";
            btnTiepTheo.UseVisualStyleBackColor = true;
            btnTiepTheo.Click += btnTiepTheo_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(229, 244);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(88, 31);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(331, 244);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(88, 31);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongDoanhThu);
            groupBox2.Controls.Add(txtTongSV);
            groupBox2.Controls.Add(txtTongKH);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(0, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 160);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống Kê";
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Location = new Point(181, 91);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.ReadOnly = true;
            txtTongDoanhThu.Size = new Size(249, 29);
            txtTongDoanhThu.TabIndex = 5;
            txtTongDoanhThu.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTongSV
            // 
            txtTongSV.Location = new Point(181, 56);
            txtTongSV.Name = "txtTongSV";
            txtTongSV.ReadOnly = true;
            txtTongSV.Size = new Size(249, 29);
            txtTongSV.TabIndex = 3;
            txtTongSV.TextAlign = HorizontalAlignment.Right;
            txtTongSV.MouseClick += txtTongSV_MouseClick;
            txtTongSV.MouseDoubleClick += txtTongSV_MouseDoubleClick;
            // 
            // txtTongKH
            // 
            txtTongKH.Location = new Point(181, 22);
            txtTongKH.Name = "txtTongKH";
            txtTongKH.ReadOnly = true;
            txtTongKH.Size = new Size(249, 29);
            txtTongKH.TabIndex = 1;
            txtTongKH.TextAlign = HorizontalAlignment.Right;
            txtTongKH.MouseDoubleClick += txtTongKH_MouseDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 94);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 4;
            label7.Text = "Tổng doanh thu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 59);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 2;
            label6.Text = "Tổng số KH là SV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 25);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 0;
            label5.Text = "Tổng số KH";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnThanhTien;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKetThuc;
            ClientSize = new Size(461, 455);
            Controls.Add(groupBox2);
            Controls.Add(btnKetThuc);
            Controls.Add(btnThongKe);
            Controls.Add(btnTiepTheo);
            Controls.Add(btnThanhTien);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính Tiền Bán Sách";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtThanhTien;
        private TextBox txtSoLuong;
        private TextBox txtTen;
        private Label label4;
        private CheckBox chkSV;
        private Label label3;
        private Label label2;
        private Button btnThanhTien;
        private Button btnTiepTheo;
        private Button btnThongKe;
        private Button btnKetThuc;
        private GroupBox groupBox2;
        private TextBox txtTongDoanhThu;
        private TextBox txtTongSV;
        private TextBox txtTongKH;
        private Label label7;
        private Label label6;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}