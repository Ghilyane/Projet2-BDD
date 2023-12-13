using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class frmPartieGolf : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        AjoutPartiesDeGolf ajp = new AjoutPartiesDeGolf();

        public frmPartieGolf()
        {
            InitializeComponent();
        }

        private void frmPartieGolf_Load(object sender, EventArgs e)
        {
            partiesJoueesBindingSource.DataSource = monDataContext.PartiesJouees;
            toolStripLblTotal.Text = String.Format("de {0}", partiesJoueesBindingSource.Count);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajp.ShowDialog();
        }

        private void idAbonnementTextBox_TextChanged(object sender, EventArgs e)
        {
            tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            partiesJoueesBindingSource.MoveNext();
            tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
        }

        private void BtnDernier_Click(object sender, EventArgs e)
        {
            partiesJoueesBindingSource.MoveLast();
            tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
        }

        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            partiesJoueesBindingSource.MovePrevious();
            tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
        }

        private void BtnPremier_Click(object sender, EventArgs e)
        {
            partiesJoueesBindingSource.MoveFirst();
            tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
        }
    }
}
