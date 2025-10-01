using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aquapalaca
{
    public partial class medewerkerInchecken : Form
    {
        private List<Klanten> klantenList = new List<Klanten>();
        private Klanten laatsteIngecheckteKlant = null;

        public medewerkerInchecken()
        {
            InitializeComponent();
            LoadKlanten();
        }

        private void LoadKlanten()
        {
            klantenList = Klanten.getCustomers();
            cmbCheckin.Items.Clear();

            foreach (Klanten klant in klantenList)
            {
                cmbCheckin.Items.Add(klant);
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            medewerkerPagina medewerkerPagina = new medewerkerPagina();
            medewerkerPagina.Show();
            this.Hide();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (cmbCheckin.SelectedItem == null)
            {
                ToonStatus("⚠️ Selecteer een klant.", false);
                return;
            }

            Klanten klant = (Klanten)cmbCheckin.SelectedItem;

            if (laatsteIngecheckteKlant != null && laatsteIngecheckteKlant.Id == klant.Id)
            {
                var result = MessageBox.Show(
                    "Er is net al een check-in voor deze gebruiker geweest. Wil je doorgaan?",
                    "Bevestig check-in",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    ToonStatus("⚠️ Check-in geannuleerd.", false);
                    return;
                }
            }

            List<Abonnement> abonnementen = Abonnement.filterAbonnementen(klant.Id, 0);
            if (abonnementen == null || abonnementen.Count == 0)
            {
                ToonStatus("❌ Geen abonnement gevonden voor deze klant.", false);
                return;
            }

            Abonnement actiefAbonnement = abonnementen.FirstOrDefault(a => a.Actief == 1);
            if (actiefAbonnement == null)
            {
                ToonStatus("❌ Geen actief abonnement gevonden.", false);
                return;
            }

            try
            {
                Checkin checkin = new Checkin
                {
                    SubscriptieId = actiefAbonnement.Id,
                    KlantId = klant.Id,
                    CheckinTijd = DateTime.Now,
                    CheckinMethode = "receptie"
                };
                checkin.Insert();

                if (actiefAbonnement.OverigeRitten > 0)
                {
                    actiefAbonnement.OverigeRitten -= 1;
                    actiefAbonnement.Update();
                }

                AbonnementLogs log = new AbonnementLogs
                {
                    SubscriptieId = actiefAbonnement.Id,
                    KlantId = klant.Id,
                    EindDatum = actiefAbonnement.EindDatum,
                    LogTijd = DateTime.Now,
                    Status = "checked_in"
                };
                log.Insert();

                ToonStatus("✅ " + klant.Firstname + " " + klant.Lastname + " ingecheckt", true);

                laatsteIngecheckteKlant = klant;
            }
            catch (Exception ex)
            {
                ToonStatus("❌ Fout bij inchecken: " + ex.Message, false);
            }
        }

        private void ToonStatus(string boodschap, bool succes)
        {
            lblCheckin.Text = boodschap;
            lblCheckin.ForeColor = succes ? Color.Green : Color.Red;
            lblCheckin.Font = new Font(lblCheckin.Font, FontStyle.Bold);
        }

        private void cmbCheckin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void medewerkerInchecken_Load(object sender, EventArgs e)
        {

        }
    }

}
