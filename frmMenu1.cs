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
    public partial class frmMenu1 : Form
    {
        public int intTypeEmploye;
        public string prenomEmploye;

        public frmMenu1()
        {
            InitializeComponent();
        }

        private void frmMenu1_Load(object sender, EventArgs e)
        {
            lblSession.Text = $"Bienvenue {prenomEmploye} !";
        }


        public void ajouterForm(Form formulaire, Button btn)
        {
            foreach (Control c in this.splitContainer.Panel1.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).BackColor = Color.FromArgb(201, 205, 158);
                }
            }
            btn.BackColor = Color.FromArgb (161, 168, 88); ;

            if (this.splitContainer.Panel2.Controls.Count > 0)
            {
                for (int i = 0; i < this.splitContainer.Panel2.Controls.Count; i++)
                    this.splitContainer.Panel2.Controls.RemoveAt(i);
            }
            formulaire.TopLevel = false;
            formulaire.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(formulaire);
            this.splitContainer.Panel2.Tag = formulaire;
            formulaire.Show();
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmGestionEmployes(), this.btnEmployes);
        }

        private void btnAbonnements_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmAbonnements(), this.btnAbonnements);
        }

        private void btnReabonnements_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmReabonnements(), this.btnReabonnements);
        }

        private void btnMAJ_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmMAJAbonnes(), this.btnMAJ);
        }

        private void btnPrixDepenses_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmPrixEtDepenses(), this.btnPrixDepenses);
        }

        private void btnPartieGolf_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmPartieGolf(), this.btnPartieGolf);
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmDepenses(), this.btnDepenses);
        }

        private void btnRappors_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmRapports(), this.btnRapports);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ajouterForm(new frmStats(), this.btnStats);
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr.e de vouloir quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question);

            if (result == DialogResult.OK)
                Application.Exit();
        }

    }
}
