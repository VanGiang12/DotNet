namespace Bai21
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
            comboBoxCapNhat = new ComboBox();
            btnCapNhat = new Button();
            txtNhap = new TextBox();
            groupBox2 = new GroupBox();
            btnKtraSoNguyenTo = new Button();
            btnSoLuongUocSoChan = new Button();
            btnTongUoc = new Button();
            listBoxDisplay = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCapNhat);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(txtNhap);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 106);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập dữ liệu";
            // 
            // comboBoxCapNhat
            // 
            comboBoxCapNhat.FormattingEnabled = true;
            comboBoxCapNhat.Location = new Point(7, 64);
            comboBoxCapNhat.Name = "comboBoxCapNhat";
            comboBoxCapNhat.Size = new Size(188, 23);
            comboBoxCapNhat.TabIndex = 2;
            comboBoxCapNhat.SelectedIndexChanged += comboBoxCapNhat_SelectedIndexChanged;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(119, 25);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(6, 25);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(100, 23);
            txtNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKtraSoNguyenTo);
            groupBox2.Controls.Add(btnSoLuongUocSoChan);
            groupBox2.Controls.Add(btnTongUoc);
            groupBox2.Controls.Add(listBoxDisplay);
            groupBox2.Location = new Point(231, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết";
            // 
            // btnKtraSoNguyenTo
            // 
            btnKtraSoNguyenTo.Location = new Point(6, 175);
            btnKtraSoNguyenTo.Name = "btnKtraSoNguyenTo";
            btnKtraSoNguyenTo.Size = new Size(182, 23);
            btnKtraSoNguyenTo.TabIndex = 3;
            btnKtraSoNguyenTo.Text = "Kiểm tra số nguyên tố";
            btnKtraSoNguyenTo.UseVisualStyleBackColor = true;
            btnKtraSoNguyenTo.Click += btnKtraSoNguyenTo_Click;
            // 
            // btnSoLuongUocSoChan
            // 
            btnSoLuongUocSoChan.Location = new Point(6, 146);
            btnSoLuongUocSoChan.Name = "btnSoLuongUocSoChan";
            btnSoLuongUocSoChan.Size = new Size(182, 23);
            btnSoLuongUocSoChan.TabIndex = 2;
            btnSoLuongUocSoChan.Text = "Số lượng ước số chẵn";
            btnSoLuongUocSoChan.UseVisualStyleBackColor = true;
            btnSoLuongUocSoChan.Click += btnSoLuongUocSoChan_Click;
            // 
            // btnTongUoc
            // 
            btnTongUoc.Location = new Point(6, 117);
            btnTongUoc.Name = "btnTongUoc";
            btnTongUoc.Size = new Size(182, 23);
            btnTongUoc.TabIndex = 1;
            btnTongUoc.Text = "Tổng các ước số";
            btnTongUoc.UseVisualStyleBackColor = true;
            btnTongUoc.Click += btnTongUoc_Click;
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.ItemHeight = 15;
            listBoxDisplay.Location = new Point(6, 22);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(180, 79);
            listBoxDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 259);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxCapNhat;
        private Button btnCapNhat;
        private TextBox txtNhap;
        private GroupBox groupBox2;
        private Button btnKtraSoNguyenTo;
        private Button btnSoLuongUocSoChan;
        private Button btnTongUoc;
        private ListBox listBoxDisplay;
    }
}