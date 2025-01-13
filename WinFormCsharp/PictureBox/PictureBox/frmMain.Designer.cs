namespace PictureBox
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblName = new Label();
            txtTen = new TextBox();
            picOn = new System.Windows.Forms.PictureBox();
            picOff = new System.Windows.Forms.PictureBox();
            btnOnorOff = new Button();
            label2 = new Label();
            lblHienthi = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)picOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOff).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(81, 35);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(289, 23);
            txtTen.TabIndex = 1;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // picOn
            // 
            picOn.Image = Properties.Resources.picon;
            picOn.Location = new Point(136, 83);
            picOn.Name = "picOn";
            picOn.Size = new Size(146, 182);
            picOn.SizeMode = PictureBoxSizeMode.Zoom;
            picOn.TabIndex = 2;
            picOn.TabStop = false;
            picOn.Visible = false;
            // 
            // picOff
            // 
            picOff.Image = (Image)resources.GetObject("picOff.Image");
            picOff.Location = new Point(137, 83);
            picOff.Name = "picOff";
            picOff.Size = new Size(146, 182);
            picOff.SizeMode = PictureBoxSizeMode.Zoom;
            picOff.TabIndex = 2;
            picOff.TabStop = false;
            // 
            // btnOnorOff
            // 
            btnOnorOff.Location = new Point(111, 284);
            btnOnorOff.Name = "btnOnorOff";
            btnOnorOff.Size = new Size(189, 23);
            btnOnorOff.TabIndex = 3;
            btnOnorOff.UseVisualStyleBackColor = true;
            btnOnorOff.Click += btnOnorOff_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 315);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Designed by";
            // 
            // lblHienthi
            // 
            lblHienthi.BorderStyle = BorderStyle.FixedSingle;
            lblHienthi.Location = new Point(111, 315);
            lblHienthi.Name = "lblHienthi";
            lblHienthi.Size = new Size(189, 23);
            lblHienthi.TabIndex = 5;
            lblHienthi.Click += txtTen_TextChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(306, 313);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(414, 359);
            Controls.Add(btnThoat);
            Controls.Add(lblHienthi);
            Controls.Add(label2);
            Controls.Add(btnOnorOff);
            Controls.Add(picOff);
            Controls.Add(picOn);
            Controls.Add(txtTen);
            Controls.Add(lblName);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PictureBox";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtTen;
        private System.Windows.Forms.PictureBox picOn;
        private System.Windows.Forms.PictureBox picOff;
        private Button btnOnorOff;
        private Label label2;
        private Label lblHienthi;
        private Button btnThoat;
    }
}