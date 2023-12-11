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
    public partial class frmConnnexion : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmMenu1 frmMenu1 = new frmMenu1();
        private readonly string strNomBase = "Entrez votre numéro d'employé";
        private readonly string strMDPBase = "Entrez votre mot de passe";


        public frmConnnexion()
        {
            InitializeComponent();
        }

        private void frmConnnexion_Load(object sender, EventArgs e)
        {
            tbNom.Text = strNomBase;
            tbMDP.Text = strMDPBase;
            tbNom.ForeColor = Color.LightGray;
            tbMDP.UseSystemPasswordChar = false;
            tbMDP.ForeColor = Color.LightGray;
        }


        private void tbNom_Enter(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == strNomBase)
            {
                tbNom.Text = "";
                tbNom.ForeColor = Color.Black;
            }
        }

        private void tbMDP_Enter(object sender, EventArgs e)
        {
            if (tbMDP.Text.Trim() == strMDPBase)
            {
                tbMDP.Text = "";
                tbMDP.UseSystemPasswordChar = true;
                tbMDP.ForeColor = Color.Black;
            }
        }

        private void tbNom_Leave(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == string.Empty)
            {
                tbNom.Text = strNomBase;
                tbNom.ForeColor = Color.LightGray;
            }
        }

        private void tbMDP_Leave(object sender, EventArgs e)
        {
            if (tbMDP.Text.Trim() == string.Empty)
            {
                tbMDP.Text = strMDPBase;
                tbMDP.UseSystemPasswordChar = false;
                tbMDP.ForeColor = Color.LightGray;
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            int noEmpoye = Int32.TryParse(tbNom.Text, out noEmpoye) ? noEmpoye : 0;
            string mdpEmpoye = tbMDP.Text;
            var employeConnexion = from unUtilisateur in monDataContext.Employes
                                  where unUtilisateur.No == noEmpoye && unUtilisateur.MotDePasse == mdpEmpoye
                                  select unUtilisateur;

            int intConnexion = employeConnexion.Count();
            //var list = employeConnexion.ToList();

            if (intConnexion == 1)
            {
                lblMessageErreur.Text = "Connexion réussie.";
                lblMessageErreur.ForeColor = Color.DarkGreen;

                //int intTypeEmploye = list[0].NoTypeEmploye;
                
                int intTypeEmploye = employeConnexion.First().NoTypeEmploye;

                frmMenu1.intTypeEmploye = (intTypeEmploye == 1 || intTypeEmploye == 2 || intTypeEmploye == 3) ? 0 : 1;
                frmMenu1.prenomEmploye = employeConnexion.First().Prenom;
                frmMenu1.intNoEmploye = employeConnexion.First().No;

                frmMenu1.ShowDialog();
            }
            else
            {
                lblMessageErreur.ForeColor = Color.DarkRed;

                if (tbNom.ForeColor == Color.LightGray && tbMDP.ForeColor == Color.LightGray)
                    lblMessageErreur.Text = "Veuillez entrez vos informations.";
                else if (tbMDP.ForeColor == Color.LightGray)
                    lblMessageErreur.Text = "Veuillez entrer votre mot de passe.";
                else if (tbNom.ForeColor == Color.LightGray)
                    lblMessageErreur.Text = "Veuillez entrer votre nom d'utilisateur.";
                else
                    lblMessageErreur.Text = "Nom et/ou mot de passe incorrect(s).";
            }
            Console.WriteLine(employeConnexion.ToString());
            Console.Read();
        }

    }
}
