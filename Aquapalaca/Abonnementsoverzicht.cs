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
    public partial class Abonnementsoverzicht : Form
    {
        public Abonnementsoverzicht()
        {
            InitializeComponent();
        }

        private void Abonnementsoverzicht_Load(object sender, EventArgs e)
        {

        }

        private void BtnUitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();

            beheerPagina beheer = new beheerPagina();

            beheer.Show();
        }
    }
}
