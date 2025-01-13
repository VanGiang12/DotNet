namespace XuLyChuoi_B36
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
            txtDuLieuGoc = new TextBox();
            groupBox2 = new GroupBox();
            txtKetQua = new TextBox();
            btnSoKyTuChuoi = new Button();
            btnInHoa = new Button();
            btnInThuong = new Button();
            btnDemInHoa = new Button();
            btnDemInThuong = new Button();
            btnDemKyTuSo = new Button();
            btnDaoChuoi = new Button();
            btnToiUuChuoi = new Button();
            btnTimViTriXuatHienDauTien = new Button();
            btnTimViTriXuatHienCuoiCung = new Button();
            btnDemSoLanXuatHien = new Button();
            btnTachTu = new Button();
            btnThayChuoiCon = new Button();
            btnXoaChuoiCon = new Button();
            btnChenChuoi = new Button();
            btnTrichLoc = new Button();
            txtVTXuatHienDauTien = new TextBox();
            txtVTXuatHienCuoiCung = new TextBox();
            txtDemSoLanXuatHien = new TextBox();
            txtTachTu = new TextBox();
            txtChuoiMoi = new TextBox();
            txtXoaChuoiCon = new TextBox();
            txtChenChuoiTaiVT = new TextBox();
            label1 = new Label();
            txtChenChuoi = new TextBox();
            label2 = new Label();
            txtTrichLocVT1 = new TextBox();
            label3 = new Label();
            txtTrichLocVT2 = new TextBox();
            txtChuoiCu = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDuLieuGoc);
            groupBox1.ForeColor = Color.FromArgb(255, 255, 128);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dữ Liệu Gốc";
            // 
            // txtDuLieuGoc
            // 
            txtDuLieuGoc.Dock = DockStyle.Fill;
            txtDuLieuGoc.Location = new Point(3, 19);
            txtDuLieuGoc.Multiline = true;
            txtDuLieuGoc.Name = "txtDuLieuGoc";
            txtDuLieuGoc.Size = new Size(225, 78);
            txtDuLieuGoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKetQua);
            groupBox2.ForeColor = Color.FromArgb(255, 255, 128);
            groupBox2.Location = new Point(252, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kêt quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Dock = DockStyle.Fill;
            txtKetQua.Location = new Point(3, 19);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(251, 78);
            txtKetQua.TabIndex = 0;
            // 
            // btnSoKyTuChuoi
            // 
            btnSoKyTuChuoi.BackColor = Color.WhiteSmoke;
            btnSoKyTuChuoi.ForeColor = Color.Red;
            btnSoKyTuChuoi.Location = new Point(12, 118);
            btnSoKyTuChuoi.Name = "btnSoKyTuChuoi";
            btnSoKyTuChuoi.Size = new Size(231, 23);
            btnSoKyTuChuoi.TabIndex = 1;
            btnSoKyTuChuoi.Text = "Số ký tự trong chuỗi";
            btnSoKyTuChuoi.UseVisualStyleBackColor = false;
            btnSoKyTuChuoi.Click += btnSoKyTuChuoi_Click;
            // 
            // btnInHoa
            // 
            btnInHoa.BackColor = Color.WhiteSmoke;
            btnInHoa.ForeColor = Color.Red;
            btnInHoa.Location = new Point(12, 147);
            btnInHoa.Name = "btnInHoa";
            btnInHoa.Size = new Size(231, 23);
            btnInHoa.TabIndex = 2;
            btnInHoa.Text = "In chữ hoa";
            btnInHoa.UseVisualStyleBackColor = false;
            btnInHoa.Click += btnInHoa_Click;
            // 
            // btnInThuong
            // 
            btnInThuong.BackColor = Color.WhiteSmoke;
            btnInThuong.ForeColor = Color.Red;
            btnInThuong.Location = new Point(12, 176);
            btnInThuong.Name = "btnInThuong";
            btnInThuong.Size = new Size(231, 23);
            btnInThuong.TabIndex = 3;
            btnInThuong.Text = "In chữ thường";
            btnInThuong.UseVisualStyleBackColor = false;
            btnInThuong.Click += btnInThuong_Click;
            // 
            // btnDemInHoa
            // 
            btnDemInHoa.BackColor = Color.WhiteSmoke;
            btnDemInHoa.ForeColor = Color.Red;
            btnDemInHoa.Location = new Point(12, 205);
            btnDemInHoa.Name = "btnDemInHoa";
            btnDemInHoa.Size = new Size(231, 23);
            btnDemInHoa.TabIndex = 4;
            btnDemInHoa.Text = "Đếm số ký tự in hoa";
            btnDemInHoa.UseVisualStyleBackColor = false;
            btnDemInHoa.Click += btnDemInHoa_Click;
            // 
            // btnDemInThuong
            // 
            btnDemInThuong.BackColor = Color.WhiteSmoke;
            btnDemInThuong.ForeColor = Color.Red;
            btnDemInThuong.Location = new Point(12, 234);
            btnDemInThuong.Name = "btnDemInThuong";
            btnDemInThuong.Size = new Size(231, 23);
            btnDemInThuong.TabIndex = 5;
            btnDemInThuong.Text = "Đếm số ký tự in thường";
            btnDemInThuong.UseVisualStyleBackColor = false;
            btnDemInThuong.Click += btnDemInThuong_Click;
            // 
            // btnDemKyTuSo
            // 
            btnDemKyTuSo.BackColor = Color.WhiteSmoke;
            btnDemKyTuSo.ForeColor = Color.Red;
            btnDemKyTuSo.Location = new Point(12, 263);
            btnDemKyTuSo.Name = "btnDemKyTuSo";
            btnDemKyTuSo.Size = new Size(231, 23);
            btnDemKyTuSo.TabIndex = 6;
            btnDemKyTuSo.Text = "Đếm ký tự là số";
            btnDemKyTuSo.UseVisualStyleBackColor = false;
            btnDemKyTuSo.Click += btnDemKyTuSo_Click;
            // 
            // btnDaoChuoi
            // 
            btnDaoChuoi.BackColor = Color.WhiteSmoke;
            btnDaoChuoi.ForeColor = Color.Red;
            btnDaoChuoi.Location = new Point(12, 292);
            btnDaoChuoi.Name = "btnDaoChuoi";
            btnDaoChuoi.Size = new Size(231, 23);
            btnDaoChuoi.TabIndex = 7;
            btnDaoChuoi.Text = "Đảo chuỗi";
            btnDaoChuoi.UseVisualStyleBackColor = false;
            btnDaoChuoi.Click += btnDaoChuoi_Click;
            // 
            // btnToiUuChuoi
            // 
            btnToiUuChuoi.BackColor = Color.WhiteSmoke;
            btnToiUuChuoi.ForeColor = Color.Red;
            btnToiUuChuoi.Location = new Point(12, 321);
            btnToiUuChuoi.Name = "btnToiUuChuoi";
            btnToiUuChuoi.Size = new Size(231, 23);
            btnToiUuChuoi.TabIndex = 8;
            btnToiUuChuoi.Text = "Tối ưu chuỗi";
            btnToiUuChuoi.UseVisualStyleBackColor = false;
            btnToiUuChuoi.Click += btnToiUuChuoi_Click;
            // 
            // btnTimViTriXuatHienDauTien
            // 
            btnTimViTriXuatHienDauTien.BackColor = Color.WhiteSmoke;
            btnTimViTriXuatHienDauTien.ForeColor = Color.Red;
            btnTimViTriXuatHienDauTien.Location = new Point(252, 118);
            btnTimViTriXuatHienDauTien.Name = "btnTimViTriXuatHienDauTien";
            btnTimViTriXuatHienDauTien.Size = new Size(170, 23);
            btnTimViTriXuatHienDauTien.TabIndex = 10;
            btnTimViTriXuatHienDauTien.Text = "Tìm vị trí xuất hiện đầu tiên";
            btnTimViTriXuatHienDauTien.UseVisualStyleBackColor = false;
            btnTimViTriXuatHienDauTien.Click += btnTimViTriXuatHienDauTien_Click;
            // 
            // btnTimViTriXuatHienCuoiCung
            // 
            btnTimViTriXuatHienCuoiCung.BackColor = Color.WhiteSmoke;
            btnTimViTriXuatHienCuoiCung.ForeColor = Color.Red;
            btnTimViTriXuatHienCuoiCung.Location = new Point(252, 147);
            btnTimViTriXuatHienCuoiCung.Name = "btnTimViTriXuatHienCuoiCung";
            btnTimViTriXuatHienCuoiCung.Size = new Size(170, 23);
            btnTimViTriXuatHienCuoiCung.TabIndex = 12;
            btnTimViTriXuatHienCuoiCung.Text = "Tìm vị trí xuất hiện cuối cùng";
            btnTimViTriXuatHienCuoiCung.UseVisualStyleBackColor = false;
            btnTimViTriXuatHienCuoiCung.Click += btnTimViTriXuatHienCuoiCung_Click;
            // 
            // btnDemSoLanXuatHien
            // 
            btnDemSoLanXuatHien.BackColor = Color.WhiteSmoke;
            btnDemSoLanXuatHien.ForeColor = Color.Red;
            btnDemSoLanXuatHien.Location = new Point(252, 176);
            btnDemSoLanXuatHien.Name = "btnDemSoLanXuatHien";
            btnDemSoLanXuatHien.Size = new Size(170, 23);
            btnDemSoLanXuatHien.TabIndex = 14;
            btnDemSoLanXuatHien.Text = "Đếm số lần xuất hiện";
            btnDemSoLanXuatHien.UseVisualStyleBackColor = false;
            btnDemSoLanXuatHien.Click += btnDemSoLanXuatHien_Click;
            // 
            // btnTachTu
            // 
            btnTachTu.BackColor = Color.WhiteSmoke;
            btnTachTu.ForeColor = Color.Red;
            btnTachTu.Location = new Point(252, 205);
            btnTachTu.Name = "btnTachTu";
            btnTachTu.Size = new Size(170, 23);
            btnTachTu.TabIndex = 16;
            btnTachTu.Text = "Tách từ";
            btnTachTu.UseVisualStyleBackColor = false;
            btnTachTu.Click += btnTachTu_Click;
            // 
            // btnThayChuoiCon
            // 
            btnThayChuoiCon.BackColor = Color.WhiteSmoke;
            btnThayChuoiCon.ForeColor = Color.Red;
            btnThayChuoiCon.Location = new Point(252, 234);
            btnThayChuoiCon.Name = "btnThayChuoiCon";
            btnThayChuoiCon.Size = new Size(94, 23);
            btnThayChuoiCon.TabIndex = 18;
            btnThayChuoiCon.Text = "Thay đổi chuỗi con";
            btnThayChuoiCon.UseVisualStyleBackColor = false;
            btnThayChuoiCon.Click += btnThayChuoiCon_Click;
            // 
            // btnXoaChuoiCon
            // 
            btnXoaChuoiCon.BackColor = Color.WhiteSmoke;
            btnXoaChuoiCon.ForeColor = Color.Red;
            btnXoaChuoiCon.Location = new Point(252, 263);
            btnXoaChuoiCon.Name = "btnXoaChuoiCon";
            btnXoaChuoiCon.Size = new Size(170, 23);
            btnXoaChuoiCon.TabIndex = 20;
            btnXoaChuoiCon.Text = "Xóa chuỗi con";
            btnXoaChuoiCon.UseVisualStyleBackColor = false;
            btnXoaChuoiCon.Click += btnXoaChuoiCon_Click;
            // 
            // btnChenChuoi
            // 
            btnChenChuoi.BackColor = Color.WhiteSmoke;
            btnChenChuoi.ForeColor = Color.Red;
            btnChenChuoi.Location = new Point(252, 291);
            btnChenChuoi.Name = "btnChenChuoi";
            btnChenChuoi.Size = new Size(84, 23);
            btnChenChuoi.TabIndex = 22;
            btnChenChuoi.Text = "Chèn chuỗi";
            btnChenChuoi.UseVisualStyleBackColor = false;
            btnChenChuoi.Click += btnChenChuoi_Click;
            // 
            // btnTrichLoc
            // 
            btnTrichLoc.BackColor = Color.WhiteSmoke;
            btnTrichLoc.ForeColor = Color.Red;
            btnTrichLoc.Location = new Point(252, 321);
            btnTrichLoc.Name = "btnTrichLoc";
            btnTrichLoc.Size = new Size(84, 23);
            btnTrichLoc.TabIndex = 26;
            btnTrichLoc.Text = "Trích lọc";
            btnTrichLoc.UseVisualStyleBackColor = false;
            btnTrichLoc.Click += btnTrichLoc_Click;
            // 
            // txtVTXuatHienDauTien
            // 
            txtVTXuatHienDauTien.Location = new Point(428, 119);
            txtVTXuatHienDauTien.Name = "txtVTXuatHienDauTien";
            txtVTXuatHienDauTien.Size = new Size(81, 23);
            txtVTXuatHienDauTien.TabIndex = 11;
            // 
            // txtVTXuatHienCuoiCung
            // 
            txtVTXuatHienCuoiCung.Location = new Point(428, 147);
            txtVTXuatHienCuoiCung.Name = "txtVTXuatHienCuoiCung";
            txtVTXuatHienCuoiCung.Size = new Size(81, 23);
            txtVTXuatHienCuoiCung.TabIndex = 13;
            // 
            // txtDemSoLanXuatHien
            // 
            txtDemSoLanXuatHien.Location = new Point(428, 176);
            txtDemSoLanXuatHien.Name = "txtDemSoLanXuatHien";
            txtDemSoLanXuatHien.Size = new Size(81, 23);
            txtDemSoLanXuatHien.TabIndex = 15;
            // 
            // txtTachTu
            // 
            txtTachTu.Location = new Point(428, 205);
            txtTachTu.Name = "txtTachTu";
            txtTachTu.Size = new Size(81, 23);
            txtTachTu.TabIndex = 17;
            // 
            // txtChuoiMoi
            // 
            txtChuoiMoi.Location = new Point(428, 235);
            txtChuoiMoi.Name = "txtChuoiMoi";
            txtChuoiMoi.Size = new Size(81, 23);
            txtChuoiMoi.TabIndex = 19;
            // 
            // txtXoaChuoiCon
            // 
            txtXoaChuoiCon.Location = new Point(428, 263);
            txtXoaChuoiCon.Name = "txtXoaChuoiCon";
            txtXoaChuoiCon.Size = new Size(81, 23);
            txtXoaChuoiCon.TabIndex = 21;
            // 
            // txtChenChuoiTaiVT
            // 
            txtChenChuoiTaiVT.Location = new Point(474, 288);
            txtChenChuoiTaiVT.Name = "txtChenChuoiTaiVT";
            txtChenChuoiTaiVT.Size = new Size(35, 23);
            txtChenChuoiTaiVT.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(428, 296);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 24;
            label1.Text = "Vị trí";
            // 
            // txtChenChuoi
            // 
            txtChenChuoi.Location = new Point(342, 288);
            txtChenChuoi.Name = "txtChenChuoi";
            txtChenChuoi.Size = new Size(80, 23);
            txtChenChuoi.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(343, 325);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 27;
            label2.Text = "Vị trí 1";
            // 
            // txtTrichLocVT1
            // 
            txtTrichLocVT1.Location = new Point(387, 317);
            txtTrichLocVT1.Name = "txtTrichLocVT1";
            txtTrichLocVT1.Size = new Size(35, 23);
            txtTrichLocVT1.TabIndex = 28;
            txtTrichLocVT1.TextChanged += textBox9_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(428, 325);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 29;
            label3.Text = "Vị trí 2";
            // 
            // txtTrichLocVT2
            // 
            txtTrichLocVT2.Location = new Point(474, 317);
            txtTrichLocVT2.Name = "txtTrichLocVT2";
            txtTrichLocVT2.Size = new Size(35, 23);
            txtTrichLocVT2.TabIndex = 30;
            txtTrichLocVT2.TextChanged += textBox9_TextChanged;
            // 
            // txtChuoiCu
            // 
            txtChuoiCu.Location = new Point(352, 234);
            txtChuoiCu.Name = "txtChuoiCu";
            txtChuoiCu.Size = new Size(70, 23);
            txtChuoiCu.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(521, 354);
            Controls.Add(txtTrichLocVT2);
            Controls.Add(txtTrichLocVT1);
            Controls.Add(txtChenChuoi);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtChenChuoiTaiVT);
            Controls.Add(txtXoaChuoiCon);
            Controls.Add(txtChuoiCu);
            Controls.Add(txtChuoiMoi);
            Controls.Add(txtTachTu);
            Controls.Add(txtDemSoLanXuatHien);
            Controls.Add(txtVTXuatHienCuoiCung);
            Controls.Add(txtVTXuatHienDauTien);
            Controls.Add(btnTrichLoc);
            Controls.Add(btnToiUuChuoi);
            Controls.Add(btnChenChuoi);
            Controls.Add(btnDaoChuoi);
            Controls.Add(btnXoaChuoiCon);
            Controls.Add(btnDemKyTuSo);
            Controls.Add(btnThayChuoiCon);
            Controls.Add(btnDemInThuong);
            Controls.Add(btnTachTu);
            Controls.Add(btnDemSoLanXuatHien);
            Controls.Add(btnDemInHoa);
            Controls.Add(btnTimViTriXuatHienCuoiCung);
            Controls.Add(btnInThuong);
            Controls.Add(btnTimViTriXuatHienDauTien);
            Controls.Add(btnInHoa);
            Controls.Add(btnSoKyTuChuoi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Các hàm xử lý chuỗi";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSoKyTuChuoi;
        private Button btnInHoa;
        private Button btnInThuong;
        private Button btnDemInHoa;
        private Button btnDemInThuong;
        private Button btnDemKyTuSo;
        private Button btnDaoChuoi;
        private Button btnToiUuChuoi;
        private Button btnTimViTriXuatHienDauTien;
        private Button btnTimViTriXuatHienCuoiCung;
        private Button btnDemSoLanXuatHien;
        private Button btnTachTu;
        private Button btnThayChuoiCon;
        private Button btnXoaChuoiCon;
        private Button btnChenChuoi;
        private Button btnTrichLoc;
        private TextBox txtVTXuatHienDauTien;
        private TextBox txtVTXuatHienCuoiCung;
        private TextBox txtDemSoLanXuatHien;
        private TextBox txtTachTu;
        private TextBox txtChuoiMoi;
        private TextBox txtXoaChuoiCon;
        private TextBox txtChenChuoiTaiVT;
        private Label label1;
        private TextBox txtChenChuoi;
        private Label label2;
        private TextBox txtTrichLocVT1;
        private Label label3;
        private TextBox txtDuLieuGoc;
        private TextBox txtKetQua;
        private TextBox txtTrichLocVT2;
        private TextBox txtChuoiCu;
    }
}