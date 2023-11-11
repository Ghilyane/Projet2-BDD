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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetFinal
{
    public partial class frmAjoutEmploye : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public Employes nouvelEmploye = new Employes();

        public frmAjoutEmploye()
        {
            InitializeComponent();
        }

        private void frmAjoutEmploye_Load(object sender, EventArgs e)
        {
            typesEmployeBindingSource.DataSource = from unType in monDataContext.TypesEmploye
                                                   select unType;
            provincesBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                                select uneProvince;
            tbNo.Text = nouvelEmploye.No.ToString();
            cbSexe.Items.Add("Femme");
            cbSexe.Items.Add("Homme");
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool booValide = true;
            var requeteAdmin = from untType in monDataContext.TypesEmploye
                                   where untType.No == 1
                                   select untType;

            int intNbAdmin = requeteAdmin.Count();

            var exprMDP = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]+$");
            var exprNomPrenom = new Regex(@"^(([A-Z]|[a-z]|[À-Ü]|[à-ü])+([ '-]?([A-Z]|[a-z]|[À-Ü]|[à-ü])+)*)$");
            var exprCodeCivil = new Regex(@"^\d{1,6}$");
            var exprCourriel = new Regex(@"^$");

            //var addr = new System.Net.Mail.MailAddress(tbCourriel.Text);
            
            errMessage.Clear();
            string strMDP = tbMDP.Text.Trim();
            string strNom = tbNom.Text.Trim();
            string strPrenom = tbPrenom.Text.Trim();
            string strCourriel = tbCourriel.Text.Trim();
            string strRue = tbRue.Text.Trim();
            string strVille = tbVille.Text.Trim();

            //Type employé
            booValide = !verificationErreur(cbTypeEmploye.SelectedValue.ToString() == "1", cbTypeEmploye, "Il y a déjà un admin.") && booValide; //au début : true = true & (true ou false)
            booValide = !verificationErreur(cbTypeEmploye.Text.Trim() == "", cbTypeEmploye, "Veuillez choisir un type d'employé.") && booValide;

            //Mot de passe
            booValide = !verificationErreur(!exprMDP.IsMatch(strMDP), tbMDP, "Le mot de passe doit contenir au moins une lettre, un chiffre et un des caractères suivants : !%*#?&.") && booValide;
            booValide = !verificationErreur(strMDP.Length < 8 || strMDP.Length > 15, tbMDP, "Le mot de passe doit avoir entre 8 à 15 caractères.") && booValide;
            booValide = !verificationErreur(strMDP == "", tbMDP, "Veuillez saisir un mot de passe.") && booValide;

            //Mot de passe confirmé
            booValide = !verificationErreur(strMDP != tbMDPConfirme.Text, tbMDPConfirme, "Veuillez saisir un mot de passe.") && booValide;

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
            // non nécessaire ?


            if (booValide)
            {
                nouvelEmploye.NoTypeEmploye = (int)cbTypeEmploye.SelectedValue;
                nouvelEmploye.MotDePasse = strMDP;
                nouvelEmploye.Nom = strNom;
                nouvelEmploye.Prenom = strPrenom;
                nouvelEmploye.Age = (int)nudAge.Value;
                nouvelEmploye.SalaireHoraire = nudSalaire.Value;
                nouvelEmploye.Sexe = (cbSexe.Text == "Femme") ? "F" : "H";
                nouvelEmploye.Telephone = mtbTelephone.Text.Trim();
                nouvelEmploye.Cellulaire = mtbCellulaire.Text.Trim();
                nouvelEmploye.Courriel = tbCourriel.Text.Trim();
                nouvelEmploye.Remarque = tbRemarque.Text.Trim();
                nouvelEmploye.Rue = tbRue.Text.Trim();
                nouvelEmploye.IdProvince = (string)cbProvince.SelectedValue;
                nouvelEmploye.Ville = strVille;
                nouvelEmploye.CodePostal =  mtbCodePostal.Text.Trim().ToUpper();

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
