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
    public partial class AjoutPartiesDeGolf : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public AjoutPartiesDeGolf()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var dateAbonnement = from abonnement in dataContext.Abonnements
                                 where abonnement.Id == cbAbonnement.SelectedValue.ToString()
                                 select abonnement.DateAbonnement;

            bool booValide = true;

            foreach (var parties in dateAbonnement)
            {
                booValide = !verificationErreur(parties.Year != DateTime.Now.Year,cbAbonnement ,"L'abonnement sélectionné est expiré. Veuillez le renouveller pour enregistrer une parties!") && booValide;
                MessageBox.Show((parties.Year == DateTime.Now.Year).ToString());

                if (booValide)
                {
                    var partiesJouees = new PartiesJouees
                    {
                        IdAbonnement = cbAbonnement.SelectedValue.ToString(),
                        NoTerrain = int.Parse(cbTerrain.SelectedValue.ToString()),
                        DatePartie = datePartie.Value,
                        Pointage = int.Parse(nudComptage.Value.ToString()),
                        Remarque = txtRemarque.Text
                    };
                    dataContext.PartiesJouees.InsertOnSubmit(partiesJouees);

                    try
                    {
                        dataContext.SubmitChanges();
                        MessageBox.Show("La partie a été enregistrées avec succès");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible d'enregistrer la partie!!!");
                    }
                }
            }
        }
        private bool verificationErreur(bool booCondition, Control control, string strMessage)
        {
            if (booCondition)
                errMessage.SetError(control, strMessage);

            return booCondition;
        }

        private void AjoutPartiesDeGolf_Load(object sender, EventArgs e)
        {
            var AbonnementsParties =
                from abonnement in dataContext.Abonnements
                select new { identifiant = abonnement.Id + "(" + abonnement.Nom + " " + abonnement.Prenom + ")", id = abonnement.Id, dateAbonnement = abonnement.DateAbonnement };

            var terrainSelectionne =
                from terrain in dataContext.Terrains
                select new { nom = terrain.Nom, no = terrain.No }; 

            /*Affichage de tous les abonnements principaux dans cbAbonnement*/
            cbAbonnement.DataSource = AbonnementsParties.Select(a => new { Key = a.identifiant, Value = a.id }).ToList();
            cbAbonnement.DisplayMember = "Key";
            cbAbonnement.ValueMember = "Value";

            /*Affichage de tous les noms de terrains dans cbAbonnement*/
            cbTerrain.DataSource = terrainSelectionne.Select(a => new { Key = a.nom, Value = a.no }).ToList();
            cbTerrain.DisplayMember = "Key";
            cbTerrain.ValueMember = "Value";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
