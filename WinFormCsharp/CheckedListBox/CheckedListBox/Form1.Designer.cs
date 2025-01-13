namespace CheckedListBox
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
            chklsLeft = new System.Windows.Forms.CheckedListBox();
            btnAdd = new Button();
            btnAddAll = new Button();
            btnRemove = new Button();
            btnremoveAll = new Button();
            chklsRight = new System.Windows.Forms.CheckedListBox();
            SuspendLayout();
            // 
            // chklsLeft
            // 
            chklsLeft.FormattingEnabled = true;
            chklsLeft.Location = new Point(19, 22);
            chklsLeft.Margin = new Padding(5, 6, 5, 6);
            chklsLeft.Name = "chklsLeft";
            chklsLeft.Size = new Size(226, 323);
            chklsLeft.TabIndex = 0;
            chklsLeft.SelectedIndexChanged += chklsLeft_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(270, 93);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddAll
            // 
            btnAddAll.Location = new Point(270, 147);
            btnAddAll.Margin = new Padding(5, 6, 5, 6);
            btnAddAll.Name = "btnAddAll";
            btnAddAll.Size = new Size(118, 43);
            btnAddAll.TabIndex = 1;
            btnAddAll.Text = ">>";
            btnAddAll.UseVisualStyleBackColor = true;
            btnAddAll.Click += btnAddAll_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(270, 202);
            btnRemove.Margin = new Padding(5, 6, 5, 6);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(118, 43);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnremoveAll
            // 
            btnremoveAll.Location = new Point(270, 256);
            btnremoveAll.Margin = new Padding(5, 6, 5, 6);
            btnremoveAll.Name = "btnremoveAll";
            btnremoveAll.Size = new Size(118, 43);
            btnremoveAll.TabIndex = 1;
            btnremoveAll.Text = "<<";
            btnremoveAll.UseVisualStyleBackColor = true;
            btnremoveAll.Click += btnremoveAll_Click;
            // 
            // chklsRight
            // 
            chklsRight.FormattingEnabled = true;
            chklsRight.Location = new Point(413, 26);
            chklsRight.Margin = new Padding(5, 6, 5, 6);
            chklsRight.Name = "chklsRight";
            chklsRight.Size = new Size(226, 323);
            chklsRight.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 385);
            Controls.Add(btnremoveAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAddAll);
            Controls.Add(btnAdd);
            Controls.Add(chklsRight);
            Controls.Add(chklsLeft);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklsLeft;
        private Button btnAdd;
        private Button btnAddAll;
        private Button btnRemove;
        private Button btnremoveAll;
        private System.Windows.Forms.CheckedListBox chklsRight;
    }
}