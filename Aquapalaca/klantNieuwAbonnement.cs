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
    public partial class klantNieuwAbonnement : Form
    {
        private int geselecteerdAbonnementType = 0;

        public klantNieuwAbonnement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KlantPagina klantPagina = new KlantPagina();
            klantPagina.Show();
            this.Hide();
        }

        private void klantNieuwAbonnement_Load(object sender, EventArgs e)
        {
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            string abonnementType = "";
            var gebruiker = Session.HuidigeGebruiker;
            if (geselecteerdAbonnementType == 0)
            {
                MessageBox.Show("Kies eerst een abonnementstype.");
                return;
            }
            else if (geselecteerdAbonnementType == 1)
            {
                abonnementType = "Maandabonnement";
            }
            else if (geselecteerdAbonnementType == 2)
            {
                abonnementType = "Jaarabonnement";
            }
            else if (geselecteerdAbonnementType == 3)
            {
                abonnementType = "Rittenkaart";
            }

                int abonnementTypeId = geselecteerdAbonnementType;
            Abonnement nieuwAbonnement = new Abonnement
            {
                TypeId = abonnementTypeId,
                KlantId = gebruiker.Id,
                StartDatum = DateTime.Now,
                EindDatum = geselecteerdAbonnementType == 1 ? DateTime.Now.AddMonths(1) :
                             geselecteerdAbonnementType == 2 ? DateTime.Now.AddYears(1) : DateTime.Now,
                OverigeRitten = geselecteerdAbonnementType == 3 ? 10 : 0,
                Actief = 1
            };

            nieuwAbonnement.Insert();

            // Hier komt jouw database insert/update code
            MessageBox.Show(abonnementType + " toegevoegd voor gebruiker " + gebruiker.Voornaam + " " + gebruiker.Achternaam);
        }

        private void rdbMaand_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaand.Checked)
            {
                geselecteerdAbonnementType = 1;
                lblPrijs.Text = "Prijs: €45 per maand";
            }
        }

        private void rdbJaar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJaar.Checked)
            {
                geselecteerdAbonnementType = 2;
                lblPrijs.Text = "Prijs: €450 per jaar";
            }
        }

        private void rdbRittenkaart_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRittenkaart.Checked)
            {
                geselecteerdAbonnementType = 3;
                lblPrijs.Text = "Prijs: €80 voor 10 ritten";
            }
        }
    }
}
