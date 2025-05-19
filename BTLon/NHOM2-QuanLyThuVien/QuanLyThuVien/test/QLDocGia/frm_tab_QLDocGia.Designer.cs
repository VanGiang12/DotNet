namespace test
{
    partial class frm_tab_QLDocGia
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
            panel1 = new Panel();
            txtPass = new TextBox();
            label8 = new Label();
            btnHienThi = new Button();
            cbtypeReader = new ComboBox();
            tbaddress = new TextBox();
            label11 = new Label();
            dtpdate = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            btHuy = new Button();
            btdelete = new Button();
            btedit = new Button();
            btadd = new Button();
            tbcardNumber = new TextBox();
            tbdepartment = new TextBox();
            groupBox1 = new GroupBox();
            rbfemale = new RadioButton();
            rbmale = new RadioButton();
            tbname = new TextBox();
            tbcodeReader = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            panel4 = new Panel();
            tbsearch = new TextBox();
            lbsearch = new Label();
            rbcardNumber = new RadioButton();
            rbname = new RadioButton();
            rbcodeReader = new RadioButton();
            label7 = new Label();
            panel3 = new Panel();
            dgvlistReader = new DataGridView();
            btnLamThe = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlistReader).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnHienThi);
            panel1.Controls.Add(cbtypeReader);
            panel1.Controls.Add(tbaddress);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dtpdate);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btHuy);
            panel1.Controls.Add(btdelete);
            panel1.Controls.Add(btedit);
            panel1.Controls.Add(btadd);
            panel1.Controls.Add(tbcardNumber);
            panel1.Controls.Add(tbdepartment);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(tbname);
            panel1.Controls.Add(tbcodeReader);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 481);
            panel1.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.ForeColor = Color.Black;
            txtPass.Location = new Point(87, 94);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(175, 23);
            txtPass.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(17, 97);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 24;
            label8.Text = "Password";
            // 
            // btnHienThi
            // 
            btnHienThi.BackColor = Color.SeaGreen;
            btnHienThi.FlatStyle = FlatStyle.Flat;
            btnHienThi.ForeColor = Color.White;
            btnHienThi.Location = new Point(87, 447);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(116, 31);
            btnHienThi.TabIndex = 23;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = false;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // cbtypeReader
            // 
            cbtypeReader.FormattingEnabled = true;
            cbtypeReader.Items.AddRange(new object[] { "Sinh Viên", "Giảng Viên" });
            cbtypeReader.Location = new Point(87, 245);
            cbtypeReader.Name = "cbtypeReader";
            cbtypeReader.Size = new Size(175, 23);
            cbtypeReader.TabIndex = 22;
            // 
            // tbaddress
            // 
            tbaddress.ForeColor = Color.Black;
            tbaddress.Location = new Point(87, 303);
            tbaddress.Name = "tbaddress";
            tbaddress.Size = new Size(175, 23);
            tbaddress.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(31, 306);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 20;
            label11.Text = "Địa chỉ";
            // 
            // dtpdate
            // 
            dtpdate.CustomFormat = "dd/MM/yyyy";
            dtpdate.Format = DateTimePickerFormat.Custom;
            dtpdate.Location = new Point(87, 166);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(175, 23);
            dtpdate.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(14, 172);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 18;
            label10.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(77, 10);
            label9.Name = "label9";
            label9.Size = new Size(126, 19);
            label9.TabIndex = 2;
            label9.Text = "Thông tin độc giả";
            // 
            // btHuy
            // 
            btHuy.BackColor = Color.SeaGreen;
            btHuy.FlatStyle = FlatStyle.Flat;
            btHuy.ForeColor = Color.White;
            btHuy.Location = new Point(150, 410);
            btHuy.Name = "btHuy";
            btHuy.Size = new Size(115, 31);
            btHuy.TabIndex = 17;
            btHuy.Text = "Hủy";
            btHuy.UseVisualStyleBackColor = false;
            btHuy.Click += btHuy_Click;
            // 
            // btdelete
            // 
            btdelete.BackColor = Color.SeaGreen;
            btdelete.BackgroundImageLayout = ImageLayout.None;
            btdelete.FlatStyle = FlatStyle.Flat;
            btdelete.ForeColor = Color.White;
            btdelete.Location = new Point(150, 373);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(115, 31);
            btdelete.TabIndex = 14;
            btdelete.Text = "Xóa";
            btdelete.UseVisualStyleBackColor = false;
            btdelete.Click += btdelete_Click;
            // 
            // btedit
            // 
            btedit.BackColor = Color.SeaGreen;
            btedit.FlatStyle = FlatStyle.Flat;
            btedit.ForeColor = Color.White;
            btedit.Location = new Point(17, 410);
            btedit.Name = "btedit";
            btedit.Size = new Size(116, 31);
            btedit.TabIndex = 13;
            btedit.Text = "Sửa";
            btedit.UseVisualStyleBackColor = false;
            btedit.Click += btedit_Click_1;
            // 
            // btadd
            // 
            btadd.BackColor = Color.SeaGreen;
            btadd.FlatStyle = FlatStyle.Flat;
            btadd.ForeColor = Color.White;
            btadd.Location = new Point(17, 373);
            btadd.Name = "btadd";
            btadd.Size = new Size(116, 31);
            btadd.TabIndex = 12;
            btadd.Text = "Thêm";
            btadd.UseVisualStyleBackColor = false;
            btadd.Click += btadd_Click;
            // 
            // tbcardNumber
            // 
            tbcardNumber.ForeColor = Color.Black;
            tbcardNumber.Location = new Point(87, 334);
            tbcardNumber.Name = "tbcardNumber";
            tbcardNumber.ReadOnly = true;
            tbcardNumber.Size = new Size(175, 23);
            tbcardNumber.TabIndex = 11;
            // 
            // tbdepartment
            // 
            tbdepartment.ForeColor = Color.Black;
            tbdepartment.Location = new Point(87, 274);
            tbdepartment.Name = "tbdepartment";
            tbdepartment.Size = new Size(175, 23);
            tbdepartment.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbfemale);
            groupBox1.Controls.Add(rbmale);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(87, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 38);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // rbfemale
            // 
            rbfemale.AutoSize = true;
            rbfemale.Location = new Point(78, 10);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(41, 19);
            rbfemale.TabIndex = 1;
            rbfemale.TabStop = true;
            rbfemale.Text = "Nữ";
            rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            rbmale.AutoSize = true;
            rbmale.Location = new Point(6, 10);
            rbmale.Name = "rbmale";
            rbmale.Size = new Size(51, 19);
            rbmale.TabIndex = 0;
            rbmale.TabStop = true;
            rbmale.Text = "Nam";
            rbmale.UseVisualStyleBackColor = true;
            // 
            // tbname
            // 
            tbname.ForeColor = Color.Black;
            tbname.Location = new Point(87, 130);
            tbname.Name = "tbname";
            tbname.Size = new Size(175, 23);
            tbname.TabIndex = 7;
            // 
            // tbcodeReader
            // 
            tbcodeReader.ForeColor = Color.Black;
            tbcodeReader.Location = new Point(90, 53);
            tbcodeReader.Name = "tbcodeReader";
            tbcodeReader.Size = new Size(175, 23);
            tbcodeReader.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(40, 277);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 5;
            label6.Text = "Khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(22, 213);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 342);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Số thẻ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 245);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Loại độc giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 133);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 56);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã độc giả";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CaRo___Copy;
            pictureBox1.Location = new Point(783, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(319, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 140);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(rbcardNumber);
            groupBox2.Controls.Add(rbname);
            groupBox2.Controls.Add(rbcodeReader);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 104);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(tbsearch);
            panel4.Controls.Add(lbsearch);
            panel4.Location = new Point(46, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 34);
            panel4.TabIndex = 3;
            // 
            // tbsearch
            // 
            tbsearch.BorderStyle = BorderStyle.None;
            tbsearch.Dock = DockStyle.Fill;
            tbsearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbsearch.Location = new Point(0, 0);
            tbsearch.Name = "tbsearch";
            tbsearch.Size = new Size(267, 27);
            tbsearch.TabIndex = 1;
            // 
            // lbsearch
            // 
            lbsearch.BackColor = Color.SeaGreen;
            lbsearch.Dock = DockStyle.Right;
            lbsearch.ForeColor = Color.White;
            lbsearch.Location = new Point(267, 0);
            lbsearch.Name = "lbsearch";
            lbsearch.Size = new Size(66, 30);
            lbsearch.TabIndex = 0;
            lbsearch.Text = "Tìm kiếm";
            lbsearch.TextAlign = ContentAlignment.MiddleCenter;
            lbsearch.Click += lbsearch_Click;
            // 
            // rbcardNumber
            // 
            rbcardNumber.AutoSize = true;
            rbcardNumber.ForeColor = Color.Black;
            rbcardNumber.Location = new Point(325, 25);
            rbcardNumber.Name = "rbcardNumber";
            rbcardNumber.Size = new Size(58, 19);
            rbcardNumber.TabIndex = 2;
            rbcardNumber.TabStop = true;
            rbcardNumber.Text = "Số thẻ";
            rbcardNumber.UseVisualStyleBackColor = true;
            // 
            // rbname
            // 
            rbname.AutoSize = true;
            rbname.ForeColor = Color.Black;
            rbname.Location = new Point(186, 25);
            rbname.Name = "rbname";
            rbname.Size = new Size(85, 19);
            rbname.TabIndex = 1;
            rbname.TabStop = true;
            rbname.Text = "Tên độc giả";
            rbname.UseVisualStyleBackColor = true;
            // 
            // rbcodeReader
            // 
            rbcodeReader.AutoSize = true;
            rbcodeReader.ForeColor = Color.Black;
            rbcodeReader.Location = new Point(46, 24);
            rbcodeReader.Name = "rbcodeReader";
            rbcodeReader.Size = new Size(84, 19);
            rbcodeReader.TabIndex = 0;
            rbcodeReader.TabStop = true;
            rbcodeReader.Text = "Mã độc giả";
            rbcodeReader.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(126, 10);
            label7.Name = "label7";
            label7.Size = new Size(189, 19);
            label7.TabIndex = 0;
            label7.Text = "Tìm kiếm thông tin độc giả";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvlistReader);
            panel3.Location = new Point(319, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(637, 332);
            panel3.TabIndex = 2;
            // 
            // dgvlistReader
            // 
            dgvlistReader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistReader.Dock = DockStyle.Fill;
            dgvlistReader.Location = new Point(0, 0);
            dgvlistReader.Name = "dgvlistReader";
            dgvlistReader.RowHeadersVisible = false;
            dgvlistReader.RowTemplate.Height = 25;
            dgvlistReader.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlistReader.Size = new Size(637, 332);
            dgvlistReader.TabIndex = 0;
            dgvlistReader.CellClick += dgvlistReader_CellClick_1;
            // 
            // btnLamThe
            // 
            btnLamThe.BackColor = Color.SeaGreen;
            btnLamThe.BackgroundImageLayout = ImageLayout.None;
            btnLamThe.FlatStyle = FlatStyle.Flat;
            btnLamThe.ForeColor = Color.White;
            btnLamThe.Location = new Point(829, 121);
            btnLamThe.Name = "btnLamThe";
            btnLamThe.Size = new Size(75, 31);
            btnLamThe.TabIndex = 22;
            btnLamThe.Text = "Làm thẻ";
            btnLamThe.UseVisualStyleBackColor = false;
            btnLamThe.Click += btnLamThe_Click;
            // 
            // frm_tab_QLDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 505);
            Controls.Add(btnLamThe);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_tab_QLDocGia";
            Text = "frm_tab_QLDocGia";
            Load += frm_tab_QLDocGia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvlistReader).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private RadioButton rbfemale;
        private RadioButton rbmale;
        private TextBox tbname;
        private TextBox tbcodeReader;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btHuy;
        private Button btdelete;
        private Button btedit;
        private Button btadd;
        private TextBox tbcardNumber;
        private TextBox tbdepartment;
        private Label label7;
        private GroupBox groupBox2;
        private Panel panel4;
        private TextBox tbsearch;
        private Label lbsearch;
        private RadioButton rbcardNumber;
        private RadioButton rbname;
        private RadioButton rbcodeReader;
        private DataGridView dgvlistReader;
        private Label label9;
        private TextBox tbaddress;
        private Label label11;
        private DateTimePicker dtpdate;
        private Label label10;
        private Button btnLamThe;
        private ComboBox cbtypeReader;
        private Label label3;
        private Button btnHienThi;
        private TextBox txtPass;
        private Label label8;
    }
}