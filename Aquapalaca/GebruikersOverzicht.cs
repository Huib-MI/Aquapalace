using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class GebruikersOverzicht : Form
    {
        public GebruikersOverzicht()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            beheerPagina BeheerPagina = new beheerPagina();
            BeheerPagina.Show();
            this.Hide();
        }

        private void btnOphalen_Click(object sender, EventArgs e)
        {
            lbxOverzicht.Items.Clear();
            foreach (Gebruiker gebruikerobject in Gebruiker.getGebruikers())
            {
                lbxOverzicht.Items.Add(gebruikerobject);
            }
        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            string rol = cbxRol.Text;

            Gebruiker gebruikerobject = ((Gebruiker)lbxOverzicht.SelectedItem);
            gebruikerobject.Rol = rol;

            gebruikerobject.wijzigen();
            MessageBox.Show("Gewijzigd");
            txtWijzigen.Clear();
        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gebruiker gebruikerobject = ((Gebruiker)lbxOverzicht.SelectedItem);
            txtWijzigen.Text = gebruikerobject.Rol;
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GebruikersOverzicht_Load(object sender, EventArgs e)
        {
            foreach(Gebruiker gebobj in Gebruiker.OphalenDropDown())
            {
                cbxRol.Items.Add(gebobj.Rol.ToString());
            }
        }
    }
}
