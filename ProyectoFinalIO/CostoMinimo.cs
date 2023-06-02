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
        private List<decimal> demandas;
        private List<decimal> ofertas;
        private List<List<decimal>> costos;
        private List<string> fuentes;
        private List<string> destinos;
        private string unidadesTransporte;
        private string monedaUtilizada;

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

        private void CostoMinimo_Load(object sender, EventArgs e)
        {
            lblOferta.Visible = false;
            dgvEcuaciones.Visible = false;
            btnCalcular.Visible = false;
            lblResultado.Visible = false;
            button1.Visible = false;
            lblResultado.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt16(txtbX1.Text) + 1;
            lblOferta.Visible = true;
            dgvEcuaciones.Visible = true;
            btnCalcular.Visible = true;
            lblResultado.Visible = true;

            fuentes = new List<string>(); // Declarar la lista fuera del bucle
            destinos = new List<string>();
            int filas = cant + 1; 
            int columnas = cant + 1;

            dgvEcuaciones.AllowUserToAddRows = false; // Desactiva la opción de agregar filas manualmente
            dgvEcuaciones.RowCount = filas; // Establece el número de filas del DataGridView
            dgvEcuaciones.ColumnCount = columnas; // Establece el número de columnas del DataGridView

            for (int i = 0; i < cant; i++)
            {
                fuentes.Add("planta " + (i + 1)); // Agregar elementos a la lista
                destinos.Add("destino " + (i + 1));
            }
            // Asigna los valores de los destinos en la primera fila
            for (int j = 1; j < columnas; j++)
            {
                dgvEcuaciones.Rows[0].Cells[j].Value = destinos[j - 1];
            }

            // Agrega "oferta" en la última celda de la primera fila
            dgvEcuaciones.Rows[0].Cells[columnas - 1].Value = "oferta";

            // Asigna los valores de las plantas en la misma columna (columna 0)
            for (int i = 0; i < cant; i++)
            {
                fuentes.Add("planta " + (i + 1));
                dgvEcuaciones.Rows[i + 1].Cells[0].Value = fuentes[i]; // Asigna el valor de la planta en la celda correspondiente
            }

            // Agrega "demanda" en la última celda de la primera columna
            dgvEcuaciones.Rows[filas - 1].Cells[0].Value = "demanda";

            unidadesTransporte = txtTransporte.Text;
            monedaUtilizada = txtMoneda.Text;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los datos del DataGridView y las listas
            demandas = new List<decimal>();
            ofertas = new List<decimal>();
            costos = new List<List<decimal>>();
            fuentes = new List<string>();
            destinos = new List<string>();

            // Recorrer el DataGridView para obtener los valores
            for (int i = 1; i < dgvEcuaciones.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dgvEcuaciones.Rows[i];
                List<decimal> fila = new List<decimal>();

                for (int j = 1; j < row.Cells.Count - 1; j++)
                {
                    DataGridViewCell cell = row.Cells[j];
                    fila.Add(Convert.ToDecimal(cell.Value));
                }

                costos.Add(fila);
            }

            for (int j = 1; j < dgvEcuaciones.Columns.Count - 1; j++)
            {
                DataGridViewCell cell = dgvEcuaciones.Rows[dgvEcuaciones.Rows.Count - 1].Cells[j];
                demandas.Add(Convert.ToDecimal(cell.Value));
            }

            for (int j = 1; j < dgvEcuaciones.Columns.Count - 1; j++)
            {
                DataGridViewCell cell = dgvEcuaciones.Rows[0].Cells[j];
                fuentes.Add(cell.Value + "");
            }

            for (int i = 1; i < dgvEcuaciones.Rows.Count - 1; i++)
            {
                DataGridViewCell cell = dgvEcuaciones.Rows[i].Cells[dgvEcuaciones.Columns.Count - 1];
                ofertas.Add(Convert.ToDecimal (cell.Value));
            }

            for (int i = 1; i < dgvEcuaciones.Rows.Count - 1; i++)
            {
                DataGridViewCell cell = dgvEcuaciones.Rows[i].Cells[0];
                destinos.Add(cell.Value + "");
            }

            unidadesTransporte = txtTransporte.Text;
            monedaUtilizada = txtMoneda.Text;


            string msg = "";

            for (int fila = 0; fila < 1; fila++)
            {
                for (int columna = 0; columna < fuentes.Count; columna++)
                {
                    msg += fuentes[columna] + "\t";
                }

                msg += "\n";
            }

            MessageBox.Show(msg);

            // Realizar los cálculos utilizando los datos obtenidos
            string resultado = obj.calcular(costos, fuentes, ofertas, destinos, demandas, unidadesTransporte, monedaUtilizada);

            // Mostrar el resultado en un MessageBox
            MessageBox.Show(resultado);

        }
    }
}
