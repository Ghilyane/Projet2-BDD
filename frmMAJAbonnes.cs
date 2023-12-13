using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetFinal
{

    public partial class frmMAJAbonnes : Form
    {
        bool booAbonnementValide = true;
        bool booDependantValide = true;
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public frmMAJAbonnes()
        {
            InitializeComponent();
        }

        private void frmMAJAbonnes_Load(object sender, EventArgs e)
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

        private bool verificationErreur(bool booCondition, DataGridViewRow row, string strMessage, string strColonne)
        {

            if (booCondition)
            {
                row.Cells[strColonne].ErrorText = strMessage;
            }

            return booCondition;
        }

        private void dgAbonnements_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgDependants_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (booAbonnementValide && booDependantValide)
            {
                abonnementsBindingSource.EndEdit();
                using (var porteTransaction = new TransactionScope())
                {
                    try
                    {
                        monDataContext.SubmitChanges();
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
            else
            {
                int intErreurs = 0;

                foreach (DataGridViewRow row in dgDependants.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ErrorText != "")
                        {
                            intErreurs++;
                            break;
                        }
                    }
                }

                MessageBox.Show("Veuillez corriger tous vos erreurs avant d'enregistrer vos modifications", "Attention");
            }

        }


        private void dgAbonnements_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            valider(e.RowIndex, e.ColumnIndex);
        }

        private void valider(int rowIndex, int columnIndex)
        {

            dgAbonnements.Rows[rowIndex].Cells[columnIndex].ErrorText = string.Empty;

            booAbonnementValide = true;
            var exprNomPrenom = new Regex(@"^(([A-Z]|[a-z]|[À-Ü]|[à-ü])+([ '-]?([A-Z]|[a-z]|[À-Ü]|[à-ü])+)*)$");
            var exprCodeCivil = new Regex(@"^\d{1,7}$");
            var exprCourriel = new Regex(@"^$");

            //string messageErreur = string.Empty;
            DataGridViewRow row = dgAbonnements.Rows[rowIndex];

            string[] colonnes = { "dgPrenom", "dgSexe", "dgNoCivique", "dgRue", "dgVille", "dgProvince", "dgCodePostal", "dgTelephone", "dgCellulaire", "dgCourriel", "dgRemarque" };

            string strPrenom = row.Cells[colonnes[0]].Value?.ToString() ?? string.Empty;
            string strSexe = row.Cells[colonnes[1]].Value?.ToString() ?? string.Empty;
            string strNoCivique = row.Cells[colonnes[2]].Value?.ToString() ?? string.Empty;
            string strRue = row.Cells[colonnes[3]].Value?.ToString() ?? string.Empty;
            string strVille = row.Cells[colonnes[4]].Value?.ToString() ?? string.Empty;
            string strProvince = row.Cells[colonnes[5]].Value?.ToString() ?? string.Empty;
            string strCodePostal = row.Cells[colonnes[6]].Value?.ToString() ?? string.Empty;
            string strTelephone = row.Cells[colonnes[7]].Value?.ToString() ?? string.Empty;
            string strCellulaire = row.Cells[colonnes[8]].Value.ToString() ?? string.Empty;
            string strCourriel = row.Cells[colonnes[9]].Value?.ToString() ?? string.Empty;
            string strRemarque = row.Cells[colonnes[10]].Value.ToString() ?? string.Empty;


            foreach (string colonne in colonnes)
            {
                row.Cells[colonne].ErrorText = string.Empty;
            }

            //Prénom
            booAbonnementValide = !verificationErreur(!exprNomPrenom.IsMatch(strPrenom), row, "Le prénom peut seulement avoir des lettres, des tirets, des espaces et apostrophes.", "dgPrenom") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(strPrenom.Length < 2 || strPrenom.Length > 15, row, "Le prénom doit avoir entre 2 à 15 caractères.", "dgPrenom") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strPrenom), row, "Veuillez saisir un prénom.", "dgPrenom") && booAbonnementValide;

            //MessageBox.Show("valide : " + booValide);

            //Sexe
            //booValide = !verificationErreur(cbSexe.Text.Trim() == "", cbSexe, "Veuillez saisir un sexe.") && booValide;

            //Téléphone
            booAbonnementValide = !verificationErreur(strTelephone.Length != 10, row, "Le numéro de téléphone doit contenir 10 caractères.", "dgTelephone") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strTelephone), row, "Le numéro de téléphone doit contenir 10 caractères.", "dgTelephone") && booAbonnementValide;

            //Cellulaire
            booAbonnementValide = !verificationErreur(!string.IsNullOrEmpty(strCellulaire) && strCellulaire.Length != 10, row, "Le numéro de cellulaire doit contenir 10 caractères.", "dgCellulaire") && booAbonnementValide;

            //Courriel
            var email = new EmailAddressAttribute();
            bool boo = email.IsValid(strCourriel);
            int nbCourriels = (from unAbonnement in monDataContext.Abonnements
                               where unAbonnement.Courriel == strCourriel
                               select unAbonnement).Count();

            //booValide = verificationErreur(nbCourriels > 1, row, "Ce courriel a déjà été utilisé.", "dgCourriel") && booValide;
            booAbonnementValide = !verificationErreur(!email.IsValid(strCourriel), row, "Veuillez saisir un courriel valide.", "dgCourriel") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strCourriel), row, "Veuillez saisir un courriel.", "dgCourriel") && booAbonnementValide;

            //No civique
            booAbonnementValide = !verificationErreur(!exprCodeCivil.IsMatch(strNoCivique.Trim()) || Int32.Parse(strNoCivique) < 1, row, "Le numéro peut contenir entre 1 à 6 chiffres et être supérieur à zéro.", "dgNoCivique") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strNoCivique), row, "Veuillez saisir un code civil.", "dgNoCivique") && booAbonnementValide;

            //Rue
            booAbonnementValide = !verificationErreur(!exprNomPrenom.IsMatch(strRue), row, "La rue peut seulement avoir des lettres, des tirets, des espaces et apostrophes.", "dgRue") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(strRue.Length < 4 || strRue.Length > 15, row, "La rue doit avoir entre 4 à 15 caractères.", "dgRue") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strRue), row, "Veuillez saisir une rue.", "dgRue") && booAbonnementValide;

            //Ville
            booAbonnementValide = !verificationErreur(!exprNomPrenom.IsMatch(strVille), row, "La ville peut seulement avoir des lettres, des tirets, des espaces et apostrophes.", "dgVille") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(strVille.Length < 3 || strVille.Length > 20, row, "La ville doit avoir entre 3 à 20 caractères", "dgVille") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strVille), row, "Veuillez saisir une ville.", "dgVille") && booAbonnementValide;

            //Province
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strProvince), row, "Veuillez saisir une province.", "dgProvince") && booAbonnementValide;

            //Code postal
            booAbonnementValide = !verificationErreur(strCodePostal.Length != 6, row, "Le code postal doit avoir 6 caractères.", "dgCodePostal") && booAbonnementValide;
            booAbonnementValide = !verificationErreur(string.IsNullOrEmpty(strCodePostal), row, "Veuillez saisir un code postal.", "dgCodePostal") && booAbonnementValide;

            //Remarque
            booAbonnementValide = !verificationErreur(strRemarque.Length > 40, row, "La remarque ne doit pas avoir avoir plus de 40 caractères.", "dgRemarque") && booAbonnementValide;

        }

        private void dgDependants_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //dgDependants.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;

            booDependantValide = true;
            var exprNomPrenom = new Regex(@"^(([A-Z]|[a-z]|[À-Ü]|[à-ü])+([ '-]?([A-Z]|[a-z]|[À-Ü]|[à-ü])+)*)$");

            //DataGridViewRow row = dgDependants.Rows[e.RowIndex];


            string strNom = dgDependants["dgNomD", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strPrenom = dgDependants["dgPrenomD", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strSexe = dgDependants["dgSexeD", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strRemarque = dgDependants["dgRemarqueD", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strMessage = string.Empty;

            if (string.IsNullOrEmpty(strPrenom) || string.IsNullOrEmpty(strNom))
            {
                strMessage = "Veuillez saisir un nom et un prénom.";
            }
            else
            {
                if (strNom.Length < 2 || strNom.Length > 15)
                {
                    strMessage = "Le nom doit avoir entre 2 à 15 caractères.";
                }
                else if (!exprNomPrenom.IsMatch(strNom))
                {
                    strMessage = "Le nom peut seulement avoir des lettres, des tirets, des espaces et apostrophes.";
                }
                else if (strPrenom.Length < 2 || strPrenom.Length > 15)
                {
                    strMessage = "Le prénom doit avoir entre 2 à 15 caractères.";
                }
                else if (!exprNomPrenom.IsMatch(strPrenom))
                {
                    strMessage = "Le prénom peut seulement avoir des lettres, des tirets, des espaces et apostrophes.";
                }
                else if (strRemarque.Length > 40)
                {
                    strMessage = "La remarque ne doit pas avoir avoir plus de 40 caractères.";
                }
            }
            dgDependants.Rows[e.RowIndex].ErrorText = strMessage;

            if (strMessage != string.Empty)
            {
                e.Cancel = true;
                dgAbonnements.Enabled = false;
            }
            else
            {
                dgAbonnements.Enabled = true;
            }
        }
    }
}
