using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aquapalaca
{
    public partial class medewerkerKlanten : Form
    {
        private List<Klanten> klantenList;

        public medewerkerKlanten()
        {
            InitializeComponent();
            LoadKlanten();
        }

        private void LoadKlanten(int? selectId = null)
        {
            klantenList = Klanten.getCustomers(); 
            lbxKlanten.Items.Clear();

            foreach (Klanten klant in klantenList)
            {
                lbxKlanten.Items.Add(klant.ToDetailedString());
            }

            if (selectId.HasValue)
            {
                for (int i = 0; i < klantenList.Count; i++)
                {
                    if (klantenList[i].Id == selectId.Value)
                    {
                        lbxKlanten.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                Deselect();
            }
        }
        private void Deselect()
        {
            txtVoornaam.ReadOnly = true;
            txtVoornaam.Text = "";
            txtAchternaam.ReadOnly = true;
            txtAchternaam.Text = "";
            txtAdress.ReadOnly = true;
            txtAdress.Text = "";
            txtPostcode.ReadOnly = true;
            txtPostcode.Text = "";
            txtStad.ReadOnly = true;
            txtStad.Text = "";
            txtEmail.ReadOnly = true;
            txtEmail.Text = "";
            txtTelefoon.ReadOnly = true;
            txtTelefoon.Text = "";
            btnWijzig.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            medewerkerPagina MedewerkerPagina = new medewerkerPagina();
            MedewerkerPagina.Show();
            this.Hide();
        }

        private void lbxKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxKlanten.SelectedIndex >= 0)
            {
                txtVoornaam.ReadOnly = false;
                txtAchternaam.ReadOnly = false;
                txtAdress.ReadOnly = false;
                txtPostcode.ReadOnly = false;
                txtStad.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtTelefoon.ReadOnly = false;
                btnWijzig.Enabled = true;

                Klanten geselecteerdeKlant = klantenList[lbxKlanten.SelectedIndex];
                txtVoornaam.Text = geselecteerdeKlant.Firstname;
                txtAchternaam.Text = geselecteerdeKlant.Lastname;
                txtAdress.Text = geselecteerdeKlant.Address;
                txtPostcode.Text = geselecteerdeKlant.Zipcode;
                txtStad.Text = geselecteerdeKlant.City;
                txtEmail.Text = geselecteerdeKlant.Email;
                txtTelefoon.Text = geselecteerdeKlant.Phone;
            }
        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            if (lbxKlanten.SelectedIndex < 0)
            {
                MessageBox.Show("Selecteer eerst een klant om te wijzigen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVoornaam.Text))
            {
                MessageBox.Show("Voornaam mag niet leeg zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAchternaam.Text))
            {
                MessageBox.Show("Achternaam mag niet leeg zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdress.Text))
            {
                MessageBox.Show("Adres mag niet leeg zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPostcode.Text))
            {
                MessageBox.Show("Postcode mag niet leeg zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStad.Text))
            {
                MessageBox.Show("Stad mag niet leeg zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("E-mail mag niet leeg zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("E-mail is niet geldig.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefoon.Text))
            {
                MessageBox.Show("Telefoonnummer mag niet leeg zijn.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!txtTelefoon.Text.All(char.IsDigit))
            {
                MessageBox.Show("Telefoonnummer mag alleen cijfers bevatten.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Klanten geselecteerdeKlant = klantenList[lbxKlanten.SelectedIndex];
            geselecteerdeKlant.Firstname = txtVoornaam.Text.Trim();
            geselecteerdeKlant.Lastname = txtAchternaam.Text.Trim();
            geselecteerdeKlant.Address = txtAdress.Text.Trim();
            geselecteerdeKlant.Zipcode = txtPostcode.Text.Trim();
            geselecteerdeKlant.City = txtStad.Text.Trim();
            geselecteerdeKlant.Email = txtEmail.Text.Trim();
            geselecteerdeKlant.Phone = txtTelefoon.Text.Trim();

            try
            {
                int klantId = geselecteerdeKlant.Id;
                geselecteerdeKlant.Update();
                LoadKlanten(klantId);
                MessageBox.Show("Klantgegevens succesvol bijgewerkt!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het bijwerken van de klant: {ex.Message}", "Databasefout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            lbxKlanten.ClearSelected();
            Deselect();
        }
    }
}
