namespace Menu
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            câu2Ctrl2ToolStripMenuItem = new ToolStripMenuItem();
            câu3Ctrl3ToolStripMenuItem = new ToolStripMenuItem();
            thoátAltXToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(232, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { câu2Ctrl2ToolStripMenuItem, câu3Ctrl3ToolStripMenuItem, thoátAltXToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // câu2Ctrl2ToolStripMenuItem
            // 
            câu2Ctrl2ToolStripMenuItem.Name = "câu2Ctrl2ToolStripMenuItem";
            câu2Ctrl2ToolStripMenuItem.Size = new Size(143, 22);
            câu2Ctrl2ToolStripMenuItem.Text = "Câu 2  Ctrl+2";
            câu2Ctrl2ToolStripMenuItem.Click += câu2Ctrl2ToolStripMenuItem_Click;
            // 
            // câu3Ctrl3ToolStripMenuItem
            // 
            câu3Ctrl3ToolStripMenuItem.Name = "câu3Ctrl3ToolStripMenuItem";
            câu3Ctrl3ToolStripMenuItem.Size = new Size(143, 22);
            câu3Ctrl3ToolStripMenuItem.Text = "Câu 3 Ctrl+3";
            câu3Ctrl3ToolStripMenuItem.Click += câu3Ctrl3ToolStripMenuItem_Click;
            // 
            // thoátAltXToolStripMenuItem
            // 
            thoátAltXToolStripMenuItem.Name = "thoátAltXToolStripMenuItem";
            thoátAltXToolStripMenuItem.Size = new Size(143, 22);
            thoátAltXToolStripMenuItem.Text = "Thoát  Alt+X";
            thoátAltXToolStripMenuItem.Click += thoátAltXToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 172);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem câu2Ctrl2ToolStripMenuItem;
        private ToolStripMenuItem câu3Ctrl3ToolStripMenuItem;
        private ToolStripMenuItem thoátAltXToolStripMenuItem;
    }
}