namespace Cau3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtNS = new TextBox();
            txtQueQuan = new TextBox();
            btnDau = new Button();
            btnTruoc = new Button();
            btnSau = new Button();
            btnCuoi = new Button();
            btnThem = new Button();
            btnTim = new Button();
            btnUpdate = new Button();
            btnThoat = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(490, 23);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ BÓNG ĐÁ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Brown;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 23);
            label2.Name = "label2";
            label2.Size = new Size(490, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 65);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "mã";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 108);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 144);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 181);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 5;
            label6.Text = "Quê quán";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(98, 66);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(362, 23);
            txtMa.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(98, 105);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(362, 23);
            txtTen.TabIndex = 7;
            // 
            // txtNS
            // 
            txtNS.Location = new Point(98, 136);
            txtNS.Name = "txtNS";
            txtNS.Size = new Size(362, 23);
            txtNS.TabIndex = 8;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(98, 173);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(362, 23);
            txtQueQuan.TabIndex = 9;
            // 
            // btnDau
            // 
            btnDau.Location = new Point(74, 219);
            btnDau.Name = "btnDau";
            btnDau.Size = new Size(75, 23);
            btnDau.TabIndex = 10;
            btnDau.Text = "|<<";
            btnDau.UseVisualStyleBackColor = true;
            btnDau.Click += btnDau_Click;
            // 
            // btnTruoc
            // 
            btnTruoc.Location = new Point(169, 223);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(75, 23);
            btnTruoc.TabIndex = 11;
            btnTruoc.Text = "<<";
            btnTruoc.UseVisualStyleBackColor = true;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnSau
            // 
            btnSau.Location = new Point(276, 223);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(75, 23);
            btnSau.TabIndex = 12;
            btnSau.Text = ">>";
            btnSau.UseVisualStyleBackColor = true;
            btnSau.Click += btnSau_Click;
            // 
            // btnCuoi
            // 
            btnCuoi.Location = new Point(371, 219);
            btnCuoi.Name = "btnCuoi";
            btnCuoi.Size = new Size(75, 23);
            btnCuoi.TabIndex = 13;
            btnCuoi.Text = ">>|";
            btnCuoi.UseVisualStyleBackColor = true;
            btnCuoi.Click += btnCuoi_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(74, 260);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.ImageIndex = 0;
            btnTim.ImageList = imageList1;
            btnTim.Location = new Point(169, 260);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 23);
            btnTim.TabIndex = 15;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(276, 260);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(371, 260);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "CaRo - Copy.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 333);
            Controls.Add(btnThoat);
            Controls.Add(btnUpdate);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(btnCuoi);
            Controls.Add(btnSau);
            Controls.Add(btnTruoc);
            Controls.Add(btnDau);
            Controls.Add(txtQueQuan);
            Controls.Add(txtNS);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtNS;
        private TextBox txtQueQuan;
        private Button btnDau;
        private Button btnTruoc;
        private Button btnSau;
        private Button btnCuoi;
        private Button btnThem;
        private Button btnTim;
        private Button btnUpdate;
        private Button btnThoat;
        private ImageList imageList1;
    }
}