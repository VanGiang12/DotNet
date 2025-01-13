namespace VeGiaoDienVaXuLyLucRuntime
{
    partial class Form2
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
            panel1 = new Panel();
            pnButton = new Panel();
            label1 = new Label();
            txtdong = new TextBox();
            label2 = new Label();
            txtcot = new TextBox();
            btnenter = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnenter);
            panel1.Controls.Add(txtcot);
            panel1.Controls.Add(txtdong);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 47);
            panel1.TabIndex = 0;
            // 
            // pnButton
            // 
            pnButton.Dock = DockStyle.Fill;
            pnButton.Location = new Point(0, 47);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(380, 309);
            pnButton.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Số dòng";
            // 
            // txtdong
            // 
            txtdong.Location = new Point(72, 12);
            txtdong.Name = "txtdong";
            txtdong.Size = new Size(58, 23);
            txtdong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 15);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Số cột";
            // 
            // txtcot
            // 
            txtcot.Location = new Point(182, 12);
            txtcot.Name = "txtcot";
            txtcot.Size = new Size(58, 23);
            txtcot.TabIndex = 1;
            txtcot.TextChanged += textBox2_TextChanged;
            // 
            // btnenter
            // 
            btnenter.Location = new Point(258, 12);
            btnenter.Name = "btnenter";
            btnenter.Size = new Size(75, 23);
            btnenter.TabIndex = 2;
            btnenter.Text = "Enter";
            btnenter.UseVisualStyleBackColor = true;
            btnenter.Click += btnenter_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 356);
            Controls.Add(pnButton);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtcot;
        private TextBox txtdong;
        private Label label2;
        private Label label1;
        private Panel pnButton;
        private Button btnenter;
    }
}