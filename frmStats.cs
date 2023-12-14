using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class frmStats : Form
    {
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        string typeStat = "";
        public frmStats()
        {
            InitializeComponent();
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            dgAbonnement.Visible = false;
            dgPartiesJouees.Visible = false;
            dgDepenses.Visible = false;
        }

        private void parTypeDabonnementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgAbonnement.Visible = true;
            dgPartiesJouees.Visible = false;
            dgDepenses.Visible = false;
            lblRecherche.Visible = true;
            lblRecherche.Text = "Entrez l'année recherchée";
            lblAffiche.Text = "Statistiques par abonnement";
            typeStat = "Abonnement par année";

            var typeAbonne =
                from typeAbonnement in dataContext.TypesAbonnement
                select new { identifiant = typeAbonnement.No, description = typeAbonnement.Description };


            /*Affichage de tous les abonnements principaux dans cbAbonnement*/
            cbDonnees.DataSource = typeAbonne.Select(a => new { Key = a.description, Value = a.identifiant }).ToList();
            cbDonnees.DisplayMember = "Key";
            cbDonnees.ValueMember = "Value";
        }

        private void parTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgAbonnement.Visible = true;
            dgPartiesJouees.Visible = false;
            dgDepenses.Visible = false;
            lblRecherche.Visible = true;
            lblRecherche.Text = "Entrez le mois en chiffre recherchée";
            lblAffiche.Text = "Statistiques par abonnement";
            typeStat = "Abonnement par mois";

            var typeAbonne =
                from typeAbonnement in dataContext.TypesAbonnement
                select new { identifiant = typeAbonnement.No, description = typeAbonnement.Description };


            /*Affichage de tous les abonnements principaux dans cbAbonnement*/
            cbDonnees.DataSource = typeAbonne.Select(a => new { Key = a.description, Value = a.identifiant }).ToList();
            cbDonnees.DisplayMember = "Key";
            cbDonnees.ValueMember = "Value";
        }

        private void parMoisEtParTerrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgAbonnement.Visible = false;
            dgPartiesJouees.Visible = true;
            dgDepenses.Visible = false;
            lblRecherche.Visible = true;
            lblRecherche.Text = "Entrez le mois en chiffre recherchée";
            lblAffiche.Text = "Statistiques par partie jouée";
            typeStat = "Parties par mois";

            var terrainSelectionne =
                from terrain in dataContext.Terrains
                select new { nom = terrain.Nom, no = terrain.No };

            //Affichage de tous les abonnements principaux dans cbAbonnement
            cbDonnees.DataSource = terrainSelectionne.Select(a => new { Key = a.nom, Value = a.no }).ToList();
            cbDonnees.DisplayMember = "Key";
            cbDonnees.ValueMember = "Value";
        }

        private void parAnnéeEtParTerrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgAbonnement.Visible = false;
            dgPartiesJouees.Visible = true;
            dgDepenses.Visible = false;
            lblRecherche.Visible = true;
            lblRecherche.Text = "Entrez l'année recherchée";
            lblAffiche.Text = "Statistiques par partie jouée";
            typeStat = "Parties par année";

            var terrainSelectionne =
                from terrain in dataContext.Terrains
                select new { nom = terrain.Nom, no = terrain.No };

            //Affichage de tous les abonnements principaux dans cbAbonnement
            cbDonnees.DataSource = terrainSelectionne.Select(a => new { Key = a.nom, Value = a.no }).ToList();
            cbDonnees.DisplayMember = "Key";
            cbDonnees.ValueMember = "Value";
        }

        private void parAnnéeEtParAbonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgAbonnement.Visible = false;
            dgPartiesJouees.Visible = false;
            dgDepenses.Visible = true;
            lblRecherche.Visible = true;
            lblRecherche.Text = "Entrez l'année recherchée";
            lblAffiche.Text = "Statistiques par dépense";
            typeStat = "Dépenses par année";

            var AbonnementSelectionne =
                from abonnement in dataContext.Abonnements
                select new { identifiant = abonnement.Nom + " " + abonnement.Prenom, id = abonnement.Id };


            //Affichage de tous les abonnements principaux dans cbAbonnement
            cbDonnees.DataSource = AbonnementSelectionne.Select(a => new { Key = a.identifiant, Value = a.id }).ToList();
            cbDonnees.DisplayMember = "Key";
            cbDonnees.ValueMember = "Value";
        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgAbonnement.Visible = false;
            dgPartiesJouees.Visible = false;
            dgDepenses.Visible = true;
            lblRecherche.Visible = true;
            lblRecherche.Text = "Entrez le mois en chiffre recherchée";
            lblAffiche.Text = "Statistiques par dépense";
            typeStat = "Dépenses par mois";

            var AbonnementSelectionne =
                 from abonnement in dataContext.Abonnements
                 select new { identifiant = abonnement.Nom + " " + abonnement.Prenom, id = abonnement.Id };


            //Affichage de tous les abonnements principaux dans cbAbonnement
            cbDonnees.DataSource = AbonnementSelectionne.Select(a => new { Key = a.identifiant, Value = a.id }).ToList();
            cbDonnees.DisplayMember = "Key";
            cbDonnees.ValueMember = "Value";
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (typeStat == "Abonnement par année")
            {
                if (txtRecherche.Text != "")
                {
                    if (int.Parse(txtRecherche.Text) <= DateTime.Now.Year)
                    {
                        var abonnementTotalParAnnee = from abonnement in dataContext.Abonnements
                                                      select abonnement;

                        var abonnementParAnnee = from abonnement in dataContext.Abonnements
                                                 where abonnement.DateAbonnement.Year == int.Parse(txtRecherche.Text.Trim())
                                                 && abonnement.NoTypeAbonnement == int.Parse(cbDonnees.SelectedValue.ToString())
                                                 select abonnement;


                        lblTotal.Text = "Total: " + abonnementTotalParAnnee.Count() + " abonnement(s) éffectué(s) toutes années confondus.";

                        if (abonnementParAnnee.Any())
                        {
                            lblSousTotal.Text = "Sous total: " + abonnementParAnnee.Count() + " abonnement(s) éffectué(s) en " + txtRecherche.Text + ".";
                            MessageBox.Show(abonnementParAnnee.Count().ToString() + " abonnement(s) trouvé(s) pour cette année!");
                            abonnementsBindingSource.DataSource = abonnementParAnnee;
                            txtRecherche.Text = "";
                        }
                        else
                        {
                            lblSousTotal.Text = "Sous total: Aucun abonnement éffectué cette année.";
                            MessageBox.Show("Aucun abonnement trouvé pour cette année!");
                            txtRecherche.Text = "";
                            abonnementsBindingSource.ResetBindings(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez une année valide!");
                        txtRecherche.Text = "";
                        abonnementsBindingSource.ResetBindings(false);
                    }
                }
                else
                {
                    MessageBox.Show("Entrez une année valide!");
                    txtRecherche.Text = "";
                    abonnementsBindingSource.ResetBindings(false);
                }
            }
            else if (typeStat == "Abonnement par mois")
            {
                if (txtRecherche.Text != "")
                {
                    if (int.Parse(txtRecherche.Text) < 13 && int.Parse(txtRecherche.Text) > 0)
                    {
                        var abonnementTotalParMois = from abonnement in dataContext.Abonnements
                                                     where abonnement.DateAbonnement.Year == DateTime.Now.Year
                                                     select abonnement;

                        var abonnementParMois = from abonnement in dataContext.Abonnements
                                                where abonnement.DateAbonnement.Year == DateTime.Now.Year
                                                && abonnement.DateAbonnement.Month == int.Parse(txtRecherche.Text.Trim())
                                                && abonnement.NoTypeAbonnement == int.Parse(cbDonnees.SelectedValue.ToString())
                                                select abonnement;


                        string moisLettre = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(txtRecherche.Text));
                        lblTotal.Text = "Total: " + abonnementTotalParMois.Count() + " abonnement(s) éffectué(s) pour l'année " + DateTime.Now.Year + ".";

                        if (abonnementParMois.Any())
                        {
                            lblSousTotal.Text = "Sous total: " + abonnementParMois.Count() + " abonnement(s) ont été éffectué en " + moisLettre + ".";
                            MessageBox.Show(abonnementParMois.Count().ToString() + " abonnement(s) trouvé(s) pour ce mois!");
                            abonnementsBindingSource.DataSource = abonnementParMois;
                            txtRecherche.Text = "";
                        }
                        else
                        {
                            lblSousTotal.Text = "Sous total: Aucun abonnement éffectué en " + moisLettre + ".";
                            MessageBox.Show("Aucun abonnement trouvé pour cette année!");
                            txtRecherche.Text = "";
                            abonnementsBindingSource.ResetBindings(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez un mois valide!");
                        txtRecherche.Text = "";
                        abonnementsBindingSource.ResetBindings(false);
                    }
                }
                else
                {
                    MessageBox.Show("Entrez un mois valide!");
                    txtRecherche.Text = "";
                    abonnementsBindingSource.ResetBindings(false);
                }
            }
            else if (typeStat == "Parties par année")
            {
                if (txtRecherche.Text != "")
                {
                    if (int.Parse(txtRecherche.Text) <= DateTime.Now.Year)
                    {
                        var partiesTotalParAnnee = from partie in dataContext.PartiesJouees
                                                   select partie;

                        var partiesParAnnee = from partie in dataContext.PartiesJouees
                                              where partie.DatePartie.Year == int.Parse(txtRecherche.Text.Trim())
                                              && partie.NoTerrain == int.Parse(cbDonnees.SelectedValue.ToString())
                                              select partie;


                        lblTotal.Text = "Total: " + partiesTotalParAnnee.Count() + " partie(s) jouée(s) toutes années confondus.";

                        if (partiesParAnnee.Any())
                        {
                            lblSousTotal.Text = "Sous total: " + partiesParAnnee.Count() + " partie(s) jouée(s) en " + txtRecherche.Text + ".";
                            MessageBox.Show(partiesParAnnee.Count().ToString() + " partie(s) jouée(s) cette année!");
                            partiesJoueesBindingSource.DataSource = partiesParAnnee;
                            txtRecherche.Text = "";
                        }
                        else
                        {
                            lblSousTotal.Text = "Sous total: Aucune partie jouée cette année.";
                            MessageBox.Show("Aucune partie trouvée pour cette année!");
                            txtRecherche.Text = "";
                            partiesJoueesBindingSource.ResetBindings(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez une année valide!");
                        txtRecherche.Text = "";
                        partiesJoueesBindingSource.ResetBindings(false);
                    }
                }
                else
                {
                    MessageBox.Show("Entrez une année valide!");
                    txtRecherche.Text = "";
                    partiesJoueesBindingSource.ResetBindings(false);
                }
            }
            else if (typeStat == "Parties par mois")
            {
                if (txtRecherche.Text != "")
                {
                    if (int.Parse(txtRecherche.Text) < 13 && int.Parse(txtRecherche.Text) > 0)
                    {
                        var partieTotalParMois = from partie in dataContext.PartiesJouees
                                                 where partie.DatePartie.Year == DateTime.Now.Year
                                                 select partie;

                        var partiesParMois = from partie in dataContext.PartiesJouees
                                             where partie.DatePartie.Year == DateTime.Now.Year
                                                && partie.DatePartie.Month == int.Parse(txtRecherche.Text.Trim())
                                                && partie.NoTerrain == int.Parse(cbDonnees.SelectedValue.ToString())
                                             select partie;


                        string moisLettre = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(txtRecherche.Text));
                        lblTotal.Text = "Total: " + partieTotalParMois.Count() + " partie(s) jouée pour l'année " + DateTime.Now.Year + ".";

                        if (partiesParMois.Any())
                        {
                            lblSousTotal.Text = "Sous total: " + partiesParMois.Count() + " partie(s) jouée(s) en " + moisLettre + ".";
                            MessageBox.Show(partiesParMois.Count().ToString() + " partie(s) jouée(s) pour ce mois!");
                            partiesJoueesBindingSource.DataSource = partiesParMois;
                            txtRecherche.Text = "";
                        }
                        else
                        {
                            lblSousTotal.Text = "Sous total: Aucune partie jouée en" + moisLettre + ".";
                            MessageBox.Show("Aucune partie jouée pour cette année!");
                            txtRecherche.Text = "";
                            partiesJoueesBindingSource.ResetBindings(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez un mois valide!");
                        txtRecherche.Text = "";
                        partiesJoueesBindingSource.ResetBindings(false);
                    }
                }
                else
                {
                    MessageBox.Show("Entrez un mois valide!");
                    txtRecherche.Text = "";
                    partiesJoueesBindingSource.ResetBindings(false);
                }
            }
            else if (typeStat == "Dépenses par année")
            {
                if (txtRecherche.Text != "")
                {
                    if (int.Parse(txtRecherche.Text) <= DateTime.Now.Year)
                    {
                        var depenseTotalParAnnee = from depense in dataContext.Depenses
                                                   select depense;

                        var depenseParAnnee = from depense in dataContext.Depenses
                                              where depense.DateDepense.Year == int.Parse(txtRecherche.Text.Trim())
                                              && depense.IdAbonnement == cbDonnees.SelectedValue.ToString()
                                              select depense;


                        lblTotal.Text = "Total: " + depenseTotalParAnnee.Count() + " dépense(s) ont été éffectué toutes années confondus.";

                        if (depenseParAnnee.Any())
                        {
                            lblSousTotal.Text = "Sous total: " + depenseParAnnee.Count() + " dépense(s) ont été éffectué en " + txtRecherche.Text + ".";
                            MessageBox.Show(depenseParAnnee.Count().ToString() + " dépense(s) trouvé(s) pour cette année!");
                            depensesBindingSource.DataSource = depenseParAnnee;
                            txtRecherche.Text = "";
                        }
                        else
                        {
                            lblSousTotal.Text = "Sous total: Aucune dépense a été éffectué en cette année.";
                            MessageBox.Show("Aucune dépense trouvée pour cette année!");
                            txtRecherche.Text = "";
                            depensesBindingSource.ResetBindings(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez une année valide!");
                        txtRecherche.Text = "";
                        depensesBindingSource.ResetBindings(false);
                    }
                }
                else
                {
                    MessageBox.Show("Entrez une année valide!");
                    txtRecherche.Text = "";
                    depensesBindingSource.ResetBindings(false);
                }
            }
            else if (typeStat == "Dépenses par mois")
            {

                if (txtRecherche.Text != "")
                {
                    if (int.Parse(txtRecherche.Text) < 13 && int.Parse(txtRecherche.Text) > 0)
                    {
                        var depenseTotalParMois = from depense in dataContext.Depenses
                                                  where depense.DateDepense.Year == DateTime.Now.Year
                                                  select depense;

                        var depenseParMois = from depense in dataContext.Depenses
                                             where depense.DateDepense.Year == DateTime.Now.Year
                                             && depense.DateDepense.Month == int.Parse(txtRecherche.Text.Trim())
                                             && depense.IdAbonnement == cbDonnees.SelectedValue.ToString()
                                             select depense;


                        string moisLettre = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(txtRecherche.Text));
                        lblTotal.Text = "Total: " + depenseTotalParMois.Count() + " dépense(s) éffectuée(s) pour l'année " + DateTime.Now.Year + ".";

                        if (depenseParMois.Any())
                        {
                            lblSousTotal.Text = "Sous total: " + depenseParMois.Count() + " dépense(s) éffectuée(s) en " + moisLettre + ".";
                            MessageBox.Show(depenseParMois.Count().ToString() + " dépense(s) trouvée(s) pour ce mois!");
                            depensesBindingSource.DataSource = depenseParMois;
                            txtRecherche.Text = "";
                        }
                        else
                        {
                            lblSousTotal.Text = "Sous total: Aucune dépense éffectuée en " + moisLettre + ".";
                            MessageBox.Show("Aucune dépense trouvée pour cette année!");
                            txtRecherche.Text = "";
                            depensesBindingSource.ResetBindings(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez un mois valide!");
                        txtRecherche.Text = "";
                        depensesBindingSource.ResetBindings(false);
                    }
                }
                else
                {
                    MessageBox.Show("Entrez un mois valide!");
                    txtRecherche.Text = "";
                    depensesBindingSource.ResetBindings(false);
                }
            }
        }


        private void cbDonnees_TextChanged(object sender, EventArgs e)
        {
            abonnementsBindingSource.ResetBindings(false);
            partiesJoueesBindingSource.ResetBindings(false);
            depensesBindingSource.ResetBindings(false);
            lblTotal.Text = "Total: ";
            lblSousTotal.Text = "Sous total: ";
        }
    }
    
}
