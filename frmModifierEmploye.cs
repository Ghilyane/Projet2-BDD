using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class frmModifierEmploye : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public Employes modifEmploye = new Employes();

        public frmModifierEmploye()
        {
            InitializeComponent();
        }

        private void frmModifierEmploye_Load(object sender, EventArgs e)
        {
            typesEmployeBindingSource.DataSource = from unType in monDataContext.TypesEmploye
                                                   select unType;
            provincesBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                                select uneProvince;
            cbSexe.Items.Add("Femme");
            cbSexe.Items.Add("Homme");


            tbNo.Text = modifEmploye.No.ToString();
            cbTypeEmploye.Text = modifEmploye.NoTypeEmploye.ToString();
            tbMDP.Text = modifEmploye.MotDePasse;
            nudSalaire.Value = modifEmploye.SalaireHoraire;
            tbNom.Text = modifEmploye.Nom;
            tbPrenom.Text = modifEmploye.Prenom;
            nudAge.Value = modifEmploye.Age;
            cbSexe.Text = (modifEmploye.Sexe == "F") ? "Femme" : "Homme";
            mtbTelephone.Text = modifEmploye.Telephone;
            mtbCellulaire.Text = modifEmploye.Cellulaire;
            tbCourriel.Text = modifEmploye.Courriel;
            tbNoCivique.Text = modifEmploye.NoCivique.ToString();
            tbRue.Text = modifEmploye.Rue;
            tbVille.Text = modifEmploye.Ville;
            cbProvince.Text = modifEmploye.IdProvince;
            mtbCodePostal.Text = modifEmploye.CodePostal;
            tbRemarque.Text = modifEmploye.Remarque;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bool booValide = true;

            var exprMDP = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]+$");
            var exprNomPrenom = new Regex(@"^(([A-Z]|[a-z]|[À-Ü]|[à-ü])+([ '-]?([A-Z]|[a-z]|[À-Ü]|[à-ü])+)*)$");
            var exprCodeCivil = new Regex(@"^\d{1,6}$");

            //var addr = new System.Net.Mail.MailAddress(tbCourriel.Text);

            errMessage.Clear();
            string strMDP = tbMDP.Text.Trim();
            string strNom = tbNom.Text.Trim();
            string strPrenom = tbPrenom.Text.Trim();
            string strCourriel = tbCourriel.Text.Trim();
            string strRue = tbRue.Text.Trim();
            string strVille = tbVille.Text.Trim();

            //Mot de passe
            booValide = !verificationErreur(!exprMDP.IsMatch(strMDP), tbMDP, "Le mot de passe doit contenir au moins une lettre, un chiffre et un des caractères suivants : !%*#?&.") && booValide;
            booValide = !verificationErreur(strMDP.Length < 8 || strMDP.Length > 15, tbMDP, "Le mot de passe doit avoir entre 8 à 15 caractères.") && booValide;
            booValide = !verificationErreur(strMDP == "", tbMDP, "Veuillez saisir un mot de passe.") && booValide;


            //Âge - à tester
            booValide = !verificationErreur(nudAge.Value < 16 || nudAge.Value > 65, nudAge, "Veuillez saisir un âge entre 16 et 65 ans.") && booValide;

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

            //Téléphone
            booValide = !verificationErreur(mtbTelephone.Text.Trim() == "", mtbTelephone, "Veuillez saisir un numéro de téléphone.") && booValide;
            booValide = !verificationErreur(mtbTelephone.Text.Length != 10, mtbTelephone, "Le numéro de téléphone doit contenir 10 caractères.") && booValide;

            //Cellulaire
            booValide = !verificationErreur(mtbCellulaire.Text.Trim() != "" && mtbCellulaire.Text.Length != 10, mtbCellulaire, "Le numéro de cellulaire doit contenir 10 caractères.") && booValide;

            //Courriel
            booValide = !verificationErreur(strCourriel == "", tbCourriel, "Veuillez saisir un courriel.") && booValide;
            //regex

            //No civique
            booValide = !verificationErreur(tbNoCivique.Text.Trim() == "", tbNoCivique, "Veuillez saisir un code civil.") && booValide;
            booValide = !verificationErreur(!exprCodeCivil.IsMatch(tbNoCivique.Text), tbNoCivique, "Le code peut contenir entre 1 à 6 chiffres.") && booValide;

            //Rue
            booValide = !verificationErreur(!exprNomPrenom.IsMatch(strRue), tbRue, "La rue peut seulement avoir des lettres, des tirets, des espaces et apostrophes.") && booValide;
            booValide = !verificationErreur(strRue.Length < 3 || strRue.Length > 15, tbRue, "La rue doit avoir entre 3 à 15 caractères") && booValide;
            booValide = !verificationErreur(strRue == "", tbRue, "Veuillez saisir une rue.") && booValide;

            //Ville
            booValide = !verificationErreur(!exprNomPrenom.IsMatch(strVille), tbVille, "La ville peut seulement avoir des lettres, des tirets, des espaces et apostrophes.") && booValide;
            booValide = !verificationErreur(strVille.Length < 4 || strVille.Length > 20, tbVille, "La ville doit avoir entre 4 à 20 caractères") && booValide;
            booValide = !verificationErreur(strVille == "", tbVille, "Veuillez saisir une ville.") && booValide;

            //Province
            booValide = !verificationErreur(cbProvince.Text.Trim() == "", cbProvince, "Veuillez choisir une province.") && booValide;

            //Code postal
            booValide = !verificationErreur(mtbCodePostal.Text.Trim() == "", mtbCodePostal, "Veuillez choisir un code postal.") && booValide;
            booValide = !verificationErreur(mtbCodePostal.Text.Length != 6, mtbCodePostal, "Le code postal doit avoir 6 caractères.") && booValide;

            //Remarque
            booValide = !verificationErreur(tbRemarque.Text.Trim().Length > 40, mtbCodePostal, "La remarque ne doit pas avoir avoir plus de 40 caractères.") && booValide;



            if (booValide)
            {
                modifEmploye.MotDePasse = strMDP;
                modifEmploye.Nom = strNom;
                modifEmploye.Prenom = strPrenom;
                modifEmploye.Age = (int)nudAge.Value;
                modifEmploye.SalaireHoraire = nudSalaire.Value;
                modifEmploye.Sexe = (cbSexe.Text == "Femme") ? "F" : "H";
                modifEmploye.Telephone = mtbTelephone.Text.Trim();
                modifEmploye.Cellulaire = mtbCellulaire.Text.Trim();
                modifEmploye.Courriel = tbCourriel.Text.Trim();
                modifEmploye.Remarque = tbRemarque.Text.Trim();
                modifEmploye.Rue = tbRue.Text.Trim();
                modifEmploye.IdProvince = (string)cbProvince.SelectedValue;
                modifEmploye.Ville = strVille;
                modifEmploye.CodePostal = mtbCodePostal.Text.Trim().ToUpper();

                this.Close();
            }
        }

        private bool verificationErreur(bool booCondition, Control control, string strMessage)
        {
            if (booCondition)
                errMessage.SetError(control, strMessage);

            return booCondition;
        }
    }
}
