using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class frmAjoutDepense : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        frmConnnexion frmC = new frmConnnexion();
        public int intTypeEmploye;

        public frmAjoutDepense()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAjoutDepense_Load(object sender, EventArgs e)
        {
            var AbonnementsDepenses =
                from abonnement in dataContext.Abonnements
                select new { identifiant = abonnement.Id + "(" + abonnement.Nom + " " + abonnement.Prenom + ")", id = abonnement.Id, dateAbonnement = abonnement.DateAbonnement };

            intTypeEmploye = 1;
            MessageBox.Show(intTypeEmploye.ToString());
            if (intTypeEmploye == 1 || intTypeEmploye == 2 || intTypeEmploye == 3)
            {
                cbService.Enabled = true;
                cbService.Items.Add("Magasin Pro Shop");
                cbService.Items.Add("Restaurant");
                cbService.Items.Add("Leçon de golf");
            }
            else if (intTypeEmploye == 5)
            {
                cbService.Enabled = false;
                cbService.Items.Add("Magasin Pro Shop");

            }
            else if (intTypeEmploye == 6)
            {
                cbService.Enabled = false;
                cbService.Items.Add("Restaurant");

            }
            else if (intTypeEmploye == 7)
            {
                cbService.Enabled = false;
                cbService.Items.Add("Leçon de golf");

            }

            /*Affichage de tous les abonnements principaux dans cbAbonnement*/
            cbAbonnement.DataSource = AbonnementsDepenses.Select(a => new { Key = a.identifiant, Value = a.id }).ToList();
            cbAbonnement.DisplayMember = "Key";
            cbAbonnement.ValueMember = "Value";

            txtId.Text = (dataContext.Depenses.Count() + 1).ToString();
        }
    }
}
