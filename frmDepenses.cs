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
        frmDepenses frmAD = new frmDepenses();
        public int intTypeEmploye;
        public frmDepenses()
        {
            InitializeComponent();
        }

        private void frmDepenses_Load(object sender, EventArgs e)
        {
            depensesBindingSource.DataSource = dataContext.Depenses;
            toolStripLblTotal.Text = String.Format("de {0}", depensesBindingSource.Count);

            var nomCompletEmp = (from employe in dataContext.Employes
                                from service in dataContext.Services
                                where service.No == int.Parse(txtNo.Text)
                                && service.NoEmploye == employe.No
                                select new {nomComplet =  employe.Nom + " " + employe.Prenom}).FirstOrDefault();

            txtNomComplet.Text = nomCompletEmp.nomComplet;
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
            frmAD.intTypeEmploye = intTypeEmploye;
            frmAD.ShowDialog();
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            tbIndex.Text = (depensesBindingSource.Position + 1).ToString(); ;
        }
    }
}
