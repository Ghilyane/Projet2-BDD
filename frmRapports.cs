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
        public frmRapports()
        {
            InitializeComponent();
        }

        private void dépensesParAbonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dépensesParAnnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dépensesParEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAffiche.Visible = true;
            lblAffiche.Text += " dépense par employé";            
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }
    }
}
