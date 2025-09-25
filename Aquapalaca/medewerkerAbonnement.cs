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
            cmbFilterKlant.Items.Add("Alle klanten");
            txtStatus.Hide();
            lblStatus.Hide();
            cmbKoppelKlant.Hide();
            lblKoppelKlant.Hide();
            btnKoppelKlant.Hide();
            btnKoppelKlant.Enabled = false;

            foreach (Abonnement abonnement in Abonnement.getAbonnementen())
            {
                lbxAbonnement.Items.Add(abonnement);
            }

            foreach (Klanten klant in Klanten.getCustomers())
            {
                cmbFilterKlant.Items.Add(klant);
            }

            foreach (Klanten klant in Klanten.getCustomers())
            {
                cmbKoppelKlant.Items.Add(klant);
            }

            if (cmbFilterKlant.Items.Count > 0)
            {
                cmbFilterKlant.SelectedIndex = 0;
            }

            cmbFilterType.Items.Add("Alle types");
            foreach (AbonnementType type in AbonnementType.getTypes())
            {
                cmbFilterType.Items.Add(type);
            }

            if (cmbFilterType.Items.Count > 0)
            {
                cmbFilterType.SelectedIndex = 0;
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
            cmbKoppelKlant.SelectedIndex = -1;

            if (lbxAbonnement.SelectedItem is Abonnement geselecteerdAbonnement)
            {
                txtStatus.Show();
                lblStatus.Show();
                cmbKoppelKlant.Show();
                lblKoppelKlant.Show();
                btnKoppelKlant.Show();


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
                cmbKoppelKlant.Hide();
                lblKoppelKlant.Hide();
                btnKoppelKlant.Hide();
            }
        }

        private void btnAddAbbonement_Click(object sender, EventArgs e)
        {
            btnDeselect_Click(sender, e);

            using (MedewerkerNieuwAbonnement medewerkerNieuwAbonnement = new MedewerkerNieuwAbonnement())
            {
                var result = medewerkerNieuwAbonnement.ShowDialog();
                FilterAbonnementen();
            }
        }

        private void FilterAbonnementen()
        {
            int selectedId = -1;
            if (lbxAbonnement.SelectedItem is Abonnement selectedAbonnement)
                selectedId = selectedAbonnement.Id;

            lbxAbonnement.Items.Clear();
            int klantId = 0;
            int typeId = 0;

            if (cmbFilterKlant.SelectedItem is Klanten geselecteerdeKlant)
                klantId = geselecteerdeKlant.Id;

            if (cmbFilterType.SelectedItem is AbonnementType geselecteerdType)
                typeId = geselecteerdType.Id;

            List<Abonnement> filtered = Abonnement.filterAbonnementen(klantId, typeId);

            foreach (Abonnement abonnement in filtered)
            {
                lbxAbonnement.Items.Add(abonnement);
            }

            if (selectedId != -1)
            {
                foreach (Abonnement abonnement in lbxAbonnement.Items)
                {
                    if (abonnement.Id == selectedId)
                    {
                        lbxAbonnement.SelectedItem = abonnement;
                        break;
                    }
                }
            }
        }



        private void cmbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStatus.Text = "";
            cmbKoppelKlant.SelectedIndex = -1;
            FilterAbonnementen();
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStatus.Text = "";
            cmbKoppelKlant.SelectedIndex = -1;
            FilterAbonnementen();
        }

        private void cmbKoppelKlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKoppelKlant.SelectedItem is Klanten)
            {
                btnKoppelKlant.Enabled = true;
            }
            else
            {
                btnKoppelKlant.Enabled = false;
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            lbxAbonnement.ClearSelected();

            txtStatus.Hide();
            lblStatus.Hide();
            cmbKoppelKlant.Hide();
            lblKoppelKlant.Hide();
            btnKoppelKlant.Hide();

            cmbKoppelKlant.SelectedIndex = -1;
            btnKoppelKlant.Enabled = false;
        }

        private void btnKoppelKlant_Click(object sender, EventArgs e)
        {
            if (lbxAbonnement.SelectedItem is Abonnement selectedAbonnement &&
                cmbKoppelKlant.SelectedItem is Klanten selectedKlant)
            {
                selectedAbonnement.KoppelKlant(selectedKlant.Id);
                MessageBox.Show($"Abonnement {selectedAbonnement.Id} is nu gebonden aan {selectedKlant}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FilterAbonnementen();
            }
        }
    }
}
