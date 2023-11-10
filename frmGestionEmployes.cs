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
    public partial class frmGestionEmployes : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmAjoutEmploye frmAjout = new frmAjoutEmploye();
        public frmGestionEmployes()
        {
            InitializeComponent();
        }

        private void frmGestionEmployes_Load(object sender, EventArgs e)
        {
            //employesdg.Columns[0].
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               join uneProvince in monDataContext.Provinces
                                               on unEmploye.IdProvince equals uneProvince.Id
                                               //where unEmploye.IdProvince == uneProvince.Nom
                                               select unEmploye;
            typesEmployeBindingSource.DataSource = from unType in monDataContext.TypesEmploye
                                                   select unType;
            provincesBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                                select uneProvince;
            //List<string> myList = new List<string>();
            //myList.Add("Femme");
            //myList.Add("Homme");


            ////dgColumnCBSexe.Items.AddRange("Femme", "Homme");
            //dgColumnCBSexe.DataSource = myList;

            //// need to add an item to the list after it's bound
            //myList.Add("No records found.");


        }

        private void employesdg_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Employes nouvelEmploye = new Employes { };

            int noEmpMax = (from unEmploye in monDataContext.Employes
                           select unEmploye.No).Max() + 1;

            nouvelEmploye.No = noEmpMax;
            frmAjout.nouvelEmploye = nouvelEmploye;
            frmAjout.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
