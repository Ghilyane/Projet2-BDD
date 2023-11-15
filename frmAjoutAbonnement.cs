using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private bool booAbonnementPrincipalValide = false;

        public frmAjoutAbonnement()
        {
            InitializeComponent();
        }

        private void frmAjoutAbonnement_Load(object sender, EventArgs e)
        {
            typesAbonnementBindingSource.DataSource = from unType in monDataContext.TypesAbonnement
                                                      select unType;
            provincesBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                                select uneProvince;

            cbSexe.Items.Add("Femme");
            cbSexe.Items.Add("Homme");
        }

        private void btnAjoutDependant_Click(object sender, EventArgs e)
        {
            booAbonnementPrincipalValide = validerAbonnementPrincipal();
            int nbDepndants = 0;

            //Transaction
            if (!booAbonnementPrincipalValide)
            {
                MessageBox.Show("Veuillez d'abord ajouter l'abonné principal");
            }
            else
            {
                using (var porteTransaction = new TransactionScope())
                {
                    monDataContext.Abonnements.InsertOnSubmit(nouvelAbonnement);

                    try
                    {
                        //monDataContext.SubmitChanges();
                        MessageBox.Show($"L'abonné {nouvelAbonnement.Id} a été enregistré. ", "Ajout d'un abonnement");

                        int intTypeAbonnement = (int)cbTypeAbonnement.SelectedValue;
                        switch (intTypeAbonnement)
                        {
                            case 3:
                                nbDepndants = 1; break;
                            case 4:
                                nbDepndants = 2; break;
                            case 5:
                                nbDepndants = 3; break;
                            case 6:
                                //nbDepndants = 3; break;
                                break;
                        }

                        for (int i = 1; i <= nbDepndants; i++)
                        {
                            char strLienFamille = (i == 1) ? 'C' : 'E';
                            Dependants nouvelDependant = new Dependants {};

                            int noEmpMax = (from unDependant in monDataContext.Dependants
                                            where unDependant.IdAbonnement == nouvelAbonnement.Id
                                            select unDependant).Count();

                            nouvelDependant.IdAbonnement = nouvelAbonnement.Id ;
                            frmAjout.nouvelDependant = nouvelDependant;
                            frmAjout.strLienFamille = strLienFamille;
                            frmAjout.ShowDialog();

                            if (nouvelDependant.Nom != null)
                            {
                                nouvelDependant.Id = $"{nouvelDependant.Nom}{i}P";
                                monDataContext.Dependants.InsertOnSubmit(nouvelDependant);
                                //insère le contrat dans la base de données

                                try
                                {
                                    monDataContext.SubmitChanges();
                                    MessageBox.Show($"Le dépendant {nouvelDependant.Id} a été enregistré. ", "Ajout d'un dépendant");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                                }

                            }

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                    }
                    
                    porteTransaction.Complete();
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
            booValide = !verificationErreur(strPrenom.Length < 2 || strPrenom.Length > 15, tbPrenom, "Le prénom doit avoir entre 8 à 15 caractères.") && booValide;
            booValide = !verificationErreur(strPrenom == "", tbPrenom, "Veuillez saisir un prénom.") && booValide;
            //Sexe
            booValide = !verificationErreur(cbSexe.Text.Trim() == "", cbSexe, "Veuillez saisir un sexe.") && booValide;
            //Âge - à tester
            booValide = !verificationErreur(intAge < 18 || intAge > 110, dtpNaissance, "Veuillez saisir un âge entre 18 et 110 ans.") && booValide;
            booValide = !verificationErreur((int)cbTypeAbonnement.SelectedValue == 2 && intAge < 60, dtpNaissance, "L’âge minimum de l’abonné principal est de 60 ans pour les personnes de l’âge d’or.") && booValide;

            //Téléphone
            booValide = !verificationErreur(mtbTelephone.Text.Trim() == "", mtbTelephone, "Veuillez saisir un numéro de téléphone.") && booValide;
            booValide = !verificationErreur(mtbTelephone.Text.Length != 10, mtbTelephone, "Le numéro de téléphone doit contenir 10 caractères.") && booValide;

            //Cellulaire
            booValide = !verificationErreur(mtbCellulaire.Text.Trim() != "" && mtbCellulaire.Text.Length != 10, mtbCellulaire, "Le numéro de cellulaire doit contenir 10 caractères.") && booValide;

            //Courriel
            booValide = !verificationErreur(strCourriel == "", tbCourriel, "Veuillez saisir un courriel.") && booValide;

            //Date d'abonnement - pas besoin

            //No civique
            booValide = !verificationErreur(tbNoCivique.Text.Trim() == "", tbNoCivique, "Veuillez saisir un code civil.") && booValide;
            booValide = !verificationErreur(!exprCodeCivil.IsMatch(tbNoCivique.Text.Trim()), tbNoCivique, "Le numéro peut contenir entre 1 à 6 chiffres.") && booValide;

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
            booValide = !verificationErreur(mtbCodePostal.Text.Trim() == "", mtbCodePostal, "Veuillez choisir un code postal.") && booValide;
            booValide = !verificationErreur(mtbCodePostal.Text.Length != 6, mtbCodePostal, "Le code postal doit avoir 6 caractères.") && booValide;


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

        private void ajouterDependants()
        {

        }

    }
}
