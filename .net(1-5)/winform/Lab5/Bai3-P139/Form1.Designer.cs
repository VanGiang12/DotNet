namespace Bai3_P139
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
            radioButtonSquare = new RadioButton();
            radioButtonRectangle = new RadioButton();
            radioButtonEllipse = new RadioButton();
            radioButtonCircle = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hScrollBar1 = new HScrollBar();
            hScrollBarGreen = new HScrollBar();
            hScrollBarBlue = new HScrollBar();
            btnDraw = new Button();
            panelDrawing = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonSquare);
            groupBox1.Controls.Add(radioButtonRectangle);
            groupBox1.Controls.Add(radioButtonEllipse);
            groupBox1.Controls.Add(radioButtonCircle);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn hình vẽ";
            // 
            // radioButtonSquare
            // 
            radioButtonSquare.AutoSize = true;
            radioButtonSquare.Location = new Point(106, 100);
            radioButtonSquare.Name = "radioButtonSquare";
            radioButtonSquare.Size = new Size(88, 19);
            radioButtonSquare.TabIndex = 3;
            radioButtonSquare.TabStop = true;
            radioButtonSquare.Text = "Hình vuông";
            radioButtonSquare.UseVisualStyleBackColor = true;
            radioButtonSquare.CheckedChanged += radioButtonSquare_CheckedChanged;
            // 
            // radioButtonRectangle
            // 
            radioButtonRectangle.AutoSize = true;
            radioButtonRectangle.Location = new Point(106, 36);
            radioButtonRectangle.Name = "radioButtonRectangle";
            radioButtonRectangle.Size = new Size(101, 19);
            radioButtonRectangle.TabIndex = 2;
            radioButtonRectangle.TabStop = true;
            radioButtonRectangle.Text = "Hình chữ nhật";
            radioButtonRectangle.UseVisualStyleBackColor = true;
            radioButtonRectangle.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButtonEllipse
            // 
            radioButtonEllipse.AutoSize = true;
            radioButtonEllipse.Location = new Point(6, 100);
            radioButtonEllipse.Name = "radioButtonEllipse";
            radioButtonEllipse.Size = new Size(84, 19);
            radioButtonEllipse.TabIndex = 1;
            radioButtonEllipse.TabStop = true;
            radioButtonEllipse.Text = "Hình Elipse";
            radioButtonEllipse.UseVisualStyleBackColor = true;
            radioButtonEllipse.CheckedChanged += radioButtonEllipse_CheckedChanged;
            // 
            // radioButtonCircle
            // 
            radioButtonCircle.AutoSize = true;
            radioButtonCircle.Location = new Point(6, 36);
            radioButtonCircle.Name = "radioButtonCircle";
            radioButtonCircle.Size = new Size(76, 19);
            radioButtonCircle.TabIndex = 0;
            radioButtonCircle.TabStop = true;
            radioButtonCircle.Text = "Hình tròn";
            radioButtonCircle.UseVisualStyleBackColor = true;
            radioButtonCircle.CheckedChanged += radioButtonCircle_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 177);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 216);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 251);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Blue";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(69, 177);
            hScrollBar1.Maximum = 255;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(156, 15);
            hScrollBar1.TabIndex = 4;
            hScrollBar1.ValueChanged += hScrollBar1_ValueChanged;
            // 
            // hScrollBarGreen
            // 
            hScrollBarGreen.Location = new Point(69, 216);
            hScrollBarGreen.Maximum = 255;
            hScrollBarGreen.Name = "hScrollBarGreen";
            hScrollBarGreen.Size = new Size(156, 15);
            hScrollBarGreen.TabIndex = 5;
            hScrollBarGreen.ValueChanged += hScrollBarGreen_ValueChanged;
            // 
            // hScrollBarBlue
            // 
            hScrollBarBlue.Location = new Point(69, 251);
            hScrollBarBlue.Maximum = 255;
            hScrollBarBlue.Name = "hScrollBarBlue";
            hScrollBarBlue.Size = new Size(156, 15);
            hScrollBarBlue.TabIndex = 6;
            hScrollBarBlue.ValueChanged += hScrollBarBlue_ValueChanged;
            // 
            // btnDraw
            // 
            btnDraw.BackColor = SystemColors.Control;
            btnDraw.Location = new Point(275, 177);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 23);
            btnDraw.TabIndex = 8;
            btnDraw.Text = "Vẽ hình";
            btnDraw.UseVisualStyleBackColor = false;
            btnDraw.Click += btnDraw_Click;
            // 
            // panelDrawing
            // 
            panelDrawing.BackColor = SystemColors.ActiveCaption;
            panelDrawing.Location = new Point(241, 12);
            panelDrawing.Name = "panelDrawing";
            panelDrawing.Size = new Size(146, 137);
            panelDrawing.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 303);
            Controls.Add(panelDrawing);
            Controls.Add(btnDraw);
            Controls.Add(hScrollBarBlue);
            Controls.Add(hScrollBarGreen);
            Controls.Add(hScrollBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonSquare;
        private RadioButton radioButtonRectangle;
        private RadioButton radioButtonEllipse;
        private RadioButton radioButtonCircle;
        private Label label1;
        private Label label2;
        private Label label3;
        private HScrollBar hScrollBar1;
        private HScrollBar hScrollBarGreen;
        private HScrollBar hScrollBarBlue;
        private Button btnDraw;
        private Panel panelDrawing;
    }
}