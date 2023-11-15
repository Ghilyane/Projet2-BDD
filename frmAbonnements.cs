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
    public partial class frmAbonnements : Form
    {
        frmAjoutAbonnement frmAjout = new frmAjoutAbonnement();
        public frmAbonnements()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            frmAjout.ShowDialog();

        }
    }
}
