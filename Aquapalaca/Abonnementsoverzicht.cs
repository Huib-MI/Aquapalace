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

            foreach (Abonnement abonnement in Abonnement.getAbonnementen())
            {
                lbxAbonnement.Items.Add(abonnement);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvSubscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKlanten_Click(object sender, EventArgs e)
        {
            var nieuweForm = new Klantenoverzicht();
            nieuweForm.Show();

            this.Hide();

        }

        private void BtnInchecken_Click(object sender, EventArgs e)
        {
            var nieuweForm = new medewerkerInchecken();
            nieuweForm.Show();

            this.Hide();

        }
    }
}
