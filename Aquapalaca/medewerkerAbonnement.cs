using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            cmbKlanten.Items.Add("Alle klanten");
            txtStatus.Hide();
            lblStatus.Hide();
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

            cmbTypes.Items.Add("Alle types");
            foreach (AbonnementType type in AbonnementType.getTypes())
            {
                cmbTypes.Items.Add(type);
            }

            if (cmbTypes.Items.Count > 0)
            {
                cmbTypes.SelectedIndex = 0;
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
                txtStatus.Show();
                lblStatus.Show();

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
            else
            {
                txtStatus.Hide();
                lblStatus.Hide();
            }
        }

        private void btnAddAbbonement_Click(object sender, EventArgs e)
        {
            MedewerkerNieuwAbonnement medewerkerNieuwAbonnement = new MedewerkerNieuwAbonnement();
            medewerkerNieuwAbonnement.Show();
        }

        private void FilterAbonnementen()
        {
            lbxAbonnement.Items.Clear();

            int klantId = 0;
            int typeId = 0;

            if (cmbKlanten.SelectedItem is Klanten geselecteerdeKlant)
                klantId = geselecteerdeKlant.Id;

            if (cmbTypes.SelectedItem is AbonnementType geselecteerdType)
                typeId = geselecteerdType.Id;

            List<Abonnement> filtered = Abonnement.filterAbonnementen(klantId, typeId);

            foreach (Abonnement abonnement in filtered)
            {
                lbxAbonnement.Items.Add(abonnement);
            }

            lbxAbonnement.ClearSelected();
            txtStatus.Hide();
            lblStatus.Hide();
        }


        private void cmbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStatus.Text = "";
            FilterAbonnementen();
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStatus.Text = "";
            FilterAbonnementen();
        }
    }
}
