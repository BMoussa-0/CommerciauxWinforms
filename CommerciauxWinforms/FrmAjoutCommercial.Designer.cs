namespace CommerciauxWinforms
{
    partial class FrmAjoutCommercial
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
            labelNom = new Label();
            labelPrenom = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            labelPuissanceVoiture = new Label();
            lstPuissance = new ListBox();
            grpboxCategorie = new GroupBox();
            rdBC = new RadioButton();
            rdBB = new RadioButton();
            rdBA = new RadioButton();
            btnValider = new Button();
            btnFermer = new Button();
            grpboxCategorie.SuspendLayout();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(12, 13);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(42, 20);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(12, 56);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(60, 20);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "Prenom";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(80, 6);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(80, 53);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 3;
            // 
            // labelPuissanceVoiture
            // 
            labelPuissanceVoiture.AutoSize = true;
            labelPuissanceVoiture.Location = new Point(36, 121);
            labelPuissanceVoiture.Name = "labelPuissanceVoiture";
            labelPuissanceVoiture.Size = new Size(123, 20);
            labelPuissanceVoiture.TabIndex = 4;
            labelPuissanceVoiture.Text = "Puissance Voiture";
            // 
            // lstPuissance
            // 
            lstPuissance.FormattingEnabled = true;
            lstPuissance.Location = new Point(184, 121);
            lstPuissance.Name = "lstPuissance";
            lstPuissance.Size = new Size(150, 104);
            lstPuissance.TabIndex = 5;
            // 
            // grpboxCategorie
            // 
            grpboxCategorie.Controls.Add(rdBC);
            grpboxCategorie.Controls.Add(rdBB);
            grpboxCategorie.Controls.Add(rdBA);
            grpboxCategorie.Location = new Point(12, 163);
            grpboxCategorie.Name = "grpboxCategorie";
            grpboxCategorie.Size = new Size(147, 135);
            grpboxCategorie.TabIndex = 6;
            grpboxCategorie.TabStop = false;
            grpboxCategorie.Text = "Catégorie";
            // 
            // rdBC
            // 
            rdBC.AutoSize = true;
            rdBC.Location = new Point(13, 96);
            rdBC.Name = "rdBC";
            rdBC.Size = new Size(39, 24);
            rdBC.TabIndex = 2;
            rdBC.TabStop = true;
            rdBC.Text = "C";
            rdBC.UseVisualStyleBackColor = true;
            // 
            // rdBB
            // 
            rdBB.AutoSize = true;
            rdBB.Location = new Point(13, 66);
            rdBB.Name = "rdBB";
            rdBB.Size = new Size(39, 24);
            rdBB.TabIndex = 1;
            rdBB.TabStop = true;
            rdBB.Text = "B";
            rdBB.UseVisualStyleBackColor = true;
            // 
            // rdBA
            // 
            rdBA.AutoSize = true;
            rdBA.Location = new Point(13, 36);
            rdBA.Name = "rdBA";
            rdBA.Size = new Size(40, 24);
            rdBA.TabIndex = 0;
            rdBA.TabStop = true;
            rdBA.Text = "A";
            rdBA.UseVisualStyleBackColor = true;
            rdBA.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(281, 389);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 7;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += button1_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(424, 389);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 29);
            btnFermer.TabIndex = 8;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // FrmAjoutCommercial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFermer);
            Controls.Add(btnValider);
            Controls.Add(grpboxCategorie);
            Controls.Add(lstPuissance);
            Controls.Add(labelPuissanceVoiture);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(labelPrenom);
            Controls.Add(labelNom);
            Name = "FrmAjoutCommercial";
            Text = "FrmAjoutCommercial";
            Load += FrmAjoutCommercial_Load;
            grpboxCategorie.ResumeLayout(false);
            grpboxCategorie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelPrenom;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private Label labelPuissanceVoiture;
        private ListBox lstPuissance;
        private GroupBox grpboxCategorie;
        private RadioButton rdBC;
        private RadioButton rdBB;
        private RadioButton rdBA;
        private Button btnValider;
        private Button btnFermer;
    }
}