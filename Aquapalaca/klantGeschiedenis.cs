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
    public partial class klantGeschiedenis : Form
    {
        public klantGeschiedenis()
        {
            InitializeComponent();
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            KlantPagina klantPagina = new KlantPagina();
            klantPagina.Show();
            this.Hide();
        }

        private void lbxKlantGeschiedenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void klantGeschiedenis_Load(object sender, EventArgs e)
        {
            var gebruiker = Session.HuidigeGebruiker;

            if (gebruiker.CustomerId == null)
            {
                lbxKlantGeschiedenis.Items.Add("Geen klant-ID gevonden.");
                return;
            }

            var logs = AbonnementLogs.GetLogsByCustomerId(gebruiker.CustomerId.Value);


            if (logs.Count == 0)
            {
                lbxKlantGeschiedenis.Items.Add("Geen abonnementslogs gevonden.");
            }
            else
            {
                foreach (var log in logs)
                {
                    string item = $"[{log.LogTijd:dd-MM-yyyy HH:mm}] " +
                                  $"Abonnement #{log.SubscriptieId} | " +
                                  $"Einddatum: {log.EindDatum:dd-MM-yyyy} | " +
                                  $"Status: {log.Status}";
                    lbxKlantGeschiedenis.Items.Add(item);
                }
            }
        }
    }
}
