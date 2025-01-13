namespace WinFormsApp1
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
            label1 = new Label();
            hsA = new Label();
            a = new TextBox();
            label2 = new Label();
            b = new TextBox();
            c = new Label();
            hsc = new TextBox();
            x1 = new Label();
            x2 = new Label();
            nx1 = new TextBox();
            nx2 = new TextBox();
            gpt = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 36);
            label1.Name = "label1";
            label1.Size = new Size(237, 21);
            label1.TabIndex = 0;
            label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC HAI";
            // 
            // hsA
            // 
            hsA.AutoSize = true;
            hsA.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            hsA.Location = new Point(22, 83);
            hsA.Name = "hsA";
            hsA.Size = new Size(58, 19);
            hsA.TabIndex = 1;
            hsA.Text = "Hệ Số A";
            // 
            // a
            // 
            a.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(123, 75);
            a.Name = "a";
            a.Size = new Size(172, 25);
            a.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 129);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 3;
            label2.Text = "Hệ Số B";
            // 
            // b
            // 
            b.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            b.Location = new Point(123, 121);
            b.Name = "b";
            b.Size = new Size(172, 25);
            b.TabIndex = 4;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(23, 172);
            c.Name = "c";
            c.Size = new Size(58, 19);
            c.TabIndex = 5;
            c.Text = "Hệ Số C";
            // 
            // hsc
            // 
            hsc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            hsc.Location = new Point(124, 164);
            hsc.Name = "hsc";
            hsc.Size = new Size(172, 25);
            hsc.TabIndex = 6;
            // 
            // x1
            // 
            x1.AutoSize = true;
            x1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            x1.Location = new Point(22, 213);
            x1.Name = "x1";
            x1.Size = new Size(75, 19);
            x1.TabIndex = 7;
            x1.Text = "Nghiệm x1";
            // 
            // x2
            // 
            x2.AutoSize = true;
            x2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            x2.Location = new Point(22, 253);
            x2.Name = "x2";
            x2.Size = new Size(75, 19);
            x2.TabIndex = 8;
            x2.Text = "Nghiệm x2";
            // 
            // nx1
            // 
            nx1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nx1.Location = new Point(123, 205);
            nx1.Name = "nx1";
            nx1.Size = new Size(172, 25);
            nx1.TabIndex = 9;
            // 
            // nx2
            // 
            nx2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nx2.Location = new Point(123, 245);
            nx2.Name = "nx2";
            nx2.Size = new Size(172, 25);
            nx2.TabIndex = 10;
            // 
            // gpt
            // 
            gpt.BorderStyle = BorderStyle.FixedSingle;
            gpt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gpt.Location = new Point(58, 309);
            gpt.Name = "gpt";
            gpt.Size = new Size(68, 22);
            gpt.TabIndex = 11;
            gpt.Text = "Giải PT";
            gpt.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(191, 309);
            label4.Name = "label4";
            label4.Size = new Size(0, 0);
            label4.TabIndex = 12;
            label4.Text = "Thoát";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 367);
            Controls.Add(label4);
            Controls.Add(gpt);
            Controls.Add(nx2);
            Controls.Add(nx1);
            Controls.Add(x2);
            Controls.Add(x1);
            Controls.Add(hsc);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(label2);
            Controls.Add(a);
            Controls.Add(hsA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label hsA;
        private TextBox a;
        private Label label2;
        private TextBox b;
        private Label c;
        private TextBox hsc;
        private Label x1;
        private Label x2;
        private TextBox nx1;
        private TextBox nx2;
        private Label gpt;
        private Label label4;
    }
}