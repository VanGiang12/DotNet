namespace MDI_Bai44
{
    partial class frmMain
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
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            bài1ToolStripMenuItem = new ToolStripMenuItem();
            bài2ToolStripMenuItem = new ToolStripMenuItem();
            bài3ToolStripMenuItem = new ToolStripMenuItem();
            sắpXếpToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, sắpXếpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(653, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bài1ToolStripMenuItem, bài2ToolStripMenuItem, bài3ToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // bài1ToolStripMenuItem
            // 
            bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            bài1ToolStripMenuItem.Size = new Size(99, 22);
            bài1ToolStripMenuItem.Text = "bài 1";
            bài1ToolStripMenuItem.Click += bài1ToolStripMenuItem_Click;
            // 
            // bài2ToolStripMenuItem
            // 
            bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            bài2ToolStripMenuItem.Size = new Size(99, 22);
            bài2ToolStripMenuItem.Text = "bài 2";
            bài2ToolStripMenuItem.Click += bài2ToolStripMenuItem_Click;
            // 
            // bài3ToolStripMenuItem
            // 
            bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            bài3ToolStripMenuItem.Size = new Size(99, 22);
            bài3ToolStripMenuItem.Text = "bài 3";
            bài3ToolStripMenuItem.Click += bài3ToolStripMenuItem_Click;
            // 
            // sắpXếpToolStripMenuItem
            // 
            sắpXếpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrangeIconToolStripMenuItem, cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem });
            sắpXếpToolStripMenuItem.Name = "sắpXếpToolStripMenuItem";
            sắpXếpToolStripMenuItem.Size = new Size(60, 20);
            sắpXếpToolStripMenuItem.Text = "Sắp xếp";
            // 
            // arrangeIconToolStripMenuItem
            // 
            arrangeIconToolStripMenuItem.Name = "arrangeIconToolStripMenuItem";
            arrangeIconToolStripMenuItem.Size = new Size(180, 22);
            arrangeIconToolStripMenuItem.Text = "ArrangeIcon";
            arrangeIconToolStripMenuItem.Click += arrangeIconToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(180, 22);
            tileHorizontalToolStripMenuItem.Text = "TileHorizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(180, 22);
            tileVerticalToolStripMenuItem.Text = "TileVertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 443);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem bài1ToolStripMenuItem;
        private ToolStripMenuItem bài2ToolStripMenuItem;
        private ToolStripMenuItem bài3ToolStripMenuItem;
        private ToolStripMenuItem sắpXếpToolStripMenuItem;
        private ToolStripMenuItem arrangeIconToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
    }
}