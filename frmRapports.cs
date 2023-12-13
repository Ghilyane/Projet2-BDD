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
    public partial class frmRapports : Form
    {
        string strNomRapport;
        string strTypeRapport;
        Boolean locker = false;
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmRapports()
        {
            InitializeComponent();
        }

        private void dépensesParAbonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strNomRapport = "depense";
            strTypeRapport = "abonne";
            verification(strNomRapport, strTypeRapport);
            depensesBindingSource.Position = 0;
            depensesBindingSource.ResetBindings(false);
            locker = false;
            toolStripLblTotal.Text = String.Format("de {0}", 0);
            tbIndex.Text = "";
            txtNomAbonne.Text = "";
            txtNomEmploye.Text = "";
            txtTypeService.Text = "";
            txtIdAbonne.Text = "";
            txtNoEmp.Text = "";
            nudMontant.Value = 0;
        }

        private void dépensesParAnnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strNomRapport = "depense";
            strTypeRapport = "annee";
            verification(strNomRapport, strTypeRapport);
            depensesBindingSource.Position = 0;
            depensesBindingSource.ResetBindings(false);
            locker = false;
            toolStripLblTotal.Text = String.Format("de {0}", 0);
            tbIndex.Text = "";
            txtNomAbonne.Text = "";
            txtNomEmploye.Text = "";
            txtTypeService.Text = "";
            txtIdAbonne.Text = "";
            txtNoEmp.Text = "";
            nudMontant.Value = 0;
        }

        private void dépensesParEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strNomRapport = "depense";
            strTypeRapport = "employe";
            verification(strNomRapport, strTypeRapport);
            depensesBindingSource.Position = 0;
            depensesBindingSource.ResetBindings(false);
            locker = false;
            toolStripLblTotal.Text = String.Format("de {0}", 0);
            tbIndex.Text = "";
            txtNomAbonne.Text = "";
            txtNomEmploye.Text = "";
            txtTypeService.Text = "";
            txtIdAbonne.Text = "";
            txtNoEmp.Text = "";
            nudMontant.Value = 0;
        }
        private void partiesJouéesParTerrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strNomRapport = "partie";
            strTypeRapport = "terrain";
            verification(strNomRapport, strTypeRapport);
            partiesJoueesBindingSource.ResetBindings(false);
            locker = false;
            toolStripLblTotal.Text = String.Format("de {0}", 0);
            tbIndex.Text = "";
            txtNomAbonne.Text = "";
            txtTerrain.Text = "";
            nudPointage.Value = 0;
        }

        private void partiesJouéesParAbonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strNomRapport = "partie";
            strTypeRapport = "abonne";
            verification(strNomRapport, strTypeRapport);
            partiesJoueesBindingSource.ResetBindings(false);
            locker = false;
            toolStripLblTotal.Text = String.Format("de {0}", 0);
            tbIndex.Text = "";
            txtNomAbonne.Text = "";
            txtTerrain.Text = "";
            nudPointage.Value = 0;
        }

        private void partiesJouéesParAnnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strNomRapport = "partie";
            strTypeRapport = "annee";
            verification(strNomRapport, strTypeRapport);
            partiesJoueesBindingSource.ResetBindings(false);
            locker = false;
            toolStripLblTotal.Text = String.Format("de {0}", 0);
            tbIndex.Text = "";
            txtNomAbonne.Text = "";
            txtTerrain.Text = "";
            nudPointage.Value = 0;
        }
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (strNomRapport == "depense")
            {
                if (strTypeRapport == "employe")
                {
                    var afficheDepenseEmploye = from employe in dataContext.Employes
                                                from service in dataContext.Services
                                                from depense in dataContext.Depenses
                                                where txtRecherche.Text.ToLower().Trim() == employe.Nom.ToLower() + " " + employe.Prenom.ToLower()
                                                && employe.No == service.NoEmploye && service.No == depense.NoService
                                                select depense;

                    if (afficheDepenseEmploye.Count() > 0)
                    {
                        MessageBox.Show(afficheDepenseEmploye.Count().ToString() + " dépense(s) ont été trouvé!");
                        locker = true;
                        depensesBindingSource.DataSource = afficheDepenseEmploye;
                        toolStripLblTotal.Text = String.Format("de {0}", depensesBindingSource.Count);
                        tbIndex.Text = (depensesBindingSource.Position + 1).ToString(); ;
                        txtRecherche.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("0 dépense(s) ont été trouvé, veuillez entrez un nouveau nom!");
                        txtRecherche.Text = "";
                        locker = false;
                        toolStripLblTotal.Text = String.Format("de {0}", 0);
                        txtNomAbonne.Text = "";
                        txtNomEmploye.Text = "";
                        tbIndex.Text = "";
                        txtTypeService.Text = "";
                        nudMontant.Value = 0;

                    }
                }
                else if (strTypeRapport == "abonne")
                {
                    var afficheDepenseAbonne = from abonne in dataContext.Abonnements
                                               from depense in dataContext.Depenses
                                               where txtRecherche.Text.ToLower().Trim() == abonne.Nom.ToLower() + " " + abonne.Prenom.ToLower()
                                               && abonne.Id == depense.IdAbonnement
                                               select depense;

                    if (afficheDepenseAbonne.Count() > 0)
                    {
                        MessageBox.Show(afficheDepenseAbonne.Count().ToString() + " dépense(s) ont été trouvé!");
                        locker = true;
                        depensesBindingSource.DataSource = afficheDepenseAbonne;
                        toolStripLblTotal.Text = String.Format("de {0}", depensesBindingSource.Count);
                        tbIndex.Text = (depensesBindingSource.Position + 1).ToString(); ;
                        txtRecherche.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("0 dépense(s) ont été trouvé, veuillez entrez un nouveau nom!");
                        txtRecherche.Text = "";
                        locker = false;
                        toolStripLblTotal.Text = String.Format("de {0}", 0);
                        txtNomAbonne.Text = "";
                        txtNomEmploye.Text = "";
                        tbIndex.Text = "";
                        txtTypeService.Text = "";
                        nudMontant.Value = 0;
                    }
                }
                else
                {
                    var afficheDepenseAnne = from depense in dataContext.Depenses
                                             where depense.DateDepense.Year == int.Parse(txtRecherche.Text.Trim())
                                             select depense;


                    if (afficheDepenseAnne.Count() > 0)
                    {
                        MessageBox.Show(afficheDepenseAnne.Count().ToString() + " dépense(s) ont été trouvé!");
                        locker = true;
                        depensesBindingSource.DataSource = afficheDepenseAnne;
                        toolStripLblTotal.Text = String.Format("de {0}", depensesBindingSource.Count);
                        tbIndex.Text = (depensesBindingSource.Position + 1).ToString(); ;
                        txtRecherche.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("0 dépense(s) ont été trouvé, veuillez entrez un nouveau nom!");
                        txtRecherche.Text = "";
                        locker = false;
                        toolStripLblTotal.Text = String.Format("de {0}", 0);
                        txtNomAbonne.Text = "";
                        txtNomEmploye.Text = "";
                        tbIndex.Text = "";
                        txtTypeService.Text = "";
                        nudMontant.Value = 0;
                    }
                }
            }
            else
            {
                if (strTypeRapport == "terrain")
                {
                    var affichePartieParTerrain = from partie in dataContext.PartiesJouees
                                                  where partie.Terrains.Nom == txtRecherche.Text.ToLower().Trim()
                                                  && partie.IdAbonnement == partie.Abonnements.Id
                                                  select partie;
                    if (affichePartieParTerrain.Count() > 0)
                    {
                        MessageBox.Show(affichePartieParTerrain.Count().ToString() + " partie(s) ont été trouvé!");
                        locker = true;
                        partiesJoueesBindingSource.DataSource = affichePartieParTerrain;
                        toolStripLblTotal.Text = String.Format("de {0}", partiesJoueesBindingSource.Count);
                        tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString(); ;
                        txtRecherche.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("0 partie(s) ont été trouvé, veuillez entrez un nouveau nom!");
                        txtRecherche.Text = "";
                        locker = false;
                        toolStripLblTotal.Text = String.Format("de {0}", 0);
                        txtNomAbonne.Text = "";
                        txtTerrain.Text = "";
                        tbIndex.Text = "";
                        nudPointage.Value = 0;
                    }
                }
                else if (strTypeRapport == "abonne")
                {
                    var affichePartieParAbonne = from partie in dataContext.PartiesJouees
                                                  where partie.Abonnements.Nom + " " + partie.Abonnements.Prenom == txtRecherche.Text.ToLower().Trim()
                                                  select partie;
                    if (affichePartieParAbonne.Count() > 0)
                    {
                        MessageBox.Show(affichePartieParAbonne.Count().ToString() + " partie(s) ont été trouvé!");
                        locker = true;
                        partiesJoueesBindingSource.DataSource = affichePartieParAbonne;
                        toolStripLblTotal.Text = String.Format("de {0}", partiesJoueesBindingSource.Count);
                        tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString(); ;
                        txtRecherche.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("0 partie(s) ont été trouvé, veuillez entrez un nouveau nom!");
                        txtRecherche.Text = "";
                        locker = false;
                        toolStripLblTotal.Text = String.Format("de {0}", 0);
                        txtNomAbonne.Text = "";
                        txtTerrain.Text = "";
                        tbIndex.Text = "";
                        nudPointage.Value = 0;
                    }
                }
                else
                {
                    var affichePartieParAnnee = from partie in dataContext.PartiesJouees
                                                  where partie.DatePartie.Year == int.Parse(txtRecherche.Text.Trim())
                                                  select partie;
                    if (affichePartieParAnnee.Count() > 0)
                    {
                        MessageBox.Show(affichePartieParAnnee.Count().ToString() + " partie(s) ont été trouvé!");
                        locker = true;
                        partiesJoueesBindingSource.DataSource = affichePartieParAnnee;
                        toolStripLblTotal.Text = String.Format("de {0}", partiesJoueesBindingSource.Count);
                        tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString(); ;
                        txtRecherche.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("0 partie(s) ont été trouvé, veuillez entrez un nouveau nom!");
                        txtRecherche.Text = "";
                        locker = false;
                        toolStripLblTotal.Text = String.Format("de {0}", 0);
                        txtNomAbonne.Text = "";
                        txtTerrain.Text = "";
                        tbIndex.Text = "";
                        nudPointage.Value = 0;
                    }
                }

            }
        }

        private Boolean verification(string nomRapport, string typeRapport)
        {
            if(nomRapport.ToLower() == "depense")
            {
                lblAffiche.Visible = true;
                lblAffiche.Text = "Rapport des dépenses ";
                lblRecherche.Visible = true;
                lblDateDepense.Visible = true;
                lblMontant.Visible = true;
                lblTypeService.Visible = true;
                txtRecherche.Visible = true;
                txtTypeService.Visible = true;
                dateDepenseDateTimePicker.Visible = true;
                nudMontant.Visible = true;
                btnRechercher.Visible = true;
                toolStrip1.Visible = true;
                lblTerrain.Visible = false;
                txtTerrain.Visible = false;
                lblPointage.Visible = false;
                nudPointage.Visible = false;
                lblDatePartie.Visible = false;
                datePartieDateTimePicker.Visible = false;

                if (typeRapport.ToLower() == "employe")
                {
                    lblAffiche.Text += "par employé";
                    lblRecherche.Text = "Entrez le nom de l'employé";
                    lblNomEmploye.Visible = false;
                    lblNomAbonne.Visible = true;
                    txtNomAbonne.Visible = true;
                    txtNomEmploye.Visible = false;
                }
                else if (typeRapport.ToLower() == "abonne")
                {
                    lblAffiche.Text += "par abonnement";
                    lblRecherche.Text = "Entrez le nom de l'abonné";
                    lblNomEmploye.Visible = true;
                    lblNomAbonne.Visible = false;
                    txtNomAbonne.Visible = false;
                    txtNomEmploye.Visible = true;
                }
                else if (typeRapport.ToLower() == "annee")
                {
                    lblAffiche.Text += "par année";
                    lblRecherche.Text = "Entrez l'année du service";
                    lblNomEmploye.Visible = true;
                    lblNomAbonne.Visible = true;
                    txtNomAbonne.Visible = true;
                    txtNomEmploye.Visible = true;
                }
            }
            else
            {
                lblAffiche.Visible = true;
                lblAffiche.Text = "Rapport des parties jouées ";
                lblRecherche.Visible = true;
                lblDateDepense.Visible = false;
                lblMontant.Visible = false;
                lblTypeService.Visible = false;
                txtRecherche.Visible = true;
                txtTypeService.Visible = false;
                dateDepenseDateTimePicker.Visible = false;
                nudMontant.Visible = false;
                btnRechercher.Visible = true;
                toolStrip1.Visible = true;
                lblPointage.Visible = true;
                nudPointage.Visible = true;
                lblDatePartie.Visible = true;
                datePartieDateTimePicker.Visible = true;
                lblNomEmploye.Visible = false;
                txtNomEmploye.Visible = false;

                if (typeRapport == "terrain")
                {
                    lblAffiche.Text += "par terrain";
                    lblRecherche.Text = "Entrez le nom du terrain";
                    lblTerrain.Visible = false;
                    txtTerrain.Visible = false;
                    lblNomAbonne.Visible = true;
                    txtNomAbonne.Visible = true;
                }
                else if (typeRapport.ToLower() == "abonne")
                {
                    lblAffiche.Text += "par abonnement";
                    lblRecherche.Text = "Entrez le nom de l'abonné";
                    lblTerrain.Visible = true;
                    txtTerrain.Visible = true;
                    lblNomAbonne.Visible = false;
                    txtNomAbonne.Visible = false;
                }
                else if (typeRapport.ToLower() == "annee")
                {
                    lblAffiche.Text += "par année";
                    lblRecherche.Text = "Entrez l'année de la partie";
                    lblTerrain.Visible = true;
                    txtTerrain.Visible = true;
                    lblNomAbonne.Visible = true;
                    txtNomAbonne.Visible = true;
                }
            }
            return true;
        }

        private void BtnPremier_Click(object sender, EventArgs e)
        {
            if(strNomRapport == "depense")
            {
                depensesBindingSource.MoveFirst();
                tbIndex.Text = (depensesBindingSource.Position + 1).ToString();
            }
            else
            {
                partiesJoueesBindingSource.MoveFirst();
                tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
            }
        }

        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            if (strNomRapport == "depense")
            {
                depensesBindingSource.MovePrevious();
                tbIndex.Text = (depensesBindingSource.Position + 1).ToString();
            }
            else
            {
                partiesJoueesBindingSource.MovePrevious();
                tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
            }
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            if (strNomRapport == "depense")
            {
                depensesBindingSource.MoveNext();
                tbIndex.Text = (depensesBindingSource.Position + 1).ToString();
            }
            else
            {
                partiesJoueesBindingSource.MoveNext();
                tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
            }
        }

        private void BtnDernier_Click(object sender, EventArgs e)
        {
            if (strNomRapport == "depense")
            {
                depensesBindingSource.MoveLast();
                tbIndex.Text = (depensesBindingSource.Position + 1).ToString();
            }
            else
            {
                partiesJoueesBindingSource.MoveLast();
                tbIndex.Text = (partiesJoueesBindingSource.Position + 1).ToString();
            }
        }

        private void frmRapports_Load(object sender, EventArgs e)
        {
            txtIdAbonne.Visible = false;
            txtNoEmp.Visible = false;
            txtIdAbonnementPartie.Visible = false;
            toolStrip1.Visible = false;
              
        }
        private void tbIndex_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show((strNomRapport == "partie" && (strTypeRapport == "annee" || strTypeRapport == "abonne") && locker).ToString());

            if (strNomRapport == "depense" && strTypeRapport == "employe" && locker)
            {
                var nomAbonne = (from abonne in dataContext.Abonnements
                                 where abonne.Id == txtIdAbonne.Text
                                 select new { nomComplet = abonne.Nom + " " + abonne.Prenom }).FirstOrDefault();
                txtNomAbonne.Text = nomAbonne.nomComplet;
            }
            else if (strNomRapport == "depense" && strTypeRapport == "annee" && locker)
            {
                var nomAbonne = (from abonne in dataContext.Abonnements
                                 where abonne.Id == txtIdAbonne.Text
                                 select new { nomComplet = abonne.Nom + " " + abonne.Prenom }).FirstOrDefault();

                var nomEmploye = (from employe in dataContext.Employes
                                  where employe.No == int.Parse(txtNoEmp.Text)
                                  select new { nomComplet = employe.Nom + " " + employe.Prenom }).FirstOrDefault();

                txtNomEmploye.Text = nomEmploye.nomComplet;
                txtNomAbonne.Text = nomAbonne.nomComplet;
            }
            else if (strNomRapport == "depense" && strTypeRapport == "abonne" && locker)
            {
                var nomEmploye = (from employe in dataContext.Employes
                                  where employe.No == int.Parse(txtNoEmp.Text)
                                  select new { nomComplet = employe.Nom + " " + employe.Prenom }).FirstOrDefault();
                txtNomEmploye.Text = nomEmploye.nomComplet;
            }
            else if (strNomRapport == "partie" && (strTypeRapport == "annee" || strTypeRapport == "terrain") && locker)
            {
                var affichePartieParAnnee = (from partie in dataContext.PartiesJouees
                                            where partie.IdAbonnement == txtIdAbonnementPartie.Text
                                            select new { nomComplet = partie.Abonnements.Nom + " " + partie.Abonnements.Prenom }).FirstOrDefault();

                txtNomAbonne.Text = affichePartieParAnnee.nomComplet;
            }
        }
    }
}
