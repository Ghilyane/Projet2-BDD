using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using System.Data.SqlClient;

namespace ProjetFinal
{
    public partial class frmGestionEmployes : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmAjoutEmploye frmAjout = new frmAjoutEmploye();
        frmModifierEmploye frmModifier = new frmModifierEmploye();
        private int intNoEmpConnecte;
        public frmGestionEmployes(int intNoEmpConnecte)
        {
            InitializeComponent();
            this.intNoEmpConnecte = intNoEmpConnecte;
        }

        private void frmGestionEmployes_Load(object sender, EventArgs e)
        {
            //employesdg.Columns[0].
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               join uneProvince in monDataContext.Provinces
                                               on unEmploye.IdProvince equals uneProvince.Id
                                               //where unEmploye.IdProvince == uneProvince.Nom
                                               select unEmploye;
            typesEmployeBindingSource.DataSource = from unType in monDataContext.TypesEmploye
                                                   select unType;
            provincesBindingSource.DataSource = from uneProvince in monDataContext.Provinces
                                                select uneProvince;

        }

        private void employesdg_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Employes nouvelEmploye = new Employes { };

            int noEmpMax = (from unEmploye in monDataContext.Employes
                           select unEmploye.No).Max() + 1;

            nouvelEmploye.No = noEmpMax;
            frmAjout.nouvelEmploye = nouvelEmploye;
            frmAjout.ShowDialog();

            if (nouvelEmploye.Nom != null)
            {
                monDataContext.Employes.InsertOnSubmit(nouvelEmploye);
                //insère le contrat dans la base de données
                using (var porteTransaction = new TransactionScope())
                {
                    try
                    {
                        monDataContext.SubmitChanges();
                        MessageBox.Show($"L'employé {nouvelEmploye.No} a été enregistré. ", "Ajout d'un employé");
                        porteTransaction.Complete();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                    }
                }
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (employesBindingSource.Count > 0)
            {
                int intRow = dgEmployes.CurrentCell.RowIndex;
                int intNoEmploye = (int)dgEmployes.Rows[intRow].Cells[0].Value;

                var employeSelect = (from unEmploye in monDataContext.Employes
                                     where unEmploye.No == intNoEmploye
                                     select unEmploye).First();

                frmModifier.modifEmploye = employeSelect;
                frmModifier.ShowDialog();

                if (frmModifier.modifEmploye != employeSelect)
                {
                    using (var porteTransaction = new TransactionScope())
                    {
                        try
                        {
                            monDataContext.SubmitChanges();
                            MessageBox.Show($"L'employé {employeSelect.No} a été modifié. ", "Modification d'un employé");
                            porteTransaction.Complete();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Il n'y a aucun employé présentement.", "Modification d'un employé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (employesBindingSource.Count > 0)
            {
                int intRow = dgEmployes.CurrentCell.RowIndex;
                int intNoEmploye = (int)dgEmployes.Rows[intRow].Cells[0].Value;

                var employeSelect = (from unEmploye in monDataContext.Employes
                                     where unEmploye.No == intNoEmploye
                                     select unEmploye).First();

                int nbServices = (from unService in monDataContext.Services
                                      where unService.NoEmploye == intNoEmploye
                                      select unService).Count();

                if (intNoEmploye == 1)
                    MessageBox.Show("L'administrateur ne peut être supprimé.", "Suppression d'un employé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (intNoEmploye == intNoEmpConnecte)
                    MessageBox.Show("Vous ne pouvez pas vous supprimer.");
                else if (nbServices > 0)
                    MessageBox.Show("Vous ne pouvez pas supprimer un employé offrant des services.");
                else
                {

                    DialogResult result = MessageBox.Show("Êtes-vous sûr.e de vouloir supprimer cet employé?", "Confirmation de la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        monDataContext.Employes.DeleteOnSubmit(employeSelect);
                        using (var porteTransaction = new TransactionScope())
                        {
                            try
                            {
                                monDataContext.SubmitChanges();
                                MessageBox.Show($"L'employé {employeSelect.No} a été supprimé. ", "Suppression d'un employé");
                                porteTransaction.Complete();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Impossible de modifier la base de données");
                            }
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Il n'y a aucun employé présentement.", "Suppression d'un employé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
