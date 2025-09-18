using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquapalaca
{
    public partial class medewerkerPagina : Form
    {
        public medewerkerPagina()
        {
            InitializeComponent();
        }

        private void btnAbonnementen_Click(object sender, EventArgs e)
        {
            medewerkerAbonnement MedewerkerAbonnement = new medewerkerAbonnement();
            MedewerkerAbonnement.Show();
            this.Hide();
        }

        private void btnKlanten_Click(object sender, EventArgs e)
        {
            medewerkerKlanten MedewerkerKlanten = new medewerkerKlanten();
            MedewerkerKlanten.Show();
            this.Hide();
        }

        private void btnInchecken_Click(object sender, EventArgs e)
        {
            medewerkerInchecken MedewerkerInchecken = new medewerkerInchecken();
            MedewerkerInchecken.Show();
            this.Hide();
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
