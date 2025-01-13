namespace DeSo3
{
    partial class Bai2
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtB = new TextBox();
            label1 = new Label();
            txtA = new TextBox();
            groupBox2 = new GroupBox();
            txtKQ = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtA);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phương trình ax+b=0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 25);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = " = 0";
            // 
            // txtB
            // 
            txtB.Location = new Point(75, 22);
            txtB.Name = "txtB";
            txtB.Size = new Size(27, 23);
            txtB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 25);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "x + ";
            // 
            // txtA
            // 
            txtA.Location = new Point(9, 22);
            txtA.Name = "txtA";
            txtA.Size = new Size(27, 23);
            txtA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtKQ);
            groupBox2.Location = new Point(12, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 57);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nghiệm";
            // 
            // txtKQ
            // 
            txtKQ.BorderStyle = BorderStyle.FixedSingle;
            txtKQ.Location = new Point(9, 28);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(140, 23);
            txtKQ.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(173, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Giải";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(173, 88);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 3;
            button2.Text = "Tiếp tục";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 154);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Bai2";
            Text = "Giải phương trình bậc nhất";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtB;
        private Label label1;
        private TextBox txtA;
        private TextBox txtKQ;
    }
}