namespace Bai29
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
            groupBox1 = new GroupBox();
            txtNgaySinh = new TextBox();
            txtHoTen = new TextBox();
            txtMaSo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            listView1 = new ListView();
            maso = new ColumnHeader();
            hoten = new ColumnHeader();
            ngaysinh = new ColumnHeader();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 156);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(85, 113);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(304, 23);
            txtNgaySinh.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(85, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(304, 23);
            txtHoTen.TabIndex = 4;
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(85, 33);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(304, 23);
            txtMaSo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(108, 174);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(65, 23);
            btnThem.TabIndex = 4;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(246, 174);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { maso, hoten, ngaysinh });
            listView1.Location = new Point(11, 203);
            listView1.Name = "listView1";
            listView1.Size = new Size(415, 165);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // maso
            // 
            maso.Text = "Mã Số";
            maso.Width = 120;
            // 
            // hoten
            // 
            hoten.Text = "Họ tên";
            hoten.TextAlign = HorizontalAlignment.Center;
            hoten.Width = 150;
            // 
            // ngaysinh
            // 
            ngaysinh.Text = "Ngày sinh";
            ngaysinh.TextAlign = HorizontalAlignment.Center;
            ngaysinh.Width = 135;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(157, 374);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 23);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 405);
            Controls.Add(btnXoa);
            Controls.Add(listView1);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtMaSo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private Button btnLuu;
        private ListView listView1;
        private ColumnHeader maso;
        private ColumnHeader hoten;
        private ColumnHeader ngaysinh;
        private Button btnXoa;
    }
}