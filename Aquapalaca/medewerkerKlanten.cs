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
    public partial class medewerkerKlanten : Form
    {
        public medewerkerKlanten()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medewerkerPagina MedewerkerPagina = new medewerkerPagina();
            MedewerkerPagina.Show();
            this.Hide();
        }
    }
}
