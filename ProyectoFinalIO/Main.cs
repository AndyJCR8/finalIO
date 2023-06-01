﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simplex simplex = new Simplex();
            simplex.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CostoMinimo costoMinimo = new CostoMinimo();
            costoMinimo.ShowDialog();
        }
    }
}
