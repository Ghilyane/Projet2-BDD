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
            cbAbonnement.Select();

            var serviceExistant = (from service in dataContext.Services
                                  where service.NoEmploye == intTypeEmploye && service.TypeService == cbService.Text
                                  select service.No).FirstOrDefault();
            int numService = 0;
            Boolean vrai = false;
            if (cbService.ValueMember != null)
            {
                if (serviceExistant == 0)
                {
                    if (cbAbonnement.Text != "" && cbService.Text != "")
                    {
                        numService = dataContext.Services.Count() + 1;
                        var service = new Services
                        {
                            No = dataContext.Services.Count() + 1,
                            TypeService = cbService.Text,
                            NoEmploye = intTypeEmploye
                        };

                        dataContext.Services.InsertOnSubmit(service);

                        try
                        {
                            dataContext.SubmitChanges();
                            MessageBox.Show("Le service a été enregistrées avec succès");
                            vrai = true;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Impossible d'enregistrer le service!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez remplir les champs abonnement ou service pour pouvoir ajouter ce service.");

                    }
                }
                else
                {
                    numService = serviceExistant;
                    vrai = true;
                }

                if (vrai)
                {
                    var depense = new Depenses
                    {
                        No = int.Parse(txtNo.Text),
                        IdAbonnement = cbAbonnement.SelectedValue.ToString(),
                        DateDepense = dateDepense.Value,
                        Montant = nudMontant.Value,
                        NoService = numService,
                        Remarque = txtRemarque.Text
                    };

                    dataContext.Depenses.InsertOnSubmit(depense);

                    try
                    {
                        dataContext.SubmitChanges();
                        MessageBox.Show("La dépense a été enregistrées avec succès");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible d'enregistrer La dépense!!!");
                    }
                }  
            }
            else
            {
                MessageBox.Show("La sélection du service est nulle.");
            }

        }

        private void frmAjoutDepense_Load(object sender, EventArgs e)
        {
            var AbonnementsDepenses =
                from abonnement in dataContext.Abonnements
                select new { identifiant = abonnement.Id + "(" + abonnement.Nom + " " + abonnement.Prenom + ")", id = abonnement.Id, dateAbonnement = abonnement.DateAbonnement };

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
                cbService.Text = "Magasin Pro Shop";
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
            cbAbonnement.SelectedValue = "Value";

            txtNo.Text = (dataContext.Depenses.Count() + 1).ToString();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
