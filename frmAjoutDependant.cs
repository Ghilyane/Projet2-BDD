using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{

    public partial class frmAjoutDependant : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public Dependants nouvelDependant = new Dependants();
        public char strLienFamille;
        public bool booAnnuler = false;

        public frmAjoutDependant()
        {
            InitializeComponent();

        }

        private void frmAjoutDependant_Load(object sender, EventArgs e)
        {
            cbSexe.Items.Add("Femme");
            cbSexe.Items.Add("Homme");
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
            var exprCourriel = new Regex(@"^$");

            //var addr = new System.Net.Mail.MailAddress(tbCourriel.Text);

            errMessage.Clear();
            string strNom = tbNom.Text.Trim();
            string strPrenom = tbPrenom.Text.Trim();


            var dtAuj = DateTime.Today;
            var dtNaissance = dtpNaissance.Value;

            int intAge = dtAuj.Year - dtNaissance.Year;

            if (dtNaissance.Date > dtAuj.AddYears(-intAge)) intAge--;

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
            if (strLienFamille == 'C')
                booValide = !verificationErreur(intAge < 18 || intAge > 110, dtpNaissance, "Veuillez saisir un âge entre 18 et 110 ans.") && booValide;
            else 
                booValide = !verificationErreur(intAge < 0 || intAge > 18, dtpNaissance, "Veuillez saisir un âge entre 0 et 17 ans.") && booValide;
            //Remarque
            booValide = !verificationErreur(tbRemarque.Text.Trim().Length > 40, tbRemarque, "La remarque ne doit pas avoir avoir plus de 40 caractères.") && booValide;



            MessageBox.Show(booValide.ToString());

            if (booValide)
            {
                nouvelDependant.Nom = strNom;
                nouvelDependant.Prenom = strPrenom;
                nouvelDependant.DateNaissance = dtpNaissance.Value;
                nouvelDependant.Sexe = (cbSexe.Text == "Femme") ? "F" : "H";
                nouvelDependant.Remarque = tbRemarque.Text.Trim();

                this.Close();
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Êtes-vous sûr.e de vouloir annuler cet abonnement?", "Confirmation de l'annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                booAnnuler = true;
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
