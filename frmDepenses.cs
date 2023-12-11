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
    public partial class frmDepenses : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        frmAjoutDepense frmAD = new frmAjoutDepense();
        public frmDepenses()
        {
            InitializeComponent();
        }

        private void frmDepenses_Load(object sender, EventArgs e)
        {
            depensesBindingSource.DataSource = dataContext.Depenses;
            toolStripLblTotal.Text = String.Format("de {0}", depensesBindingSource.Count);
        }

        private void BtnPremier_Click(object sender, EventArgs e)
        {
            depensesBindingSource.MoveFirst();
        }

        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            depensesBindingSource.MovePrevious();
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            depensesBindingSource.MoveNext();
        }

        private void BtnDernier_Click(object sender, EventArgs e)
        {
            depensesBindingSource.MoveLast();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAD.ShowDialog();
        }
    }
}
