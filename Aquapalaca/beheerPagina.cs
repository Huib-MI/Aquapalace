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
    public partial class beheerPagina : Form
    {
        public beheerPagina()
        {
            InitializeComponent();
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void beheerPagina_Load(object sender, EventArgs e)
        {

        }

        private void BtnGebruikersoverzicht_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbonnementsoverzicht_Click(object sender, EventArgs e)
        {
            var nieuweForm = new Abonnementsoverzicht();
            nieuweForm.Show();

            this.Hide();

        }

        private void BtnRolbeheer_Click(object sender, EventArgs e)
        {
            var nieuweForm = new Rolbeheer();
            nieuweForm.Show();

            this.Hide();
        }
    }
}
