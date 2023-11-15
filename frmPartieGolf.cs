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
    public partial class frmPartieGolf : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();

        public frmPartieGolf()
        {
            InitializeComponent();
        }

        private void frmPartieGolf_Load(object sender, EventArgs e)
        {
            partiesJoueesBindingSource.DataSource = monDataContext.PartiesJouees;
        }
    }
}
