using libCommerciauxV2;
namespace CommerciauxWinforms
{
    public partial class Form1 : Form
    {
        private ServiceCommercial leService;
        private string nomFichier;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uuuuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                nomFichier = openFileDialog1.FileName;// contient le chemin
                this.leService = PersisteCommercial.Charge(nomFichier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersisteCommercial.sauve(this.leService, nomFichier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutCommercial f = new FrmAjoutCommercial(leService);
            f.MdiParent = this;
            f.Show();
        }

        private void nouvelleNoteDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutNote f = new FrmAjoutNote(leService);
            f.MdiParent = this;
            f.Show();
        }

        private void visualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVoirNotes f = new FrmVoirNotes(leService);
            f.MdiParent = this;
            f.Show();
        }
    }
}
