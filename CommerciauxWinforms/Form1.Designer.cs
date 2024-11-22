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
            ToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            enregistrerToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            nouvelleNoteDeFraisToolStripMenuItem = new ToolStripMenuItem();
            visualiserToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem, ToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvrirToolStripMenuItem, enregistrerToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(66, 24);
            ToolStripMenuItem.Text = "Fichier";
            ToolStripMenuItem.Click += uuuuToolStripMenuItem_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(163, 26);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // enregistrerToolStripMenuItem
            // 
            enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            enregistrerToolStripMenuItem.Size = new Size(163, 26);
            enregistrerToolStripMenuItem.Text = "Enregistrer";
            enregistrerToolStripMenuItem.Click += enregistrerToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, nouvelleNoteDeFraisToolStripMenuItem, visualiserToolStripMenuItem });
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(103, 24);
            ToolStripMenuItem1.Text = "Commercial";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(238, 26);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // nouvelleNoteDeFraisToolStripMenuItem
            // 
            nouvelleNoteDeFraisToolStripMenuItem.Name = "nouvelleNoteDeFraisToolStripMenuItem";
            nouvelleNoteDeFraisToolStripMenuItem.Size = new Size(238, 26);
            nouvelleNoteDeFraisToolStripMenuItem.Text = "Nouvelle note de frais";
            nouvelleNoteDeFraisToolStripMenuItem.Click += nouvelleNoteDeFraisToolStripMenuItem_Click;
            // 
            // visualiserToolStripMenuItem
            // 
            visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            visualiserToolStripMenuItem.Size = new Size(238, 26);
            visualiserToolStripMenuItem.Text = "Visualiser Notes";
            visualiserToolStripMenuItem.Click += visualiserToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
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
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem1;
        private ToolStripMenuItem enregistrerToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem nouvelleNoteDeFraisToolStripMenuItem;
        private ToolStripMenuItem visualiserToolStripMenuItem;
    }
}
