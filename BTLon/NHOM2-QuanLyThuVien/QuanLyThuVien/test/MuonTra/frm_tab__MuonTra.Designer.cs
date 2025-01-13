namespace test
{
    partial class frm_tab__MuonTra
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tab__MuonTra));
            panel7 = new Panel();
            btnTraSach = new Button();
            imageList1 = new ImageList(components);
            pictureBox6 = new PictureBox();
            panel6 = new Panel();
            btnMuonSach = new Button();
            pictureBox5 = new PictureBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(btnTraSach);
            panel7.Controls.Add(pictureBox6);
            panel7.Location = new Point(22, 229);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 168);
            panel7.TabIndex = 8;
            // 
            // btnTraSach
            // 
            btnTraSach.BackColor = Color.Green;
            btnTraSach.Dock = DockStyle.Bottom;
            btnTraSach.FlatStyle = FlatStyle.Flat;
            btnTraSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnTraSach.ImageIndex = 0;
            btnTraSach.ImageList = imageList1;
            btnTraSach.Location = new Point(0, 114);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(200, 54);
            btnTraSach.TabIndex = 5;
            btnTraSach.Text = "TRẢ SÁCH";
            btnTraSach.TextAlign = ContentAlignment.MiddleRight;
            btnTraSach.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "CaRo - Copy.png");
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Top;
            pictureBox6.Image = Properties.Resources.CaRo___Copy;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(200, 114);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnMuonSach);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(22, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 168);
            panel6.TabIndex = 7;
            // 
            // btnMuonSach
            // 
            btnMuonSach.BackColor = Color.Green;
            btnMuonSach.Dock = DockStyle.Bottom;
            btnMuonSach.FlatStyle = FlatStyle.Flat;
            btnMuonSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMuonSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnMuonSach.ImageIndex = 0;
            btnMuonSach.ImageList = imageList1;
            btnMuonSach.Location = new Point(0, 114);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(200, 54);
            btnMuonSach.TabIndex = 4;
            btnMuonSach.Text = "MƯỢN SÁCH";
            btnMuonSach.TextAlign = ContentAlignment.MiddleRight;
            btnMuonSach.UseVisualStyleBackColor = false;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Top;
            pictureBox5.Image = Properties.Resources.CaRo___Copy;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 114);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // frm_tab__MuonTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 495);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Name = "frm_tab__MuonTra";
            Text = "frm_tab__MuonTra";
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private PictureBox pictureBox6;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Button btnMuonSach;
        private ImageList imageList1;
        private Button btnTraSach;
    }
}