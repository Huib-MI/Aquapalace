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
    }
}
