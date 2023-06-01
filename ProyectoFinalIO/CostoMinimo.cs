using PruebaCostoMinimo;
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
    public partial class CostoMinimo : Form
    {
        CostoMinimoClass obj = new CostoMinimoClass();

        public CostoMinimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> fuentes = new List<string>() { "planta 1", "planta 2", "planta 3", "planta 4" };
            List<decimal> ofertas = new List<decimal>() { 80, 30, 60, 45 };

            List<string> destinos = new List<string>() { "cali", "bogota", "medellin", "barranquilla" };
            List<decimal> demandas = new List<decimal>() { 70, 40, 70, 35 };

            List<List<decimal>> costos = new List<List<decimal>>
            {
                new List<decimal>() {5, 2, 7, 3},
                new List<decimal>() {3, 6, 6, 1},
                new List<decimal>() {6, 1, 2, 4},
                new List<decimal>() {4, 3, 6, 6}
            };
            string unidadesTransporte = "camiones";
            string monedaUtilizada = "Q";

            MessageBox.Show(obj.calcular(costos, fuentes, ofertas, destinos, demandas, unidadesTransporte, monedaUtilizada));
        }
    }
}
