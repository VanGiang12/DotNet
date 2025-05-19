namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET.UI.Giang
{
    partial class frm_ThongTin_Giang
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
            tb_manv_giang = new TextBox();
            tb_tennv_giang = new TextBox();
            label2 = new Label();
            btn_dangxuat_giang = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // tb_manv_giang
            // 
            tb_manv_giang.BorderStyle = BorderStyle.FixedSingle;
            tb_manv_giang.Enabled = false;
            tb_manv_giang.Location = new Point(55, 12);
            tb_manv_giang.Name = "tb_manv_giang";
            tb_manv_giang.Size = new Size(128, 23);
            tb_manv_giang.TabIndex = 1;
            // 
            // tb_tennv_giang
            // 
            tb_tennv_giang.BorderStyle = BorderStyle.FixedSingle;
            tb_tennv_giang.Enabled = false;
            tb_tennv_giang.Location = new Point(55, 58);
            tb_tennv_giang.Name = "tb_tennv_giang";
            tb_tennv_giang.Size = new Size(128, 23);
            tb_tennv_giang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên NV";
            // 
            // btn_dangxuat_giang
            // 
            btn_dangxuat_giang.BackColor = Color.FromArgb(192, 255, 192);
            btn_dangxuat_giang.FlatStyle = FlatStyle.Flat;
            btn_dangxuat_giang.Location = new Point(55, 98);
            btn_dangxuat_giang.Name = "btn_dangxuat_giang";
            btn_dangxuat_giang.Size = new Size(92, 23);
            btn_dangxuat_giang.TabIndex = 4;
            btn_dangxuat_giang.Text = "ĐĂNG XUẤT";
            btn_dangxuat_giang.UseVisualStyleBackColor = false;
            btn_dangxuat_giang.Click += btn_dangxuat_giang_Click;
            // 
            // frm_ThongTin_Giang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(187, 149);
            Controls.Add(btn_dangxuat_giang);
            Controls.Add(tb_tennv_giang);
            Controls.Add(label2);
            Controls.Add(tb_manv_giang);
            Controls.Add(label1);
            Name = "frm_ThongTin_Giang";
            Text = "frm_ThongTin_Giang";
            Load += frm_ThongTin_Giang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_manv_giang;
        private TextBox tb_tennv_giang;
        private Label label2;
        private Button btn_dangxuat_giang;
    }
}