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
                ToonStatus("Selecteer een klant.", false);
                return;
            }

            Klanten klant = (Klanten)cmbCheckin.SelectedItem;

            List<Abonnement> abonnementen = Abonnement.filterAbonnementen(klant.Id, 0);
            if (abonnementen == null || abonnementen.Count == 0)
            {
                ToonStatus("Geen abonnement gevonden voor deze klant.", false);
                return;
            }

            Abonnement actiefAbonnement = abonnementen.FirstOrDefault(a => a.Actief == 1);
            if (actiefAbonnement == null)
            {
                ToonStatus("Geen actief abonnement gevonden.", false);
                return;
            }

            try
            {
                Checkin checkin = new Checkin();
                checkin.SubscriptieId = actiefAbonnement.Id;
                checkin.KlantId = klant.Id;
                checkin.CheckinTijd = DateTime.Now;
                checkin.CheckinMethode = "receptie";
                checkin.Insert();

                AbonnementLogs log = new AbonnementLogs();
                log.SubscriptieId = actiefAbonnement.Id;
                log.KlantId = klant.Id;
                log.EindDatum = actiefAbonnement.EindDatum;
                log.LogTijd = DateTime.Now;
                log.Status = "checked_in";
                log.Insert();

                ToonStatus("✅ " + klant.Firstname + " " + klant.Lastname + " is succesvol ingecheckt!", true);
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
    }
}
