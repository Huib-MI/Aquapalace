using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aquapalaca
{
    public partial class klantVerlengen: Form
    {
        private List<Abonnement> abonnementen;
        public klantVerlengen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KlantPagina klantPagina = new KlantPagina();
            klantPagina.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerlengen_Click(object sender, EventArgs e)
        {
            if (cmbAbonnement.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een abonnement.");
                return;
            }

            Abonnement geselecteerd = (Abonnement)cmbAbonnement.SelectedItem;

            if (geselecteerd.TypeId == 1 || geselecteerd.TypeId == 2) // maand- of jaarabonnement
            {
                DialogResult keuze = MessageBox.Show("Wil je verlengen met 1 maand (Ja), 6 maanden (Nee) of 1 jaar (Annuleren)?",
                                                     "Abonnement verlengen",
                                                     MessageBoxButtons.YesNoCancel);

                if (keuze == DialogResult.Yes)
                {
                    geselecteerd.EindDatum = geselecteerd.EindDatum.AddMonths(1);
                }
                else if (keuze == DialogResult.No)
                {
                    geselecteerd.EindDatum = geselecteerd.EindDatum.AddMonths(6);
                }
                else if (keuze == DialogResult.Cancel)
                {
                    geselecteerd.EindDatum = geselecteerd.EindDatum.AddYears(1);
                }

                geselecteerd.Update();
                MessageBox.Show("Abonnement verlengd!");
            }
            else if (geselecteerd.TypeId == 3) // rittenkaart
            {
                geselecteerd.OverigeRitten += 10; // verlengen met 10 ritten
                geselecteerd.Update();
                MessageBox.Show("Rittenkaart verlengd met 10 ritten!");
            }


            // lijst opnieuw laden zodat wijzigingen zichtbaar worden
            LaadAbonnementen(Session.HuidigeGebruiker.Id);
        }

        private void klantVerlengen_Load(object sender, EventArgs e)
        {
            var gebruiker = Session.HuidigeGebruiker;
            if (gebruiker == null)
            {
                MessageBox.Show("Geen gebruiker ingelogd!");
                this.Close();
                return;
            }

            LaadAbonnementen(gebruiker.CustomerId);
        }

        private void LaadAbonnementen(int klantId)
        {
            cmbAbonnement.Items.Clear();

            abonnementen = Abonnement.filterAbonnementen(klantId, 0);

            foreach (Abonnement ab in abonnementen)
            {
                cmbAbonnement.Items.Add(ab);
            }
        }
    }
}
