namespace Bai2
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            openCtrlOToolStripMenuItem = new ToolStripMenuItem();
            saveCtrlSToolStripMenuItem = new ToolStripMenuItem();
            clearCtrlCToolStripMenuItem = new ToolStripMenuItem();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(316, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openCtrlOToolStripMenuItem, saveCtrlSToolStripMenuItem, clearCtrlCToolStripMenuItem, exitAltF4ToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openCtrlOToolStripMenuItem
            // 
            openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            openCtrlOToolStripMenuItem.Size = new Size(154, 22);
            openCtrlOToolStripMenuItem.Text = "Open    Ctrl+O";
            openCtrlOToolStripMenuItem.Click += openCtrlOToolStripMenuItem_Click;
            // 
            // saveCtrlSToolStripMenuItem
            // 
            saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            saveCtrlSToolStripMenuItem.Size = new Size(154, 22);
            saveCtrlSToolStripMenuItem.Text = "Save      Ctrl+S";
            saveCtrlSToolStripMenuItem.Click += saveCtrlSToolStripMenuItem_Click;
            // 
            // clearCtrlCToolStripMenuItem
            // 
            clearCtrlCToolStripMenuItem.Name = "clearCtrlCToolStripMenuItem";
            clearCtrlCToolStripMenuItem.Size = new Size(154, 22);
            clearCtrlCToolStripMenuItem.Text = "Clear     Ctrl +C";
            clearCtrlCToolStripMenuItem.Click += clearCtrlCToolStripMenuItem_Click;
            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(154, 22);
            exitAltF4ToolStripMenuItem.Text = "Exit        Alt+F4";
            exitAltF4ToolStripMenuItem.Click += exitAltF4ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(316, 252);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 276);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openCtrlOToolStripMenuItem;
        private ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem clearCtrlCToolStripMenuItem;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private RichTextBox richTextBox1;
    }
}