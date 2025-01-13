namespace DeSo2
{
    partial class Cau1
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            câu2ToolStripMenuItem = new ToolStripMenuItem();
            câu3ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            câu2ToolStripMenuItem1 = new ToolStripMenuItem();
            câu3ToolStripMenuItem1 = new ToolStripMenuItem();
            thoátToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(451, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { câu2ToolStripMenuItem, câu3ToolStripMenuItem, toolStripSeparator1, thoátToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "menu";
            // 
            // câu2ToolStripMenuItem
            // 
            câu2ToolStripMenuItem.Name = "câu2ToolStripMenuItem";
            câu2ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
            câu2ToolStripMenuItem.Size = new Size(180, 22);
            câu2ToolStripMenuItem.Text = "Câu 2";
            câu2ToolStripMenuItem.Click += câu2ToolStripMenuItem_Click;
            // 
            // câu3ToolStripMenuItem
            // 
            câu3ToolStripMenuItem.Name = "câu3ToolStripMenuItem";
            câu3ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            câu3ToolStripMenuItem.Size = new Size(180, 22);
            câu3ToolStripMenuItem.Text = "Câu 3";
            câu3ToolStripMenuItem.Click += câu3ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            thoátToolStripMenuItem.Size = new Size(180, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { câu2ToolStripMenuItem1, câu3ToolStripMenuItem1, toolStripSeparator2, thoátToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 76);
            // 
            // câu2ToolStripMenuItem1
            // 
            câu2ToolStripMenuItem1.Name = "câu2ToolStripMenuItem1";
            câu2ToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.D2;
            câu2ToolStripMenuItem1.Size = new Size(180, 22);
            câu2ToolStripMenuItem1.Text = "Câu 2";
            câu2ToolStripMenuItem1.Click += câu2ToolStripMenuItem1_Click;
            // 
            // câu3ToolStripMenuItem1
            // 
            câu3ToolStripMenuItem1.Name = "câu3ToolStripMenuItem1";
            câu3ToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.D3;
            câu3ToolStripMenuItem1.Size = new Size(180, 22);
            câu3ToolStripMenuItem1.Text = "Câu 3";
            câu3ToolStripMenuItem1.Click += câu3ToolStripMenuItem1_Click;
            // 
            // thoátToolStripMenuItem1
            // 
            thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            thoátToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.X;
            thoátToolStripMenuItem1.Size = new Size(144, 22);
            thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(141, 6);
            // 
            // Cau1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 363);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Cau1";
            Text = "Form1";
            KeyDown += Cau1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem câu2ToolStripMenuItem;
        private ToolStripMenuItem câu3ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem câu2ToolStripMenuItem1;
        private ToolStripMenuItem câu3ToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem thoátToolStripMenuItem1;
    }
}