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
    public partial class medewerkerAbonnement : Form
    {
        public medewerkerAbonnement()
        {
            InitializeComponent();
            foreach (Abonnement abonnement in Abonnement.getAbonnementen())
            {
                lbxAbonnement.Items.Add(abonnement);
            }

            foreach (Klanten klant in Klanten.getCustomers())
            {
                cmbKlanten.Items.Add(klant);
            }

            if (cmbKlanten.Items.Count > 0)
            {
                cmbKlanten.SelectedIndex = 0;
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            medewerkerPagina MedewerkerPagina = new medewerkerPagina();
            MedewerkerPagina.Show();
            this.Hide();
        }

        private void lbxAbonnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAbonnement.SelectedItem is Abonnement geselecteerdAbonnement)
            {
                if (geselecteerdAbonnement.Actief == 1)
                {
                    txtStatus.Text = "Actief";
                }
                else if (geselecteerdAbonnement.Actief == 0)
                {
                    txtStatus.Text = "Inactief";
                }
                else
                {
                    txtStatus.Text = "";
                }
            }
        }

        private void btnAddAbbonement_Click(object sender, EventArgs e)
        {
            MedewerkerNieuwAbonnement medewerkerNieuwAbonnement = new MedewerkerNieuwAbonnement();
            medewerkerNieuwAbonnement.Show();
        }

        private void cmbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKlanten.SelectedItem is Klanten geselecteerdeKlant)
            {
                lbxAbonnement.Items.Clear();

                foreach (Abonnement abonnement in Abonnement.getAbonnementenByCustomerId(geselecteerdeKlant.Id))
                {
                    lbxAbonnement.Items.Add(abonnement);
                }
            }
        }
    }
}
