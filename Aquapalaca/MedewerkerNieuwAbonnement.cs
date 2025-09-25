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
    public partial class MedewerkerNieuwAbonnement: Form
    {
        public MedewerkerNieuwAbonnement()
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
            if (cmbKoppelKlant.SelectedItem == null || cmbTypeAbonnement.SelectedItem == null || cmbStatusAbonnement.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een klant, type en status!");
                return;
            }

            Abonnement abonnement = new Abonnement();
            abonnement.KlantId = ((Klanten)cmbKoppelKlant.SelectedItem).Id;
            abonnement.TypeId = ((AbonnementType)cmbTypeAbonnement.SelectedItem).Id;
            abonnement.StartDatum = dtpStartDatum.Value;
            abonnement.EindDatum = dtpEindDatum.Value;
            abonnement.OverigeRitten = Convert.ToInt32(txtRitten.Text);

            // Correctly get status from the status ComboBox
            string status = cmbStatusAbonnement.SelectedItem.ToString();
            if (status == "Actief")
                abonnement.Actief = 1;
            else if (status == "Inactief")
                abonnement.Actief = 0;
            else
            {
                MessageBox.Show("Selecteer een geldige status (Actief/Inactief)");
                return;
            }

            // Call insert as an instance method
            abonnement.Insert();
            MessageBox.Show("Abonnement succesvol toegevoegd!");
            this.Hide();
        }
    }
}
