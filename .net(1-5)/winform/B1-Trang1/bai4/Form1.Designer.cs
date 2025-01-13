namespace bai4
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
            txtMessage = new TextBox();
            txtName = new TextBox();
            lbMessage = new Label();
            lbName = new Label();
            grColor = new GroupBox();
            rdBlack = new RadioButton();
            rdBlue = new RadioButton();
            rdGreen = new RadioButton();
            rdRed = new RadioButton();
            gpStyle = new GroupBox();
            chBUnderline = new CheckBox();
            chBItalic = new CheckBox();
            chBBold = new CheckBox();
            pic1 = new PictureBox();
            lblDis = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            pic2 = new PictureBox();
            groupBox1.SuspendLayout();
            grColor.SuspendLayout();
            gpStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lbMessage);
            groupBox1.Controls.Add(lbName);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(146, 62);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(319, 29);
            txtMessage.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(146, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(319, 29);
            txtName.TabIndex = 2;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMessage.Location = new Point(17, 70);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(71, 21);
            lbMessage.TabIndex = 1;
            lbMessage.Text = "Message";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(17, 24);
            lbName.Name = "lbName";
            lbName.Size = new Size(85, 21);
            lbName.TabIndex = 0;
            lbName.Text = "Your name";
            // 
            // grColor
            // 
            grColor.Controls.Add(rdBlack);
            grColor.Controls.Add(rdBlue);
            grColor.Controls.Add(rdGreen);
            grColor.Controls.Add(rdRed);
            grColor.ForeColor = Color.Black;
            grColor.Location = new Point(26, 141);
            grColor.Name = "grColor";
            grColor.Size = new Size(224, 132);
            grColor.TabIndex = 1;
            grColor.TabStop = false;
            grColor.Text = "Color";
            // 
            // rdBlack
            // 
            rdBlack.AutoSize = true;
            rdBlack.ForeColor = Color.Black;
            rdBlack.Location = new Point(24, 107);
            rdBlack.Name = "rdBlack";
            rdBlack.Size = new Size(53, 19);
            rdBlack.TabIndex = 3;
            rdBlack.TabStop = true;
            rdBlack.Text = "Black";
            rdBlack.UseVisualStyleBackColor = true;
            rdBlack.CheckedChanged += rdBlack_CheckedChanged;
            // 
            // rdBlue
            // 
            rdBlue.AutoSize = true;
            rdBlue.ForeColor = Color.Blue;
            rdBlue.Location = new Point(24, 76);
            rdBlue.Name = "rdBlue";
            rdBlue.Size = new Size(48, 19);
            rdBlue.TabIndex = 2;
            rdBlue.TabStop = true;
            rdBlue.Text = "Blue";
            rdBlue.UseVisualStyleBackColor = true;
            rdBlue.CheckedChanged += rdBlue_CheckedChanged;
            // 
            // rdGreen
            // 
            rdGreen.AutoSize = true;
            rdGreen.ForeColor = Color.Green;
            rdGreen.Location = new Point(24, 51);
            rdGreen.Name = "rdGreen";
            rdGreen.Size = new Size(56, 19);
            rdGreen.TabIndex = 1;
            rdGreen.TabStop = true;
            rdGreen.Text = "Green";
            rdGreen.UseVisualStyleBackColor = true;
            rdGreen.CheckedChanged += rdGreen_CheckedChanged;
            // 
            // rdRed
            // 
            rdRed.AutoSize = true;
            rdRed.ForeColor = Color.Red;
            rdRed.Location = new Point(24, 26);
            rdRed.Name = "rdRed";
            rdRed.Size = new Size(45, 19);
            rdRed.TabIndex = 0;
            rdRed.TabStop = true;
            rdRed.Text = "Red";
            rdRed.UseVisualStyleBackColor = true;
            rdRed.CheckedChanged += rdRed_CheckedChanged;
            // 
            // gpStyle
            // 
            gpStyle.Controls.Add(chBUnderline);
            gpStyle.Controls.Add(chBItalic);
            gpStyle.Controls.Add(chBBold);
            gpStyle.ForeColor = Color.Black;
            gpStyle.Location = new Point(311, 141);
            gpStyle.Name = "gpStyle";
            gpStyle.Size = new Size(212, 132);
            gpStyle.TabIndex = 2;
            gpStyle.TabStop = false;
            gpStyle.Text = "Style";
            // 
            // chBUnderline
            // 
            chBUnderline.AutoSize = true;
            chBUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            chBUnderline.Location = new Point(20, 89);
            chBUnderline.Name = "chBUnderline";
            chBUnderline.Size = new Size(77, 19);
            chBUnderline.TabIndex = 2;
            chBUnderline.Text = "Underline";
            chBUnderline.UseVisualStyleBackColor = true;
            chBUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chBItalic
            // 
            chBItalic.AutoSize = true;
            chBItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            chBItalic.Location = new Point(20, 64);
            chBItalic.Name = "chBItalic";
            chBItalic.Size = new Size(51, 19);
            chBItalic.TabIndex = 1;
            chBItalic.Text = "Italic";
            chBItalic.UseVisualStyleBackColor = true;
            chBItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chBBold
            // 
            chBBold.AutoSize = true;
            chBBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chBBold.Location = new Point(20, 39);
            chBBold.Name = "chBBold";
            chBBold.Size = new Size(51, 19);
            chBBold.TabIndex = 0;
            chBBold.Text = "Bold";
            chBBold.UseVisualStyleBackColor = true;
            chBBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // pic1
            // 
            pic1.Image = Properties.Resources.tải_xuống;
            pic1.Location = new Point(28, 291);
            pic1.Name = "pic1";
            pic1.Size = new Size(100, 75);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 3;
            pic1.TabStop = false;
            pic1.DoubleClick += pic1_DoubleClick;
            // 
            // lblDis
            // 
            lblDis.BorderStyle = BorderStyle.Fixed3D;
            lblDis.Location = new Point(144, 291);
            lblDis.Name = "lblDis";
            lblDis.Size = new Size(217, 75);
            lblDis.TabIndex = 4;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(367, 288);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 5;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(367, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(448, 288);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(448, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pic2
            // 
            pic2.Image = Properties.Resources.CaRo___Copy;
            pic2.Location = new Point(28, 288);
            pic2.Name = "pic2";
            pic2.Size = new Size(100, 75);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 9;
            pic2.TabStop = false;
            pic2.DoubleClick += pic2_DoubleClick;
            // 
            // Form1
            // 
            AcceptButton = btnDisplay;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            CancelButton = btnExit;
            ClientSize = new Size(546, 390);
            Controls.Add(pic2);
            Controls.Add(btnExit);
            Controls.Add(btnPrint);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lblDis);
            Controls.Add(pic1);
            Controls.Add(gpStyle);
            Controls.Add(grColor);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grColor.ResumeLayout(false);
            grColor.PerformLayout();
            gpStyle.ResumeLayout(false);
            gpStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMessage;
        private TextBox txtName;
        private Label lbMessage;
        private Label lbName;
        private GroupBox grColor;
        private RadioButton rdBlack;
        private RadioButton rdBlue;
        private RadioButton rdGreen;
        private RadioButton rdRed;
        private GroupBox gpStyle;
        private CheckBox chBBold;
        private CheckBox chBUnderline;
        private CheckBox chBItalic;
        private PictureBox pic1;
        private Label lblDis;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnPrint;
        private Button btnExit;
        private PictureBox pic2;
    }
}