namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Binh
{
    partial class frm_ThongKe_Binh
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
            gb_binh = new GroupBox();
            dgv_HthiDs_binh = new DataGridView();
            label2 = new Label();
            cb_tgmodc_binh = new ComboBox();
            label1 = new Label();
            bt_xuat_binh = new Button();
            bt_thongke_binh = new Button();
            gb_binh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HthiDs_binh).BeginInit();
            SuspendLayout();
            // 
            // gb_binh
            // 
            gb_binh.Controls.Add(dgv_HthiDs_binh);
            gb_binh.Dock = DockStyle.Bottom;
            gb_binh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gb_binh.Location = new Point(0, 189);
            gb_binh.Name = "gb_binh";
            gb_binh.Size = new Size(918, 335);
            gb_binh.TabIndex = 21;
            gb_binh.TabStop = false;
            gb_binh.Text = "Danh sách thông tin sổ tiết kiệm";
            // 
            // dgv_HthiDs_binh
            // 
            dgv_HthiDs_binh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HthiDs_binh.Location = new Point(10, 22);
            dgv_HthiDs_binh.Name = "dgv_HthiDs_binh";
            dgv_HthiDs_binh.RowHeadersWidth = 51;
            dgv_HthiDs_binh.RowTemplate.Height = 24;
            dgv_HthiDs_binh.Size = new Size(902, 301);
            dgv_HthiDs_binh.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(467, 96);
            label2.Name = "label2";
            label2.Size = new Size(183, 33);
            label2.TabIndex = 24;
            label2.Text = "Thời gian mở sổ :";
            // 
            // cb_tgmodc_binh
            // 
            cb_tgmodc_binh.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cb_tgmodc_binh.FormattingEnabled = true;
            cb_tgmodc_binh.Items.AddRange(new object[] { "1 Tháng", "3 Tháng", "6 Tháng", "1 Năm", "2 Năm", "3 Năm" });
            cb_tgmodc_binh.Location = new Point(668, 91);
            cb_tgmodc_binh.Name = "cb_tgmodc_binh";
            cb_tgmodc_binh.Size = new Size(160, 37);
            cb_tgmodc_binh.TabIndex = 23;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(918, 59);
            label1.TabIndex = 20;
            label1.Text = "Thống Kê Sổ Tiết Kiệm Vừa Gửi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_xuat_binh
            // 
            bt_xuat_binh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_xuat_binh.Location = new Point(240, 80);
            bt_xuat_binh.Name = "bt_xuat_binh";
            bt_xuat_binh.Size = new Size(148, 59);
            bt_xuat_binh.TabIndex = 22;
            bt_xuat_binh.Text = "Xuất báo cáo";
            bt_xuat_binh.UseVisualStyleBackColor = true;
            bt_xuat_binh.Click += bt_xuat_binh_Click_1;
            // 
            // bt_thongke_binh
            // 
            bt_thongke_binh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_thongke_binh.Location = new Point(36, 80);
            bt_thongke_binh.Name = "bt_thongke_binh";
            bt_thongke_binh.Size = new Size(148, 59);
            bt_thongke_binh.TabIndex = 19;
            bt_thongke_binh.Text = "Thống kê";
            bt_thongke_binh.UseVisualStyleBackColor = true;
            bt_thongke_binh.Click += bt_thongke_binh_Click_1;
            // 
            // frm_ThongKe_Binh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 524);
            Controls.Add(gb_binh);
            Controls.Add(label2);
            Controls.Add(cb_tgmodc_binh);
            Controls.Add(label1);
            Controls.Add(bt_xuat_binh);
            Controls.Add(bt_thongke_binh);
            Name = "frm_ThongKe_Binh";
            Text = "frm_ThongKe_Binh";
            Load += frm_ThongKe_Binh_Load;
            gb_binh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HthiDs_binh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_binh;
        private DataGridView dgv_HthiDs_binh;
        private Label label2;
        private ComboBox cb_tgmodc_binh;
        private Label label1;
        private Button bt_xuat_binh;
        private Button bt_thongke_binh;
    }
}