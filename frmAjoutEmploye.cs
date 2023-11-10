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
            var requeteAdmin = from untType in monDataContext.TypesEmploye
                                   where untType.No == 1
                                   select untType;

            int intNbAdmin = requeteAdmin.Count();

            var exprMDP = new Regex(@"^([\da-zA-Z]|[^a-zA-Z0-9\s]){8, 15}$");
            var exprNomPrenom = new Regex("^(([A-Z]|[a-z]|[À-Ü]|[à-ü])+([ '-]?([A-Z]|[a-z]|[À-Ü]|[à-ü])+)*)$");

            //var addr = new System.Net.Mail.MailAddress(tbCourriel.Text);

            string strMDP = tbMDP.Text.Trim();
            string strNom = tbNom.Text.Trim();
            string strPrenom = tbPrenom.Text.Trim();
            string strCourriel = tbCourriel.Text.Trim();
            string strRue = tbRue.Text.Trim();
            string strVille = tbVille.Text.Trim();
            string strCodePostal = mtbCodePostal.Text.Trim();

            if (cbTypeEmploye.Text.Trim() == "")
                errMessage.SetError(cbTypeEmploye, "Veuillez choisir un type d'employé.");
            else if (cbTypeEmploye.SelectedValue.ToString() == "1" && intNbAdmin != 0)
                errMessage.SetError(cbTypeEmploye, "Il y a déjà un admin.");
            else
            {
                errMessage.SetError(cbTypeEmploye, "");
                if (strMDP == "")
                    errMessage.SetError(tbMDP, "Veuillez saisir un mot de passe.");
                else if (!exprMDP.IsMatch(strMDP))
                    errMessage.SetError(tbMDP, "Votre mot de passe doit contenir au moins une lettre, un chiffre et un caractère non alphanumérique.");
                else if (strMDP.Length < 8 || strMDP.Length > 15)
                    errMessage.SetError(tbMDP, "Votre mot de passe doit avoir entre 8 à 15 caractères");
                else
                {
                    errMessage.SetError(tbMDP, "");
                    if (tbMDPConfirme.Text != tbMDPConfirme.Text)
                        errMessage.SetError(tbMDPConfirme, "Les deux mots de passe doivent être pareils");
                    else
                    {
                        errMessage.SetError(tbMDPConfirme, "");

                        if (strNom == "")
                            errMessage.SetError(tbNom, "Veuillez saisir nom.");
                        else if (strNom.Length < 2 || strNom.Length > 15)
                            errMessage.SetError(tbNom, "Votre nom doit avoir entre 8 à 15 caractères");
                        else if (!exprNomPrenom.IsMatch(strNom))
                            errMessage.SetError(tbNom, "Votre nom peut seulement avoir des lettres, des tirets, des espaces et appostrophes.");
                        else
                        {
                            errMessage.SetError(tbNom, "");

                            if (strPrenom == "")
                                errMessage.SetError(tbPrenom, "Veuillez saisir prénom.");
                            else if (strPrenom.Length < 2 || strPrenom.Length > 15)
                                errMessage.SetError(tbNom, "Votre prénom doit avoir entre 8 à 15 caractères");
                            else if (!exprNomPrenom.IsMatch(strPrenom))
                                errMessage.SetError(tbNom, "Votre prénom peut seulement avoir des lettres, des tirets, des espaces et appostrophes.");
                            else {
                                errMessage.SetError(tbPrenom, "");

                                if (cbSexe.Text == "")
                                    errMessage.SetError(tbPrenom, "Veuillez saisir votre sexe.");
                                else
                                {
                                    errMessage.SetError(cbSexe, "");

                                    if (mtbTelephone.Text == "")
                                        errMessage.SetError(mtbTelephone, "Veuillez saisir votre numéro de téléphone");
                                    else if (mtbTelephone.TextLength != 10)
                                        errMessage.SetError(mtbTelephone, "Votre numéro de téléphone doit contenir 10 caractères");
                                    else
                                    {
                                        errMessage.SetError(mtbTelephone, "");
                                    }

                                }

                            }
                        }
                    }
                }
            }

        }

        private bool longueurMot(int min, int max, string nom)
        {
            return false;
        }
    }
}
