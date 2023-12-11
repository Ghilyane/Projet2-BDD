using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ProjetFinal
{
    public partial class frmPrixEtDepenses : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        private List<int> lignesModifiees = new List<int>();

        public frmPrixEtDepenses()
        {
            InitializeComponent();
        }

        private void frmPrixEtDepenses_Load(object sender, EventArgs e)
        {
            prixDepensesAbonnementsBindingSource.DataSource = from unPrix in monDataContext.PrixDepensesAbonnements
                                                      select unPrix;

            typesAbonnementBindingSource.DataSource = from unType in monDataContext.TypesAbonnement
                                                      select unType;
        }

        private void prixDepensesAbonnementsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            List<PrixDepensesAbonnements> listePrixDepenses = monDataContext.PrixDepensesAbonnements.ToList(); // Obtenez votre liste depuis la source de données


            prixDepensesAbonnementsBindingSource.EndEdit();
            using (var porteTransaction = new TransactionScope())
            {

                try
                {
                    for (int i = 0; i < listePrixDepenses.Count; i++)
                    {
                        if (lignesModifiees.Any(x => x == i))
                        {
                            PrixDepensesAbonnements objetModifie = new PrixDepensesAbonnements
                            {
                                NoTypeAbonnement = listePrixDepenses[i].NoTypeAbonnement,
                                Prix = (decimal)prixDepensesAbonnementsDataGridView["dgPrix", i].Value,
                                DepensesObligatoires = (decimal)prixDepensesAbonnementsDataGridView["dgDepenses", i].Value,
                                Annee = DateTime.Today.Year
                            };

                            PrixDepensesAbonnements prixSupprime = listePrixDepenses[i];
                            monDataContext.PrixDepensesAbonnements.InsertOnSubmit(objetModifie);
                            monDataContext.PrixDepensesAbonnements.DeleteOnSubmit(prixSupprime);
                            monDataContext.SubmitChanges();
                        };
                    }

                    MessageBox.Show("Les modifications ont été enregistrées!");
                }
                catch (ChangeConflictException)
                {
                    monDataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Erreur lors de l'enregistrement des données");
                }

                porteTransaction.Complete();
            }

        }

        private void prixDepensesAbonnementsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            string strPrix = prixDepensesAbonnementsDataGridView["dgPrix", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strDepenses = prixDepensesAbonnementsDataGridView["dgDepenses", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strMessage = string.Empty;
            var exprMontant = new Regex(@"^\d{1,7}$");


            if (string.IsNullOrEmpty(strPrix) || string.IsNullOrEmpty(strDepenses))
            {
                strMessage = "Veuillez inscrire un prix et une dépense.";
            }
            else
            {
                if (!Double.TryParse(strPrix, out _))
                {
                    strMessage = "Le prix doit être seulement composé de chiffres.";
                }
                else if (Convert.ToDouble(strPrix) < 0 || Convert.ToDouble(strPrix) > 10000)
                {
                    strMessage = "Le prix doit être compris entre 1 et 10 000$.";
                }
                else if (!Double.TryParse(strDepenses, out _))
                {
                    strMessage = "L doit être seulement composé de chiffres.";
                }
                else if (Convert.ToDouble(strDepenses) < 0 || Convert.ToDouble(strDepenses) > 10000)
                {
                    strMessage = "La dépense doit être comprise entre 1 et 10 000$.";
                }
            }
            prixDepensesAbonnementsDataGridView.Rows[e.RowIndex].ErrorText = strMessage;

            if (strMessage != string.Empty)
            {
                e.Cancel = true;
            }

        }

        private void prixDepensesAbonnementsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string strAnnee = prixDepensesAbonnementsDataGridView["dgAnnee", e.RowIndex].Value.ToString();
            int intAnneeActuelle = DateTime.Today.Year;

            if (intAnneeActuelle == Convert.ToInt32(strAnnee))
            {
                e.Cancel = true;
                MessageBox.Show("Vous devez attendre 2024 avant de pouvoir modifier ce type d'abonnement.");
            }
        }

        private void prixDepensesAbonnementsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (!lignesModifiees.Contains(rowIndex))
            {
                lignesModifiees.Add(rowIndex);
            }
        }
    }
}
