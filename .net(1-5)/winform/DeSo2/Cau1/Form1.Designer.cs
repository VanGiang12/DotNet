namespace Cau1
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
            chươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
            câu2ToolStripMenuItem = new ToolStripMenuItem();
            câu3ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chươngTrìnhToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            chươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { câu2ToolStripMenuItem, câu3ToolStripMenuItem, toolStripSeparator1, thoátToolStripMenuItem });
            chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            chươngTrìnhToolStripMenuItem.Size = new Size(90, 20);
            chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // câu2ToolStripMenuItem
            // 
            câu2ToolStripMenuItem.Image = Properties.Resources.CaRo;
            câu2ToolStripMenuItem.Name = "câu2ToolStripMenuItem";
            câu2ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
            câu2ToolStripMenuItem.Size = new Size(144, 22);
            câu2ToolStripMenuItem.Text = "Câu 2";
            câu2ToolStripMenuItem.Click += câu2ToolStripMenuItem_Click;
            // 
            // câu3ToolStripMenuItem
            // 
            câu3ToolStripMenuItem.Name = "câu3ToolStripMenuItem";
            câu3ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            câu3ToolStripMenuItem.Size = new Size(144, 22);
            câu3ToolStripMenuItem.Text = "Câu 3";
            câu3ToolStripMenuItem.Click += câu3ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(141, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            thoátToolStripMenuItem.Size = new Size(144, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private ToolStripMenuItem câu2ToolStripMenuItem;
        private ToolStripMenuItem câu3ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}