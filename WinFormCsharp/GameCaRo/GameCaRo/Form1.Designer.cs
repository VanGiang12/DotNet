namespace GameCaRo
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
            pnBanCo = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnEnter = new Button();
            txtIP = new TextBox();
            prgbTime = new ProgressBar();
            txtName = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnBanCo
            // 
            pnBanCo.Location = new Point(0, 0);
            pnBanCo.Name = "pnBanCo";
            pnBanCo.Size = new Size(514, 536);
            pnBanCo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(514, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 212);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.CaRo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(242, 212);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnEnter);
            panel3.Controls.Add(txtIP);
            panel3.Controls.Add(prgbTime);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(514, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 303);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 140);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 5;
            label1.Text = "5 in a line to win";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(126, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 110);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnter.Location = new Point(6, 93);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(114, 23);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Bắt Đầu";
            btnEnter.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            txtIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIP.Location = new Point(6, 64);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(114, 23);
            txtIP.TabIndex = 2;
            // 
            // prgbTime
            // 
            prgbTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            prgbTime.Location = new Point(6, 35);
            prgbTime.Name = "prgbTime";
            prgbTime.Size = new Size(114, 23);
            prgbTime.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(6, 6);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(114, 23);
            txtName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 540);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnBanCo);
            Name = "Form1";
            Text = "Game CaRo";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBanCo;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnEnter;
        private TextBox txtIP;
        private ProgressBar prgbTime;
        private TextBox txtName;
        private PictureBox pictureBox2;
    }
}