using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aquapalaca
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public string tb1;
        string voornaam = "";
        string achternaam = "";
        public Form1()
        {
            InitializeComponent();
            Instance = this;

        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            string gebruikersnaam = txtGebruikersnaam.Text;
            string wachtwoord = txtWachtwoord.Text;


            Gebruiker gebruikersobject = Gebruiker.getLoginGebruiker(gebruikersnaam, wachtwoord);
            if (gebruikersobject != null)
            {
                Session.HuidigeGebruiker = gebruikersobject;
                if (gebruikersobject.Rol == "gast")
                {
                    KlantPagina klantPagina = new KlantPagina();
                    klantPagina.Show();
                    this.Hide();
                }
                else if (gebruikersobject.Rol == "beheerder")
                {
                    beheerPagina BeheerPagina = new beheerPagina();
                    BeheerPagina.Show();
                    this.Hide();
                }
                else if (gebruikersobject.Rol == "medewerker")
                {
                    medewerkerPagina MedewerkerPagina = new medewerkerPagina();
                    MedewerkerPagina.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Ongeldige login");
                txtGebruikersnaam.Clear();
                txtWachtwoord.Clear();
            }

           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaakRondeHoeken(pictureBox1, 20);
            RondButton(btnInloggen, 20);
            string hashedpassword = BCrypt.Net.BCrypt.HashPassword("Welkom123");
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MaakRondeHoeken(PictureBox pb, int radius)
        {
            GraphicsPath pad = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pb.Width, pb.Height);

            int diameter = radius * 2;

            // Boven-links
            pad.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Boven-rechts
            pad.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Onder-rechts
            pad.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Onder-links
            pad.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            pad.CloseFigure();

            pb.Region = new Region(pad);
        }

        private void RondButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
