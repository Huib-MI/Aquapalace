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
    }
}
