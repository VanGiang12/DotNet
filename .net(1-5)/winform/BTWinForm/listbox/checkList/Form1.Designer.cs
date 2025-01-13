namespace checkList
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
            cklstLeft = new CheckedListBox();
            btnMove1FromLeft = new Button();
            btnMoveAllFromLeft = new Button();
            btnMove1FromRight = new Button();
            btnMoveAllFromRight = new Button();
            cklstRight = new CheckedListBox();
            SuspendLayout();
            // 
            // cklstLeft
            // 
            cklstLeft.FormattingEnabled = true;
            cklstLeft.Location = new Point(24, 32);
            cklstLeft.Name = "cklstLeft";
            cklstLeft.Size = new Size(168, 268);
            cklstLeft.TabIndex = 0;
            // 
            // btnMove1FromLeft
            // 
            btnMove1FromLeft.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnMove1FromLeft.Location = new Point(227, 57);
            btnMove1FromLeft.Name = "btnMove1FromLeft";
            btnMove1FromLeft.Size = new Size(94, 40);
            btnMove1FromLeft.TabIndex = 1;
            btnMove1FromLeft.Text = ">";
            btnMove1FromLeft.UseVisualStyleBackColor = true;
            btnMove1FromLeft.Click += btnMove1FromLeft_Click;
            // 
            // btnMoveAllFromLeft
            // 
            btnMoveAllFromLeft.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnMoveAllFromLeft.Location = new Point(227, 116);
            btnMoveAllFromLeft.Name = "btnMoveAllFromLeft";
            btnMoveAllFromLeft.Size = new Size(94, 40);
            btnMoveAllFromLeft.TabIndex = 2;
            btnMoveAllFromLeft.Text = ">>";
            btnMoveAllFromLeft.UseVisualStyleBackColor = true;
            btnMoveAllFromLeft.Click += btnMoveAllFromLeft_Click;
            // 
            // btnMove1FromRight
            // 
            btnMove1FromRight.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnMove1FromRight.Location = new Point(227, 175);
            btnMove1FromRight.Name = "btnMove1FromRight";
            btnMove1FromRight.Size = new Size(94, 40);
            btnMove1FromRight.TabIndex = 3;
            btnMove1FromRight.Text = "<";
            btnMove1FromRight.UseVisualStyleBackColor = true;
            btnMove1FromRight.Click += btnMove1FromRight_Click;
            // 
            // btnMoveAllFromRight
            // 
            btnMoveAllFromRight.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnMoveAllFromRight.Location = new Point(227, 231);
            btnMoveAllFromRight.Name = "btnMoveAllFromRight";
            btnMoveAllFromRight.Size = new Size(94, 40);
            btnMoveAllFromRight.TabIndex = 4;
            btnMoveAllFromRight.Text = "<<";
            btnMoveAllFromRight.UseVisualStyleBackColor = true;
            btnMoveAllFromRight.Click += btnMoveAllFromRight_Click;
            // 
            // cklstRight
            // 
            cklstRight.FormattingEnabled = true;
            cklstRight.Location = new Point(349, 32);
            cklstRight.Name = "cklstRight";
            cklstRight.Size = new Size(168, 268);
            cklstRight.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 342);
            Controls.Add(cklstRight);
            Controls.Add(btnMoveAllFromRight);
            Controls.Add(btnMove1FromRight);
            Controls.Add(btnMoveAllFromLeft);
            Controls.Add(btnMove1FromLeft);
            Controls.Add(cklstLeft);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox cklstLeft;
        private Button btnMove1FromLeft;
        private Button btnMoveAllFromLeft;
        private Button btnMove1FromRight;
        private Button btnMoveAllFromRight;
        private CheckedListBox cklstRight;
    }
}
