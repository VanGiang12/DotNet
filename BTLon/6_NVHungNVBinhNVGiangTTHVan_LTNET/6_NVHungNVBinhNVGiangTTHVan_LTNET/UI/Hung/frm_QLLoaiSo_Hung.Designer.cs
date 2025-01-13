namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Hung
{
    partial class frm_QLLoaiSo_Hung
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            cb_tenloaiso_hung = new ComboBox();
            cb_sothang_hung = new ComboBox();
            tb_laisuattheothang_hung = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_maloaiso_hung = new TextBox();
            groupBox2 = new GroupBox();
            bt_capnhat_hung = new Button();
            bt_xoa_hung = new Button();
            bt_them_hung = new Button();
            groupBox3 = new GroupBox();
            bt_tk_hung = new Button();
            tb_timkiem_hung = new TextBox();
            dgv_hung = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hung).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 134);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_tenloaiso_hung);
            groupBox1.Controls.Add(cb_sothang_hung);
            groupBox1.Controls.Add(tb_laisuattheothang_hung);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_maloaiso_hung);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(19, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 350);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm loại sổ tiết kiệm mới";
            // 
            // cb_tenloaiso_hung
            // 
            cb_tenloaiso_hung.FormattingEnabled = true;
            cb_tenloaiso_hung.Items.AddRange(new object[] { "Không kỳ hạn", "3 tháng", "6 tháng", "9 tháng", "12 tháng" });
            cb_tenloaiso_hung.Location = new Point(228, 108);
            cb_tenloaiso_hung.Name = "cb_tenloaiso_hung";
            cb_tenloaiso_hung.Size = new Size(235, 28);
            cb_tenloaiso_hung.TabIndex = 10;
            cb_tenloaiso_hung.Text = "Tên loại sổ";
            // 
            // cb_sothang_hung
            // 
            cb_sothang_hung.FormattingEnabled = true;
            cb_sothang_hung.Items.AddRange(new object[] { "0", "3", "6", "9", "12" });
            cb_sothang_hung.Location = new Point(228, 251);
            cb_sothang_hung.Name = "cb_sothang_hung";
            cb_sothang_hung.Size = new Size(235, 28);
            cb_sothang_hung.TabIndex = 9;
            cb_sothang_hung.Text = "Số tháng";
            // 
            // tb_laisuattheothang_hung
            // 
            tb_laisuattheothang_hung.Location = new Point(228, 181);
            tb_laisuattheothang_hung.Name = "tb_laisuattheothang_hung";
            tb_laisuattheothang_hung.Size = new Size(233, 27);
            tb_laisuattheothang_hung.TabIndex = 6;
            // 
            // label5
            // 
            label5.Location = new Point(37, 254);
            label5.Name = "label5";
            label5.Size = new Size(127, 52);
            label5.TabIndex = 5;
            label5.Text = "Số tháng";
            // 
            // label4
            // 
            label4.Location = new Point(37, 108);
            label4.Name = "label4";
            label4.Size = new Size(127, 52);
            label4.TabIndex = 4;
            label4.Text = "Tên loại sổ";
            // 
            // label2
            // 
            label2.Location = new Point(37, 62);
            label2.Name = "label2";
            label2.Size = new Size(127, 52);
            label2.TabIndex = 2;
            label2.Text = "Mã loại sổ";
            // 
            // label3
            // 
            label3.Location = new Point(37, 181);
            label3.Name = "label3";
            label3.Size = new Size(127, 52);
            label3.TabIndex = 3;
            label3.Text = "Lãi suất theo tháng";
            // 
            // tb_maloaiso_hung
            // 
            tb_maloaiso_hung.Location = new Point(228, 59);
            tb_maloaiso_hung.Name = "tb_maloaiso_hung";
            tb_maloaiso_hung.Size = new Size(233, 27);
            tb_maloaiso_hung.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_capnhat_hung);
            groupBox2.Controls.Add(bt_xoa_hung);
            groupBox2.Controls.Add(bt_them_hung);
            groupBox2.Location = new Point(571, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 245);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bt_capnhat_hung
            // 
            bt_capnhat_hung.Location = new Point(88, 76);
            bt_capnhat_hung.Name = "bt_capnhat_hung";
            bt_capnhat_hung.Size = new Size(94, 29);
            bt_capnhat_hung.TabIndex = 3;
            bt_capnhat_hung.Text = "Cập nhật";
            bt_capnhat_hung.UseVisualStyleBackColor = true;
            bt_capnhat_hung.Click += capnhat_Click;
            // 
            // bt_xoa_hung
            // 
            bt_xoa_hung.Location = new Point(88, 135);
            bt_xoa_hung.Name = "bt_xoa_hung";
            bt_xoa_hung.Size = new Size(94, 29);
            bt_xoa_hung.TabIndex = 1;
            bt_xoa_hung.Text = "Xóa";
            bt_xoa_hung.UseVisualStyleBackColor = true;
            bt_xoa_hung.Click += xoa_Click;
            // 
            // bt_them_hung
            // 
            bt_them_hung.Location = new Point(88, 26);
            bt_them_hung.Name = "bt_them_hung";
            bt_them_hung.Size = new Size(94, 29);
            bt_them_hung.TabIndex = 0;
            bt_them_hung.Text = "Thêm";
            bt_them_hung.UseVisualStyleBackColor = true;
            bt_them_hung.Click += them_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_tk_hung);
            groupBox3.Controls.Add(tb_timkiem_hung);
            groupBox3.Location = new Point(571, 316);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(457, 75);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // bt_tk_hung
            // 
            bt_tk_hung.Location = new Point(310, 24);
            bt_tk_hung.Name = "bt_tk_hung";
            bt_tk_hung.Size = new Size(94, 29);
            bt_tk_hung.TabIndex = 3;
            bt_tk_hung.Text = "Tìm kiếm";
            bt_tk_hung.Click += tk_Click;
            // 
            // tb_timkiem_hung
            // 
            tb_timkiem_hung.Location = new Point(32, 26);
            tb_timkiem_hung.Name = "tb_timkiem_hung";
            tb_timkiem_hung.Size = new Size(257, 27);
            tb_timkiem_hung.TabIndex = 2;
            // 
            // dgv_hung
            // 
            dgv_hung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hung.Location = new Point(19, 473);
            dgv_hung.Name = "dgv_hung";
            dgv_hung.RowHeadersWidth = 51;
            dgv_hung.RowTemplate.Height = 29;
            dgv_hung.Size = new Size(1009, 278);
            dgv_hung.TabIndex = 4;
            dgv_hung.CellClick += dgv_CellClick;
            // 
            // frm_QLLoaiSo_Hung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 763);
            Controls.Add(dgv_hung);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1121, 810);
            MinimumSize = new Size(1121, 810);
            Name = "frm_QLLoaiSo_Hung";
            Text = "frm_QLLoaiSo_Hung";
            Load += frm_QLLoaiSo_Hung_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox tb_maloaiso_hung;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_laisuattheothang_hung;
        private Button bt_capnhat_hung;
        private Button button3;
        private Button bt_xoa_hung;
        private Button bt_them_hung;
        private GroupBox groupBox3;
        private Button tk;
        private TextBox timkiem;
        private DataGridView dgv_hung;
        private ComboBox cb_sothang_hung;
        private ComboBox cb_tenloaiso_hung;
        private Button bt_tk_hung;
        private TextBox tb_timkiem_hung;
    }
}