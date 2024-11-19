namespace CommerciauxWinforms
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
            uuuuToolStripMenuItem = new ToolStripMenuItem();
            uuToolStripMenuItem = new ToolStripMenuItem();
            uuToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { uuuuToolStripMenuItem, uuToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uuuuToolStripMenuItem
            // 
            uuuuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uuToolStripMenuItem });
            uuuuToolStripMenuItem.Name = "uuuuToolStripMenuItem";
            uuuuToolStripMenuItem.Size = new Size(55, 24);
            uuuuToolStripMenuItem.Text = "uuuu";
            // 
            // uuToolStripMenuItem
            // 
            uuToolStripMenuItem.Name = "uuToolStripMenuItem";
            uuToolStripMenuItem.Size = new Size(224, 26);
            uuToolStripMenuItem.Text = "uu";
            // 
            // uuToolStripMenuItem1
            // 
            uuToolStripMenuItem1.Name = "uuToolStripMenuItem1";
            uuToolStripMenuItem1.Size = new Size(39, 24);
            uuToolStripMenuItem1.Text = "uu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uuuuToolStripMenuItem;
        private ToolStripMenuItem uuToolStripMenuItem;
        private ToolStripMenuItem uuToolStripMenuItem1;
    }
}
