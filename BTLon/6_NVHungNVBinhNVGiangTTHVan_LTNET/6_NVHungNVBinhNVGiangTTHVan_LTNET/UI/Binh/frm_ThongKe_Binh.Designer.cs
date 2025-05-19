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
            this.gb_binh = new System.Windows.Forms.GroupBox();
            this.dgv_HthiDs_binh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tgmodc_binh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xuat_binh = new System.Windows.Forms.Button();
            this.bt_thongke_binh = new System.Windows.Forms.Button();
            this.gb_binh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HthiDs_binh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_binh
            // 
            this.gb_binh.Controls.Add(this.dgv_HthiDs_binh);
            this.gb_binh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_binh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_binh.Location = new System.Drawing.Point(0, 214);
            this.gb_binh.Name = "gb_binh";
            this.gb_binh.Size = new System.Drawing.Size(1049, 344);
            this.gb_binh.TabIndex = 21;
            this.gb_binh.TabStop = false;
            this.gb_binh.Text = "Danh sách thông tin sổ tiết kiệm";
            // 
            // dgv_HthiDs_binh
            // 
            this.dgv_HthiDs_binh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HthiDs_binh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HthiDs_binh.Location = new System.Drawing.Point(3, 20);
            this.dgv_HthiDs_binh.Name = "dgv_HthiDs_binh";
            this.dgv_HthiDs_binh.RowHeadersWidth = 51;
            this.dgv_HthiDs_binh.RowTemplate.Height = 24;
            this.dgv_HthiDs_binh.Size = new System.Drawing.Size(1043, 321);
            this.dgv_HthiDs_binh.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 35);
            this.label2.TabIndex = 24;
            this.label2.Text = "Thời gian mở sổ :";
            // 
            // cb_tgmodc_binh
            // 
            this.cb_tgmodc_binh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tgmodc_binh.FormattingEnabled = true;
            this.cb_tgmodc_binh.Items.AddRange(new object[] {
            "1 Tháng",
            "3 Tháng",
            "6 Tháng",
            "1 Năm",
            "2 Năm",
            "3 Năm"});
            this.cb_tgmodc_binh.Location = new System.Drawing.Point(744, 113);
            this.cb_tgmodc_binh.Name = "cb_tgmodc_binh";
            this.cb_tgmodc_binh.Size = new System.Drawing.Size(182, 44);
            this.cb_tgmodc_binh.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1049, 63);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thống Kê Sổ Tiết Kiệm Vừa Gửi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_xuat_binh
            // 
            this.bt_xuat_binh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xuat_binh.Location = new System.Drawing.Point(276, 104);
            this.bt_xuat_binh.Name = "bt_xuat_binh";
            this.bt_xuat_binh.Size = new System.Drawing.Size(169, 63);
            this.bt_xuat_binh.TabIndex = 22;
            this.bt_xuat_binh.Text = "Xuất báo cáo";
            this.bt_xuat_binh.UseVisualStyleBackColor = true;
            this.bt_xuat_binh.Click += new System.EventHandler(this.bt_xuat_binh_Click_1);
            // 
            // bt_thongke_binh
            // 
            this.bt_thongke_binh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thongke_binh.Location = new System.Drawing.Point(62, 104);
            this.bt_thongke_binh.Name = "bt_thongke_binh";
            this.bt_thongke_binh.Size = new System.Drawing.Size(169, 63);
            this.bt_thongke_binh.TabIndex = 19;
            this.bt_thongke_binh.Text = "Thống kê";
            this.bt_thongke_binh.UseVisualStyleBackColor = true;
            this.bt_thongke_binh.Click += new System.EventHandler(this.bt_thongke_binh_Click_1);
            // 
            // frm_ThongKe_Binh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 558);
            this.Controls.Add(this.gb_binh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_tgmodc_binh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_xuat_binh);
            this.Controls.Add(this.bt_thongke_binh);
            this.Name = "frm_ThongKe_Binh";
            this.Text = "frm_ThongKe_Binh";
            this.gb_binh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HthiDs_binh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_binh;
        private System.Windows.Forms.DataGridView dgv_HthiDs_binh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tgmodc_binh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xuat_binh;
        private System.Windows.Forms.Button bt_thongke_binh;
    }
}