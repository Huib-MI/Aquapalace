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
    public partial class medewerkerNieuwAbonnement: Form
    {
        public medewerkerNieuwAbonnement()
        {
            InitializeComponent();
            foreach (Klanten klant in Klanten.getCustomers())
            {
                cmbKoppelKlant.Items.Add(klant);
            }
            foreach (AbonnementType type in AbonnementType.getTypes())
            {
                cmbTypeAbonnement.Items.Add(type);
            }
            cmbStatusAbonnement.Items.Add("Actief");
            cmbStatusAbonnement.Items.Add("Inactief");
        }

        private void btnKoppelKlant_Click(object sender, EventArgs e)
        {

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKoppelKlant_Click_1(object sender, EventArgs e)
        {
            if (cmbKoppelKlant.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een klant!");
                return;
            }

            if (cmbTypeAbonnement.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een abonnementstype!");
                return;
            }

            if (cmbStatusAbonnement.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een status (Actief/Inactief)!");
                return;
            }

            int ritten;
            if (!int.TryParse(txtRitten.Text, out ritten) || ritten < 0)
            {
                MessageBox.Show("Voer een geldig positief getal in voor het aantal ritten.");
                return;
            }

            if (dtpStartDatum.Value.Date > dtpEindDatum.Value.Date)
            {
                MessageBox.Show("De startdatum mag niet na de einddatum liggen.");
                return;
            }

            Abonnement abonnement = new Abonnement
            {
                KlantId = ((Klanten)cmbKoppelKlant.SelectedItem).Id,
                TypeId = ((AbonnementType)cmbTypeAbonnement.SelectedItem).Id,
                StartDatum = dtpStartDatum.Value.Date,
                EindDatum = dtpEindDatum.Value.Date,
                OverigeRitten = ritten,
                Actief = cmbStatusAbonnement.SelectedItem.ToString() == "Actief" ? 1 : 0
            };

            abonnement.Insert();

            MessageBox.Show("Abonnement succesvol toegevoegd!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
