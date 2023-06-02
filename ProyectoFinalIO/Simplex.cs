using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalIO
{
    public partial class Simplex : Form
    {
        public Simplex()
        {
            InitializeComponent();
        }

        private void txtbKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
