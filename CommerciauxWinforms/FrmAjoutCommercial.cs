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
    public partial class FrmAjoutCommercial : Form
    {
        private ServiceCommercial leService;
        public FrmAjoutCommercial(ServiceCommercial leService)
        {
            InitializeComponent();
            this.leService = leService;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puissance = Convert.ToInt32(this.lstPuissance.SelectedItem.ToString());
            char c = 'A';
            if (this.rdBB.Checked)
                c = 'B';
            if (this.rdBC.Checked)
                c = 'C';
            Commercial cm = new Commercial(this.txtNom.Text, this.txtPrenom.Text, puissance, c);
            leService.AjouterCommercial(cm);
        }

        private void FrmAjoutCommercial_Load(object sender, EventArgs e)
        {
            for (int i = 5; i < 25; i++)
                this.lstPuissance.Items.Add(i);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
