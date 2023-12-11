using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class frmReabonnements : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public frmReabonnements()
        {
            InitializeComponent();
        }

        private void frmReabonnements_Load(object sender, EventArgs e)
        {

            noetNomAbonnementsBindingSource.DataSource = from unAbonnement in monDataContext.Abonnements
                                                         orderby unAbonnement.Id
                                                         where !(from unReabonnement in monDataContext.Reabonnements select unReabonnement.IdAbonnement).Contains(unAbonnement.Id)
                                                         select new NoetNomAbonnements(unAbonnement.Id, unAbonnement.Prenom + " " + unAbonnement.Nom);
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            errMessage.Clear();
            int intRow = dgAbonnements.CurrentCell.RowIndex;
            string strIdAbonne = (string)dgAbonnements.Rows[intRow].Cells[0].Value;

            var requete = from unRea in monDataContext.Reabonnements
                          where unRea.IdAbonnement == strIdAbonne && unRea.DateReabonnement.Year == DateTime.Today.Year
                          select unRea;

            int intNbAbonnes = requete.Count();
            string strRemarque = tbRemarque.Text;

            if (tbRemarque.Text != "" && tbRemarque.Text.Length > 40)
            {
                errMessage.SetError(tbRemarque, $"a remarque ne doit pas dépasser 40 caractères. Vous en avez {tbRemarque.Text.Length - 40} de trop ");
                return;
            }
            if (intNbAbonnes == 0)
            {
                var unReabonnement = new Reabonnements
                {
                    IdAbonnement = strIdAbonne,
                    DateReabonnement = DateTime.Today,
                    Remarque = (tbRemarque.Text == "") ? null : tbRemarque.Text
                };

                monDataContext.Reabonnements.InsertOnSubmit(unReabonnement);

                using (var porteTransaction = new TransactionScope())
                {

                    try
                    {
                        monDataContext.SubmitChanges();
                        MessageBox.Show("Le réabonnement de l'abonnement " + strIdAbonne + " a été enregistré. ", "Enregistrement d'un réabonnement");
                        porteTransaction.Complete();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                    }
                }

            }
            else
                MessageBox.Show("Il est impossible d'effectué un réabonnement, car l'abonné en a déjà un à son compte cette année", "Erreur !");
        }

     
    }
}
