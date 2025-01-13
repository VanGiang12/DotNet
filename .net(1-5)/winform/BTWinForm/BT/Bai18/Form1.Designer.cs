namespace Bai18
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
            radRetryCancel = new RadioButton();
            radYesNo = new RadioButton();
            radYesNoCancel = new RadioButton();
            radOKCancel = new RadioButton();
            radAbortRetryIgnore = new RadioButton();
            radOK = new RadioButton();
            groupBox2 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radInformation = new RadioButton();
            radExclammation = new RadioButton();
            radQuestion = new RadioButton();
            radStop = new RadioButton();
            btnChon = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radRetryCancel);
            groupBox1.Controls.Add(radYesNo);
            groupBox1.Controls.Add(radYesNoCancel);
            groupBox1.Controls.Add(radOKCancel);
            groupBox1.Controls.Add(radAbortRetryIgnore);
            groupBox1.Controls.Add(radOK);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Style Button";
            // 
            // radRetryCancel
            // 
            radRetryCancel.AutoSize = true;
            radRetryCancel.Location = new Point(6, 223);
            radRetryCancel.Name = "radRetryCancel";
            radRetryCancel.Size = new Size(91, 19);
            radRetryCancel.TabIndex = 5;
            radRetryCancel.TabStop = true;
            radRetryCancel.Text = "Retry Cancel";
            radRetryCancel.UseVisualStyleBackColor = true;
            // 
            // radYesNo
            // 
            radYesNo.AutoSize = true;
            radYesNo.Location = new Point(6, 187);
            radYesNo.Name = "radYesNo";
            radYesNo.Size = new Size(61, 19);
            radYesNo.TabIndex = 4;
            radYesNo.TabStop = true;
            radYesNo.Text = "Yes No";
            radYesNo.UseVisualStyleBackColor = true;
            // 
            // radYesNoCancel
            // 
            radYesNoCancel.AutoSize = true;
            radYesNoCancel.Location = new Point(6, 148);
            radYesNoCancel.Name = "radYesNoCancel";
            radYesNoCancel.Size = new Size(100, 19);
            radYesNoCancel.TabIndex = 3;
            radYesNoCancel.TabStop = true;
            radYesNoCancel.Text = "Yes No Cancel";
            radYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // radOKCancel
            // 
            radOKCancel.AutoSize = true;
            radOKCancel.Location = new Point(6, 70);
            radOKCancel.Name = "radOKCancel";
            radOKCancel.Size = new Size(80, 19);
            radOKCancel.TabIndex = 2;
            radOKCancel.TabStop = true;
            radOKCancel.Text = "OK Cancel";
            radOKCancel.UseVisualStyleBackColor = true;
            // 
            // radAbortRetryIgnore
            // 
            radAbortRetryIgnore.AutoSize = true;
            radAbortRetryIgnore.Location = new Point(6, 108);
            radAbortRetryIgnore.Name = "radAbortRetryIgnore";
            radAbortRetryIgnore.Size = new Size(122, 19);
            radAbortRetryIgnore.TabIndex = 1;
            radAbortRetryIgnore.TabStop = true;
            radAbortRetryIgnore.Text = "Abort Retry Ignore";
            radAbortRetryIgnore.UseVisualStyleBackColor = true;
            // 
            // radOK
            // 
            radOK.AutoSize = true;
            radOK.Location = new Point(6, 31);
            radOK.Name = "radOK";
            radOK.Size = new Size(41, 19);
            radOK.TabIndex = 0;
            radOK.TabStop = true;
            radOK.Text = "OK";
            radOK.UseVisualStyleBackColor = true;
            radOK.CheckedChanged += radOK_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(radInformation);
            groupBox2.Controls.Add(radExclammation);
            groupBox2.Controls.Add(radQuestion);
            groupBox2.Controls.Add(radStop);
            groupBox2.Location = new Point(218, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 248);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Style Icon";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Ảnh_chụp_màn_hình_2024_04_15_224525;
            pictureBox4.Location = new Point(103, 207);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Ảnh_chụp_màn_hình_2024_04_15_224519;
            pictureBox3.Location = new Point(139, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ảnh_chụp_màn_hình_2024_04_15_224510;
            pictureBox2.Location = new Point(103, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ảnh_chụp_màn_hình_2024_04_15_224457;
            pictureBox1.Location = new Point(70, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // radInformation
            // 
            radInformation.AutoSize = true;
            radInformation.Location = new Point(6, 210);
            radInformation.Name = "radInformation";
            radInformation.Size = new Size(88, 19);
            radInformation.TabIndex = 3;
            radInformation.TabStop = true;
            radInformation.Text = "Information";
            radInformation.UseVisualStyleBackColor = true;
            // 
            // radExclammation
            // 
            radExclammation.AutoSize = true;
            radExclammation.Location = new Point(6, 148);
            radExclammation.Name = "radExclammation";
            radExclammation.Size = new Size(101, 19);
            radExclammation.TabIndex = 2;
            radExclammation.TabStop = true;
            radExclammation.Text = "Exclammation";
            radExclammation.UseVisualStyleBackColor = true;
            // 
            // radQuestion
            // 
            radQuestion.AutoSize = true;
            radQuestion.Location = new Point(6, 85);
            radQuestion.Name = "radQuestion";
            radQuestion.Size = new Size(73, 19);
            radQuestion.TabIndex = 1;
            radQuestion.TabStop = true;
            radQuestion.Text = "Question";
            radQuestion.UseVisualStyleBackColor = true;
            // 
            // radStop
            // 
            radStop.AutoSize = true;
            radStop.Location = new Point(6, 31);
            radStop.Name = "radStop";
            radStop.Size = new Size(49, 19);
            radStop.TabIndex = 0;
            radStop.TabStop = true;
            radStop.Text = "Stop";
            radStop.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(137, 266);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(75, 23);
            btnChon.TabIndex = 2;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(218, 266);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 304);
            Controls.Add(btnThoat);
            Controls.Add(btnChon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hàm MsgBox";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radRetryCancel;
        private RadioButton radYesNo;
        private RadioButton radYesNoCancel;
        private RadioButton radOKCancel;
        private RadioButton radAbortRetryIgnore;
        private RadioButton radOK;
        private GroupBox groupBox2;
        private RadioButton radInformation;
        private RadioButton radExclammation;
        private RadioButton radQuestion;
        private RadioButton radStop;
        private Button btnChon;
        private Button btnThoat;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}