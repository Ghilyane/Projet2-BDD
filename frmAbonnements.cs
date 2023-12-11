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
    public partial class frmAbonnements : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmAjoutAbonnement frmAjout = new frmAjoutAbonnement();
        public frmAbonnements()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            frmAjout.ShowDialog();
        }

        private void frmAbonnements_Load(object sender, EventArgs e)
        {
            abonnementsBindingSource.DataSource = from unAbonnement in monDataContext.Abonnements
                                               select unAbonnement;
            typesAbonnementBindingSource.DataSource = from unType in monDataContext.TypesAbonnement
                                                      select unType;
            provincesBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                                select uneProvince;
        }

        private void abonnementsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (abonnementsBindingSource.Current != null)
            {
                dependantsBindingSource.DataSource =
                    ((Abonnements)abonnementsBindingSource.Current).Dependants;
            }
        }

        private void abonnementsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
