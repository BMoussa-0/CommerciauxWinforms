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
    public partial class FrmVoirNotes : Form
    {
        private ServiceCommercial leService;
        public FrmVoirNotes(ServiceCommercial leService)
        {
            InitializeComponent();
            this.leService = leService;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstNotes.Items.Clear();
            string s = this.cmbCommerciaux.SelectedItem.ToString();
            char[] tc = { ' ' };
            string[] t = s.Split(tc);
            string nom = t[0];
            string prenom = t[t.Length - 1];
            Commercial c = leService.getCommercial(nom, prenom);
            foreach (NoteFrais nf in leService.MesNotes)
            {
                if (nf.LeCommercial.Nom == nom && nf.LeCommercial.Prenom == prenom)
                {
                    string sn = nf.ToString();
                    this.lstNotes.Items.Add(sn);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVoirNotes_Load(object sender, EventArgs e)
        {
            string s;
            foreach (Commercial c in leService.LesCommerciaux)
            {
                s = $"{c.Nom} {c.Prenom}";
                cmbCommerciaux.Items.Add(s);
            }
        }
    }
}
