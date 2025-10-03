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
    public partial class klantInchecken : Form
    {
        public klantInchecken()
        {
            InitializeComponent();
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            KlantPagina klantPagina = new KlantPagina();
            klantPagina.Show();
            this.Hide();
        }

        private void lblNaam_Click(object sender, EventArgs e)
        {

        }

        private void klantInchecken_Load(object sender, EventArgs e)
        {
            var gebruiker = Session.HuidigeGebruiker;

            if (gebruiker != null)
            {
                lblNaam.Text = gebruiker.Voornaam + " " + gebruiker.Achternaam + "!";
            }
        }

        private void btnInchecken_Click(object sender, EventArgs e)
        {
            var gebruiker = Session.HuidigeGebruiker;

            if (gebruiker == null)
            {
                MessageBox.Show("Geen gebruiker ingelogd!");
                return;
            }

            if (gebruiker.SubscriptionId == null)
            {
                MessageBox.Show("Geen geldig abonnement gevonden!");
                return;
            }

            Checkin checkin = new Checkin
            {
                SubscriptieId = gebruiker.SubscriptionId.Value,  // veilig want we checkten net op null
                KlantId = gebruiker.CustomerId,            // ook nullable dus beter met .Value
                CheckinTijd = DateTime.Now,
                CheckinMethode = "button"
            };


            try
            {
                checkin.Insert();
                MessageBox.Show("Check-in succesvol!");
                KlantPagina klantPagina = new KlantPagina();
                klantPagina.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij inchecken: " + ex.Message);
            }
        }
    }
}
