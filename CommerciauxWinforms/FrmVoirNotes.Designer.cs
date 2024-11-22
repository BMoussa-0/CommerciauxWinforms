namespace CommerciauxWinforms
{
    partial class FrmVoirNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbCommerciaux = new GroupBox();
            grbNotes = new GroupBox();
            cmbCommerciaux = new ComboBox();
            lstNotes = new ListBox();
            btnFermer = new Button();
            grbCommerciaux.SuspendLayout();
            grbNotes.SuspendLayout();
            SuspendLayout();
            // 
            // grbCommerciaux
            // 
            grbCommerciaux.Controls.Add(cmbCommerciaux);
            grbCommerciaux.Location = new Point(37, 26);
            grbCommerciaux.Name = "grbCommerciaux";
            grbCommerciaux.Size = new Size(409, 71);
            grbCommerciaux.TabIndex = 0;
            grbCommerciaux.TabStop = false;
            grbCommerciaux.Text = "Commerciaux";
            // 
            // grbNotes
            // 
            grbNotes.Controls.Add(lstNotes);
            grbNotes.Location = new Point(37, 120);
            grbNotes.Name = "grbNotes";
            grbNotes.Size = new Size(751, 239);
            grbNotes.TabIndex = 1;
            grbNotes.TabStop = false;
            grbNotes.Text = "Notes de frais";
            // 
            // cmbCommerciaux
            // 
            cmbCommerciaux.FormattingEnabled = true;
            cmbCommerciaux.Location = new Point(44, 26);
            cmbCommerciaux.Name = "cmbCommerciaux";
            cmbCommerciaux.Size = new Size(151, 28);
            cmbCommerciaux.TabIndex = 0;
            cmbCommerciaux.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lstNotes
            // 
            lstNotes.FormattingEnabled = true;
            lstNotes.Location = new Point(6, 38);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(739, 184);
            lstNotes.TabIndex = 0;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(352, 393);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 29);
            btnFermer.TabIndex = 2;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += button1_Click;
            // 
            // FrmVoirNotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFermer);
            Controls.Add(grbNotes);
            Controls.Add(grbCommerciaux);
            Name = "FrmVoirNotes";
            Text = "FrmVoirNotes";
            Load += FrmVoirNotes_Load;
            grbCommerciaux.ResumeLayout(false);
            grbNotes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCommerciaux;
        private ComboBox cmbCommerciaux;
        private GroupBox grbNotes;
        private ListBox lstNotes;
        private Button btnFermer;
    }
}