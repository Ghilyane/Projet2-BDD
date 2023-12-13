using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class frmAjoutAbonnement : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public Abonnements nouvelAbonnement = new Abonnements();
        frmAjoutDependant frmAjout = new frmAjoutDependant();
        private int intNbDependants = 0;
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _rectangle;
        private bool booAbonnementPrincipalValide = false;
        private bool booAbonnementDependantslValide = false;

        public frmAjoutAbonnement()
        {
            InitializeComponent();

            dgDependants.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
            dgDependants.Enabled = false;
            dgDependants.AllowUserToAddRows = false;
        }

        private void dtp_TextChange(Object sender, EventArgs e)
        {
            dgDependants.CurrentCell.Value = dtp.Text.ToString();
        }

        private void dgDependants_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dgDependants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgDependants.Columns[e.ColumnIndex].Name)
            {
                case "dgDate":
                    _rectangle = dgDependants.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_rectangle.Width, _rectangle.Height);
                    dtp.Location = new Point(_rectangle.X, _rectangle.Y);
                    dtp.Visible = true;
                    break;
            }
        }

        private void frmAjoutAbonnement_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource.DataSource = from unType in monDataContext.TypesAbonnement
                                                      select unType;
            provincesBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                                select uneProvince;

            //dgDependants.Columns[4].DefaultCellStyle.Format = "yy/mm/dd";
            cbSexe.Items.Add("Femme");
            cbSexe.Items.Add("Homme");

            cbSexeD.Items.Add("F");
            cbSexeD.Items.Add("H");
        }

        private bool dgDependantsErreur()
        {
            bool booDependantsValide = true;

            foreach (DataGridViewRow row in dgDependants.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ErrorText != string.Empty)
                    {
                        booDependantsValide = false;
                        break;
                    }
                }
            }

            if (booDependantsValide)
            {
                int intTypeAbonnement = (int)cbTypeAbonnement.SelectedValue;
                int nbLignesCorrectes = 0;

                foreach (DataGridViewRow row in dgDependants.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() != string.Empty &&
                        row.Cells.Cast<DataGridViewCell>().All(cell => cell.ErrorText == ""))
                    {
                        nbLignesCorrectes++;
                    }
                }

                if (nbLignesCorrectes != intNbDependants)
                {
                    MessageBox.Show("Veuillez entrer le nombre de dépendants requis.");
                    booDependantsValide = false;
                }
            }

            return booDependantsValide;
        }

        private void btnAjoutDependant_Click(object sender, EventArgs e)
        {
            booAbonnementPrincipalValide = validerAbonnementPrincipal();
            bool booDpendantsValide = dgDependantsErreur();


            //Transaction
            if (!booAbonnementPrincipalValide)
            {
                MessageBox.Show("Veuillez d'abord ajouter l'abonné principal");
            }
            else
            {

                if (booDpendantsValide)
                {
                    try
                    {
                        string numLien = "";

                        foreach (char c in nouvelAbonnement.Id)
                        {
                            if (char.IsDigit(c))
                            {
                                numLien += c;
                            }
                        }

                        using (var porteTransaction = new TransactionScope())
                        {
                            monDataContext.Abonnements.InsertOnSubmit(nouvelAbonnement);
                            foreach (DataGridViewRow row in dgDependants.Rows)
                            {
                                Dependants nouvelDependant = new Dependants();

                                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() != string.Empty &&
                                    row.Cells.Cast<DataGridViewCell>().All(cell => cell.ErrorText == ""))
                                {

                                    nouvelDependant.Id = (row.Index == 0) ? nouvelAbonnement.Nom + numLien + row.Cells["cbSexeD"].Value.ToString() + row.Index : nouvelAbonnement.Nom + numLien + "E" + row.Index;
                                    nouvelDependant.Nom = row.Cells["dgNom"].Value.ToString();
                                    nouvelDependant.Prenom = row.Cells["dgPrenom"].Value.ToString();
                                    nouvelDependant.Sexe = row.Cells["cbSexeD"].Value.ToString();
                                    nouvelDependant.DateNaissance = Convert.ToDateTime(row.Cells["dgDate"].Value.ToString());
                                    nouvelDependant.Remarque = (row.Cells["dgRemarque"].Value == null) ? null : row.Cells["dgRemarque"].Value.ToString();
                                    nouvelDependant.IdAbonnement = nouvelAbonnement.Id;

                                    monDataContext.Dependants.InsertOnSubmit(nouvelDependant);

                                }
                            }

                            monDataContext.SubmitChanges();
                            porteTransaction.Complete();
                            MessageBox.Show($"L'abonné {nouvelAbonnement.Id} a été enregistré. ", "Ajout d'un abonnement");
                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
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

        private void btnAjoutAbonnement_Click(object sender, EventArgs e)
        {
            booAbonnementPrincipalValide = validerAbonnementPrincipal();
            MessageBox.Show(booAbonnementPrincipalValide.ToString());
            if (booAbonnementPrincipalValide)
            {
                using (var porteTransaction = new TransactionScope())
                {
                    monDataContext.Abonnements.InsertOnSubmit(nouvelAbonnement);

                    try
                    {
                        monDataContext.SubmitChanges();
                        MessageBox.Show($"L'abonné {nouvelAbonnement.Id} a été enregistré. ", "Ajout d'un abonnement");
                        porteTransaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                    }
                }
            }
            this.Close();

        }

        private void cbTypeAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAjoutDependant.Enabled = (cbTypeAbonnement.SelectedValue.ToString() == "1" || cbTypeAbonnement.SelectedValue.ToString() == "2") ? false : true;
            btnAjoutAbonnement.Enabled = (cbTypeAbonnement.SelectedValue.ToString() == "1" || cbTypeAbonnement.SelectedValue.ToString() == "2") ? true : false;
            dgDependants.Enabled = (cbTypeAbonnement.SelectedValue.ToString() == "1" || cbTypeAbonnement.SelectedValue.ToString() == "2") ? false : true;

            int intTypeAbonnement = (int)cbTypeAbonnement.SelectedValue;
            
            numDependants.Visible = false;
            switch (intTypeAbonnement)
            {
                case 1:
                    intNbDependants = 0; break;
                case 2:
                    intNbDependants = 0; break;
                case 3:
                    intNbDependants = 1; break;
                case 4:
                    intNbDependants = 2; break;
                case 5:
                    intNbDependants = 3; break;
                case 6:
                    intNbDependants = (int)numDependants.Value;
                    numDependants.Visible = true;
                    break;
            }

            majDgDependants();
        }

        private bool validerAbonnementPrincipal()
        {
            bool booValide = true;
            var exprNomPrenom = new Regex(@"^(([A-Z]|[a-z]|[À-Ü]|[à-ü])+([ '-]?([A-Z]|[a-z]|[À-Ü]|[à-ü])+)*)$");
            var exprCodeCivil = new Regex(@"^\d{1,7}$");
            var exprCourriel = new Regex(@"^$");

            errMessage.Clear();
            string strNom = tbNom.Text.Trim();
            string strPrenom = tbPrenom.Text.Trim();
            string strCourriel = tbCourriel.Text.Trim();
            string strRue = tbRue.Text.Trim();
            string strVille = tbVille.Text.Trim();

            var dtAuj = DateTime.Today;
            var dtNaissance = dtpNaissance.Value;
            int intAge = dtAuj.Year - dtNaissance.Year;

            if (dtNaissance.Date > dtAuj.AddYears(-intAge)) intAge--;

            //Type abonnement
            booValide = !verificationErreur(cbTypeAbonnement.Text.Trim() == "", cbTypeAbonnement, "Veuillez choisir un type d'abonnement.") && booValide;

            //Nom
            booValide = !verificationErreur(!exprNomPrenom.IsMatch(strNom), tbNom, "Le nom peut seulement avoir des lettres, des tirets, des espaces et apostrophes.") && booValide;
            booValide = !verificationErreur(strNom.Length < 2 || strNom.Length > 15, tbNom, "Le nom doit avoir entre 2 à 15 caractères.") && booValide;
            booValide = !verificationErreur(strNom == "", tbNom, "Veuillez saisir un nom.") && booValide;
            //Prénom
            booValide = !verificationErreur(!exprNomPrenom.IsMatch(strPrenom), tbPrenom, "Le prénom peut seulement avoir des lettres, des tirets, des espaces et apostrophes.") && booValide;
            booValide = !verificationErreur(strPrenom.Length < 2 || strPrenom.Length > 15, tbPrenom, "Le prénom doit avoir entre 2 à 15 caractères.") && booValide;
            booValide = !verificationErreur(strPrenom == "", tbPrenom, "Veuillez saisir un prénom.") && booValide;
            //Sexe
            booValide = !verificationErreur(cbSexe.Text.Trim() == "", cbSexe, "Veuillez saisir un sexe.") && booValide;
            //Âge - à tester
            booValide = !verificationErreur(intAge < 18 || intAge > 110, dtpNaissance, "Veuillez saisir un âge entre 18 et 110 ans.") && booValide;
            booValide = !verificationErreur((int)cbTypeAbonnement.SelectedValue == 2 && intAge < 60, dtpNaissance, "L’âge minimum de l’abonné principal est de 60 ans pour les personnes de l’âge d’or.") && booValide;

            //Téléphone
            booValide = !verificationErreur(mtbTelephone.Text.Length != 10, mtbTelephone, "Le numéro de téléphone doit contenir 10 caractères.") && booValide;
            booValide = !verificationErreur(mtbTelephone.Text.Trim() == "", mtbTelephone, "Veuillez saisir un numéro de téléphone.") && booValide;

            //Cellulaire
            booValide = !verificationErreur(mtbCellulaire.Text.Trim() != "" && mtbCellulaire.Text.Length != 10, mtbCellulaire, "Le numéro de cellulaire doit contenir 10 caractères.") && booValide;

            //Courriel
            var email = new EmailAddressAttribute();
            bool boo = email.IsValid(strCourriel);
            int nbCourriels = (from unAbonnement in monDataContext.Abonnements
                               where unAbonnement.Courriel == tbCourriel.Text
                               select unAbonnement).Count();

            booValide = !verificationErreur(nbCourriels > 0, tbCourriel, "Ce courriel a déjà été utilisé.") && booValide;
            booValide = !verificationErreur(!email.IsValid(strCourriel), tbCourriel, "Veuillez saisir un courriel valide.") && booValide;
            booValide = !verificationErreur(strCourriel == "", tbCourriel, "Veuillez saisir un courriel.") && booValide;

            //Date d'abonnement - pas besoin

            //No civique
            booValide = !verificationErreur(!exprCodeCivil.IsMatch(tbNoCivique.Text.Trim()), tbNoCivique, "Le numéro peut contenir entre 1 à 6 chiffres.") && booValide;
            booValide = !verificationErreur(tbNoCivique.Text.Trim() == "", tbNoCivique, "Veuillez saisir un code civil.") && booValide;

            //Rue
            booValide = !verificationErreur(!exprNomPrenom.IsMatch(strRue), tbRue, "La rue peut seulement avoir des lettres, des tirets, des espaces et apostrophes.") && booValide;
            booValide = !verificationErreur(strRue.Length < 4 || strRue.Length > 15, tbRue, "La rue doit avoir entre 4 à 15 caractères") && booValide;
            booValide = !verificationErreur(strRue == "", tbRue, "Veuillez saisir une rue.") && booValide;

            //Ville
            booValide = !verificationErreur(!exprNomPrenom.IsMatch(strVille), tbVille, "La ville peut seulement avoir des lettres, des tirets, des espaces et apostrophes.") && booValide;
            booValide = !verificationErreur(strVille.Length < 3 || strVille.Length > 20, tbVille, "La ville doit avoir entre 3 à 20 caractères") && booValide;
            booValide = !verificationErreur(strVille == "", tbVille, "Veuillez saisir une ville.") && booValide;

            //Province
            booValide = !verificationErreur(cbProvince.Text.Trim() == "", cbProvince, "Veuillez choisir une province.") && booValide;

            //Code postal
            booValide = !verificationErreur(mtbCodePostal.Text.Length != 6, mtbCodePostal, "Le code postal doit avoir 6 caractères.") && booValide;
            booValide = !verificationErreur(mtbCodePostal.Text.Trim() == "", mtbCodePostal, "Veuillez choisir un code postal.") && booValide;


            //Remarque
            booValide = !verificationErreur(tbRemarque.Text.Trim().Length > 40, tbRemarque, "La remarque ne doit pas avoir avoir plus de 40 caractères.") && booValide;

            int intNoLien = (from unAbonnement in monDataContext.Abonnements
                             select unAbonnement).Count() + 1;

            if (booValide)
            {
                nouvelAbonnement.NoTypeAbonnement = (int)cbTypeAbonnement.SelectedValue;
                nouvelAbonnement.Id = $"{strNom}{intNoLien}P";
                nouvelAbonnement.Nom = strNom;
                nouvelAbonnement.Prenom = strPrenom;
                nouvelAbonnement.DateNaissance = dtpNaissance.Value;
                nouvelAbonnement.DateAbonnement = DateTime.Today;
                nouvelAbonnement.Sexe = (cbSexe.Text == "Femme") ? "F" : "H";
                nouvelAbonnement.Telephone = mtbTelephone.Text.Trim();
                nouvelAbonnement.Cellulaire = mtbCellulaire.Text.Trim();
                nouvelAbonnement.Courriel = tbCourriel.Text.Trim();
                nouvelAbonnement.Remarque = tbRemarque.Text.Trim();

                nouvelAbonnement.NoCivique = Int32.Parse(tbNoCivique.Text.Trim());
                nouvelAbonnement.Rue = tbRue.Text.Trim();
                nouvelAbonnement.Ville = strVille;
                nouvelAbonnement.IdProvince = (string)cbProvince.SelectedValue;
                nouvelAbonnement.CodePostal = mtbCodePostal.Text.Trim().ToUpper();
            }

            return booValide;
        }


        private void dgDependants_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgDependants.AllowUserToAddRows = (intNbDependants >= dgDependants.RowCount) ? true : false;
            int intIndex = e.Row.Index;
        }


        private void numDependants_ValueChanged(object sender, EventArgs e)
        {
            intNbDependants = (int)numDependants.Value;
            majDgDependants();
        }

        private void majDgDependants()
        {
            dgDependants.AllowUserToAddRows = (intNbDependants >= dgDependants.RowCount) ? true : false;

            while (intNbDependants < dgDependants.RowCount && intNbDependants > 0)
            {
                dgDependants.Rows.RemoveAt(dgDependants.Rows.Count - 1);
            }
        }

        private void dgDependants_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            booAbonnementDependantslValide = true;
            var exprNomPrenom = new Regex(@"^(([A-Z]|[a-z]|[À-Ü]|[à-ü])+([ '-]?([A-Z]|[a-z]|[À-Ü]|[à-ü])+)*)$");

            int intNoRow = e.RowIndex;

            string strNom = dgDependants["dgNom", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strPrenom = dgDependants["dgPrenom", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strSexe = dgDependants["cbSexeD", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strDate = dgDependants["dgDate", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strRemarque = dgDependants["dgRemarque", e.RowIndex].Value?.ToString() ?? string.Empty;
            string strMessage = string.Empty;

            var dtAuj = DateTime.Today;
            var dtNaissance = dtp.Value;

            int intAge = dtAuj.Year - dtNaissance.Year;

            if (dtNaissance.Date > dtAuj.AddYears(-intAge)) intAge--;


            if (string.IsNullOrEmpty(strPrenom) || string.IsNullOrEmpty(strNom) || string.IsNullOrEmpty(strSexe) || string.IsNullOrEmpty(strDate))
            {
                strMessage = "Veuillez saisir un prénom, nom, sexe et une date de naissance.";
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
                else if (intNoRow == 0)
                {
                    if (intAge < 18 || intAge > 110)
                        strMessage = "Veuillez saisir un âge entre 18 et 110 ans.";
                }
                else if (intNoRow > 0)
                {
                    if (intAge < 0 || intAge > 18)
                        strMessage = "Veuillez saisir un âge entre 0 et 18 ans.";
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
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
