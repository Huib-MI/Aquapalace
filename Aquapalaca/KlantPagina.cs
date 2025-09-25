using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquapalaca
{
    public partial class KlantPagina : Form
    {
        public static KlantPagina instance;
        public Label lab1;
        public KlantPagina()
        {
            InitializeComponent();
            instance = this;
            lab1 = lblWelkom;
            this.Size = new Size(800, 400);
        }

        private void KlantPagina_Load(object sender, EventArgs e)
        {
            var gebruiker = Session.HuidigeGebruiker;

            if (gebruiker != null)
            {
                lblPersoon.Text = gebruiker.Voornaam + " " + gebruiker.Achternaam + "!";
                if (gebruiker.AbonnementEinde != null)
                {
                    lblJaarOutput.Text = $"Abonnement loopt tot {gebruiker.AbonnementEinde.Value.ToShortDateString()}";
                }
                else
                {
                    lblJaarOutput.Text = "Geen actief abonnement";
                }
            }
            if (gebruiker.OverigeRitten.HasValue && gebruiker.OverigeRitten.Value > 0)
            {
                lblRittenkaartOutput.Text = "Nog " + gebruiker.OverigeRitten.ToString() + " overige ritten";
            }
            else
            {
                lblRittenkaartOutput.Text = "Geen overige ritten";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lblAbonnement_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerlengen_Click(object sender, EventArgs e)
        {
            klantVerlengen KlantVerlengen = new klantVerlengen();
            KlantVerlengen.Show();
            this.Hide();
        }

        private void BtnInchecken_Click(object sender, EventArgs e)
        {
            klantInchecken KlantInchecken = new klantInchecken();
            KlantInchecken.Show();
            this.Hide();
        }

        private void BtnGeschiedenis_Click(object sender, EventArgs e)
        {
            klantGeschiedenis KlantGeschiedenis = new klantGeschiedenis();
            KlantGeschiedenis.Show();
            this.Hide();
        }

        private void BtnNieuwAbonnement_Click(object sender, EventArgs e)
        {
            klantNieuwAbonnement KlantNieuwAbonnement = new klantNieuwAbonnement();
            KlantNieuwAbonnement.Show();
            this.Hide();
        }
    }
}
