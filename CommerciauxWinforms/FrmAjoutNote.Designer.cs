namespace CommerciauxWinforms
{
    partial class FrmAjoutNote
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lstCommerciaux = new ListBox();
            dateTP = new DateTimePicker();
            label2 = new Label();
            lblDate = new Label();
            label9 = new Label();
            label12 = new Label();
            rdbRepas = new RadioButton();
            rdbTransport = new RadioButton();
            rdb2 = new RadioButton();
            rdb1 = new RadioButton();
            rdbNuite = new RadioButton();
            rdb3 = new RadioButton();
            grbZone = new GroupBox();
            grbType = new GroupBox();
            grbKm = new GroupBox();
            txtKm = new TextBox();
            grbMontant = new GroupBox();
            txtMontant = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnValider = new Button();
            btnFermer = new Button();
            grbZone.SuspendLayout();
            grbType.SuspendLayout();
            grbKm.SuspendLayout();
            grbMontant.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Commerciaux";
            label1.Click += label1_Click;
            // 
            // lstCommerciaux
            // 
            lstCommerciaux.FormattingEnabled = true;
            lstCommerciaux.Location = new Point(133, 22);
            lstCommerciaux.Name = "lstCommerciaux";
            lstCommerciaux.Size = new Size(150, 104);
            lstCommerciaux.TabIndex = 1;
            // 
            // dateTP
            // 
            dateTP.Location = new Point(83, 155);
            dateTP.Name = "dateTP";
            dateTP.Size = new Size(250, 27);
            dateTP.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 254);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(27, 155);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(283, 254);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 422);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 13;
            // 
            // rdbRepas
            // 
            rdbRepas.AutoSize = true;
            rdbRepas.Location = new Point(104, 37);
            rdbRepas.Name = "rdbRepas";
            rdbRepas.Size = new Size(70, 24);
            rdbRepas.TabIndex = 14;
            rdbRepas.TabStop = true;
            rdbRepas.Text = "Repas";
            rdbRepas.UseVisualStyleBackColor = true;
            rdbRepas.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbTransport
            // 
            rdbTransport.AutoSize = true;
            rdbTransport.Location = new Point(6, 37);
            rdbTransport.Name = "rdbTransport";
            rdbTransport.Size = new Size(92, 24);
            rdbTransport.TabIndex = 15;
            rdbTransport.TabStop = true;
            rdbTransport.Text = "Transport";
            rdbTransport.UseVisualStyleBackColor = true;
            rdbTransport.CheckedChanged += rdbTransport_CheckedChanged;
            // 
            // rdb2
            // 
            rdb2.AutoSize = true;
            rdb2.Location = new Point(186, 26);
            rdb2.Name = "rdb2";
            rdb2.Size = new Size(38, 24);
            rdb2.TabIndex = 16;
            rdb2.TabStop = true;
            rdb2.Text = "2";
            rdb2.UseVisualStyleBackColor = true;
            rdb2.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rdb1
            // 
            rdb1.AutoSize = true;
            rdb1.Location = new Point(142, 26);
            rdb1.Name = "rdb1";
            rdb1.Size = new Size(38, 24);
            rdb1.TabIndex = 17;
            rdb1.TabStop = true;
            rdb1.Text = "1";
            rdb1.UseVisualStyleBackColor = true;
            rdb1.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rdbNuite
            // 
            rdbNuite.AutoSize = true;
            rdbNuite.Location = new Point(180, 37);
            rdbNuite.Name = "rdbNuite";
            rdbNuite.Size = new Size(66, 24);
            rdbNuite.TabIndex = 18;
            rdbNuite.TabStop = true;
            rdbNuite.Text = "Nuite";
            rdbNuite.UseVisualStyleBackColor = true;
            rdbNuite.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // rdb3
            // 
            rdb3.AutoSize = true;
            rdb3.Location = new Point(230, 26);
            rdb3.Name = "rdb3";
            rdb3.Size = new Size(38, 24);
            rdb3.TabIndex = 19;
            rdb3.TabStop = true;
            rdb3.Text = "3";
            rdb3.UseVisualStyleBackColor = true;
            // 
            // grbZone
            // 
            grbZone.Controls.Add(rdb1);
            grbZone.Controls.Add(rdb3);
            grbZone.Controls.Add(rdb2);
            grbZone.Location = new Point(27, 450);
            grbZone.Name = "grbZone";
            grbZone.Size = new Size(390, 67);
            grbZone.TabIndex = 20;
            grbZone.TabStop = false;
            grbZone.Text = "Région";
            grbZone.Enter += grbZone_Enter;
            // 
            // grbType
            // 
            grbType.Controls.Add(rdbTransport);
            grbType.Controls.Add(rdbRepas);
            grbType.Controls.Add(rdbNuite);
            grbType.Location = new Point(33, 218);
            grbType.Name = "grbType";
            grbType.Size = new Size(384, 90);
            grbType.TabIndex = 21;
            grbType.TabStop = false;
            grbType.Text = "Type de note";
            // 
            // grbKm
            // 
            grbKm.Controls.Add(txtKm);
            grbKm.Location = new Point(33, 319);
            grbKm.Name = "grbKm";
            grbKm.Size = new Size(384, 65);
            grbKm.TabIndex = 22;
            grbKm.TabStop = false;
            grbKm.Text = "Kilométrage";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(115, 26);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(125, 27);
            txtKm.TabIndex = 0;
            // 
            // grbMontant
            // 
            grbMontant.Controls.Add(txtMontant);
            grbMontant.Location = new Point(33, 392);
            grbMontant.Name = "grbMontant";
            grbMontant.Size = new Size(384, 52);
            grbMontant.TabIndex = 23;
            grbMontant.TabStop = false;
            grbMontant.Text = "Montant";
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(115, 19);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(125, 27);
            txtMontant.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnValider
            // 
            btnValider.Location = new Point(223, 668);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 25;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += buttonValider_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(437, 668);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(94, 29);
            btnFermer.TabIndex = 26;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // FrmAjoutNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 741);
            Controls.Add(btnFermer);
            Controls.Add(btnValider);
            Controls.Add(grbMontant);
            Controls.Add(grbKm);
            Controls.Add(grbType);
            Controls.Add(grbZone);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(lblDate);
            Controls.Add(label2);
            Controls.Add(dateTP);
            Controls.Add(lstCommerciaux);
            Controls.Add(label1);
            Name = "FrmAjoutNote";
            Text = "FrmAjoutNote";
            Load += FrmAjoutNote_Load;
            grbZone.ResumeLayout(false);
            grbZone.PerformLayout();
            grbType.ResumeLayout(false);
            grbType.PerformLayout();
            grbKm.ResumeLayout(false);
            grbKm.PerformLayout();
            grbMontant.ResumeLayout(false);
            grbMontant.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstCommerciaux;
        private DateTimePicker dateTP;
        private Label label2;
        private Label lblDate;
        private Label label9;
        private Label label12;
        private RadioButton rdbRepas;
        private RadioButton rdbTransport;
        private RadioButton rdb2;
        private RadioButton rdb1;
        private RadioButton rdbNuite;
        private RadioButton rdb3;
        private GroupBox grbZone;
        private GroupBox grbType;
        private GroupBox grbKm;
        private GroupBox grbMontant;
        private TextBox txtKm;
        private TextBox txtMontant;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnValider;
        private Button btnFermer;
    }
}