using libCommerciauxV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommerciauxWinforms
{
    public partial class FrmAjoutNote : Form
    {
        private ServiceCommercial leService;
        private char type;
        public FrmAjoutNote(ServiceCommercial leService)
        {
            this.leService = leService;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.grbKm.Visible = false;
            this.grbMontant.Visible = true;
            this.grbZone.Visible = false;
            this.type = 'R';
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.grbKm.Visible = false;
            this.grbMontant.Visible = false;
            this.grbZone.Visible = true;
            this.type = 'N';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmAjoutNote_Load(object sender, EventArgs e)
        {
            if(leService != null && leService.LesCommerciaux !=null)
            foreach (Commercial c in leService.LesCommerciaux)
            {
                string s = $"{c.Nom} {c.Prenom}";
                lstCommerciaux.Items.Add(s);
            }
            else
            {
                MessageBox.Show("Aucun commercial trouvé");
            }
        }

        private void rdbTransport_CheckedChanged(object sender, EventArgs e)
        {
            this.grbKm.Visible = true;
            this.grbMontant.Visible = false;
            this.grbZone.Visible = false;
            this.type = 'T';

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbZone_Enter(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            try
            {
                // On récupère le nom et le prénom dans une chaine de caractères 
                string s = this.lstCommerciaux.SelectedItem.ToString();
                // la variable tc est le séparateur
                char[] tc = { ' ' };
                // Slipt permet de découper une chaine de caractères en respectant le séparateur 
                string[] t = s.Split(tc);
                string nom = t[0];
                string prenom = t[t.Length - 1];
                DateTime dt = this.dateTP.Value.Date;
                Commercial c = leService.getCommercial(nom, prenom);

                // Gestion de la region
                char region = '1';
                if (this.rdb2.Checked)
                    region = '2';
                if (this.rdb3.Checked)
                    region = '3';

                // Gestion du type de frais
                switch (this.type)
                {
                    case 'T': leService.AjouterNote(c, dt, Convert.ToInt32(this.txtKm.Text)); break;
                    case 'R': leService.AjouterNote(c, dt, Convert.ToDouble(this.txtMontant.Text)); break;
                    case 'N': leService.AjouterNote(c, dt, Convert.ToDouble(this.txtMontant.Text), region); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
