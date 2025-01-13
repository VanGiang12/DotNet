namespace bai3
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
            label1 = new Label();
            input = new TextBox();
            choose = new GroupBox();
            chBSunny = new CheckBox();
            chBSnow = new CheckBox();
            chBRainy = new CheckBox();
            chBCloudy = new CheckBox();
            pCloudy = new PictureBox();
            pRainy = new PictureBox();
            pSnow = new PictureBox();
            pSunny = new PictureBox();
            lbDisplay = new Label();
            btnPrint = new Button();
            btnExit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            choose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pCloudy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pRainy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pSnow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pSunny).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 44);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter your name here";
            label1.TextChanged += label1_TextChanged;
            label1.Click += label1_Click;
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(243, 37);
            input.Name = "input";
            input.Size = new Size(246, 35);
            input.TabIndex = 1;
            input.TextChanged += input_TextChanged;
            // 
            // choose
            // 
            choose.Controls.Add(chBSunny);
            choose.Controls.Add(chBSnow);
            choose.Controls.Add(chBRainy);
            choose.Controls.Add(chBCloudy);
            choose.ForeColor = Color.Red;
            choose.Location = new Point(55, 134);
            choose.Name = "choose";
            choose.Size = new Size(240, 133);
            choose.TabIndex = 2;
            choose.TabStop = false;
            choose.Text = "Choose";
            // 
            // chBSunny
            // 
            chBSunny.AutoSize = true;
            chBSunny.Location = new Point(60, 100);
            chBSunny.Name = "chBSunny";
            chBSunny.Size = new Size(59, 19);
            chBSunny.TabIndex = 3;
            chBSunny.Text = "&Sunny";
            chBSunny.UseVisualStyleBackColor = true;
            // 
            // chBSnow
            // 
            chBSnow.AutoSize = true;
            chBSnow.ForeColor = Color.SlateBlue;
            chBSnow.Location = new Point(60, 75);
            chBSnow.Name = "chBSnow";
            chBSnow.Size = new Size(61, 19);
            chBSnow.TabIndex = 2;
            chBSnow.Text = "&Snowy";
            chBSnow.UseVisualStyleBackColor = true;
            // 
            // chBRainy
            // 
            chBRainy.AutoSize = true;
            chBRainy.ForeColor = Color.HotPink;
            chBRainy.Location = new Point(60, 50);
            chBRainy.Name = "chBRainy";
            chBRainy.Size = new Size(55, 19);
            chBRainy.TabIndex = 1;
            chBRainy.Text = "&Rainy";
            chBRainy.UseVisualStyleBackColor = true;
            // 
            // chBCloudy
            // 
            chBCloudy.AutoSize = true;
            chBCloudy.ForeColor = Color.LightSeaGreen;
            chBCloudy.Location = new Point(62, 25);
            chBCloudy.Name = "chBCloudy";
            chBCloudy.Size = new Size(64, 19);
            chBCloudy.TabIndex = 0;
            chBCloudy.Text = "&Cloudy";
            chBCloudy.UseVisualStyleBackColor = true;
            // 
            // pCloudy
            // 
            pCloudy.Image = Properties.Resources.cloudy;
            pCloudy.Location = new Point(347, 133);
            pCloudy.Name = "pCloudy";
            pCloudy.Size = new Size(79, 45);
            pCloudy.SizeMode = PictureBoxSizeMode.StretchImage;
            pCloudy.TabIndex = 3;
            pCloudy.TabStop = false;
            // 
            // pRainy
            // 
            pRainy.Image = Properties.Resources.rainy;
            pRainy.Location = new Point(479, 128);
            pRainy.Name = "pRainy";
            pRainy.Size = new Size(78, 50);
            pRainy.TabIndex = 4;
            pRainy.TabStop = false;
            // 
            // pSnow
            // 
            pSnow.Image = Properties.Resources.snow;
            pSnow.Location = new Point(347, 206);
            pSnow.Name = "pSnow";
            pSnow.Size = new Size(68, 61);
            pSnow.TabIndex = 5;
            pSnow.TabStop = false;
            // 
            // pSunny
            // 
            pSunny.Image = Properties.Resources.sunny;
            pSunny.Location = new Point(486, 206);
            pSunny.Name = "pSunny";
            pSunny.Size = new Size(71, 77);
            pSunny.TabIndex = 6;
            pSunny.TabStop = false;
            // 
            // lbDisplay
            // 
            lbDisplay.BackColor = SystemColors.HotTrack;
            lbDisplay.Location = new Point(59, 307);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(255, 78);
            lbDisplay.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(440, 319);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(440, 359);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AcceptButton = btnPrint;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            CancelButton = btnExit;
            ClientSize = new Size(616, 394);
            Controls.Add(btnExit);
            Controls.Add(btnPrint);
            Controls.Add(lbDisplay);
            Controls.Add(pSunny);
            Controls.Add(pSnow);
            Controls.Add(pRainy);
            Controls.Add(pCloudy);
            Controls.Add(choose);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            choose.ResumeLayout(false);
            choose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pCloudy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pRainy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pSnow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pSunny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private GroupBox choose;
        private CheckBox chBSunny;
        private CheckBox chBSnow;
        private CheckBox chBRainy;
        private CheckBox chBCloudy;
        private PictureBox pCloudy;
        private PictureBox pRainy;
        private PictureBox pSnow;
        private PictureBox pSunny;
        private Label lbDisplay;
        private Button btnPrint;
        private Button btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}