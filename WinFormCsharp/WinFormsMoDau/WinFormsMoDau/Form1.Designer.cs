namespace WinFormsMoDau
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
            thoát = new Button();
            SuspendLayout();
            // 
            // thoát
            // 
            thoát.Location = new Point(361, 315);
            thoát.Name = "thoát";
            thoát.Size = new Size(75, 23);
            thoát.TabIndex = 0;
            thoát.Text = "thoát";
            thoát.UseVisualStyleBackColor = true;
            thoát.Click += thoát_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(448, 350);
            Controls.Add(thoát);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Click += Form1_Click;
            DoubleClick += Form1_DoubleClick;
            ResumeLayout(false);
        }

        #endregion

        private Button thoát;
    }
}