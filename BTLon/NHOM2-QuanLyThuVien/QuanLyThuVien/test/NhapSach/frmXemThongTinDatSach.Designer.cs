namespace test.NhapSach
{
    partial class frmXemThongTinDatSach
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
            lblMaPhieu = new Label();
            lblDonViMua = new Label();
            lblNgayDat = new Label();
            lblTongSoLuong = new Label();
            panel1 = new Panel();
            dgvDSPhieu = new DataGridView();
            lblNXB = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieu).BeginInit();
            SuspendLayout();
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaPhieu.Location = new Point(317, 9);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(88, 21);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "MÃ PHIẾU";
            // 
            // lblDonViMua
            // 
            lblDonViMua.AutoSize = true;
            lblDonViMua.Location = new Point(51, 49);
            lblDonViMua.Name = "lblDonViMua";
            lblDonViMua.Size = new Size(82, 15);
            lblDonViMua.TabIndex = 1;
            lblDonViMua.Text = "ĐƠN VỊ MUA: ";
            // 
            // lblNgayDat
            // 
            lblNgayDat.AutoSize = true;
            lblNgayDat.Location = new Point(524, 49);
            lblNgayDat.Name = "lblNgayDat";
            lblNgayDat.Size = new Size(69, 15);
            lblNgayDat.TabIndex = 2;
            lblNgayDat.Text = "NGÀY ĐẶT: ";
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.AutoSize = true;
            lblTongSoLuong.Location = new Point(51, 93);
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(100, 15);
            lblTongSoLuong.TabIndex = 3;
            lblTongSoLuong.Text = "TỔNG SỐ LƯỢNG";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDSPhieu);
            panel1.Location = new Point(12, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 183);
            panel1.TabIndex = 5;
            // 
            // dgvDSPhieu
            // 
            dgvDSPhieu.AllowUserToAddRows = false;
            dgvDSPhieu.AllowUserToDeleteRows = false;
            dgvDSPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhieu.Dock = DockStyle.Fill;
            dgvDSPhieu.Location = new Point(0, 0);
            dgvDSPhieu.Name = "dgvDSPhieu";
            dgvDSPhieu.ReadOnly = true;
            dgvDSPhieu.RowHeadersVisible = false;
            dgvDSPhieu.RowHeadersWidth = 51;
            dgvDSPhieu.RowTemplate.Height = 25;
            dgvDSPhieu.Size = new Size(743, 183);
            dgvDSPhieu.TabIndex = 0;
            // 
            // lblNXB
            // 
            lblNXB.AutoSize = true;
            lblNXB.Location = new Point(277, 49);
            lblNXB.Name = "lblNXB";
            lblNXB.Size = new Size(98, 15);
            lblNXB.TabIndex = 6;
            lblNXB.Text = "NHÀ XUẤT BẢN: ";
            // 
            // frmXemThongTinDatSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(766, 395);
            Controls.Add(lblNXB);
            Controls.Add(panel1);
            Controls.Add(lblTongSoLuong);
            Controls.Add(lblNgayDat);
            Controls.Add(lblDonViMua);
            Controls.Add(lblMaPhieu);
            ForeColor = Color.Black;
            MaximumSize = new Size(782, 434);
            MinimumSize = new Size(782, 434);
            Name = "frmXemThongTinDatSach";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmXemThongTinDatSach_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSPhieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaPhieu;
        private Label lblDonViMua;
        private Label lblNgayDat;
        private Label lblTongSoLuong;
        private Panel panel1;
        private DataGridView dgvDSPhieu;
        private Label lblNXB;
    }
}