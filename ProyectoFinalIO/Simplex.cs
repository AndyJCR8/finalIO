using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') == 0))
                e.Handled = true;
        }

        private double[,] ObtenerMatrizRestricciones()
        {
            List<List<double>> matrizRestricciones = new List<List<double>>();

            foreach (DataGridViewRow row in dgvEcuaciones.Rows)
            {
                if(dgvEcuaciones.Rows.Count - 1 == row.Index) break;

                matrizRestricciones.Add(new List<double>());
                
                int x1 = Convert.ToInt32(row.Cells["coefX1"].Value);
                int x2 = Convert.ToInt32(row.Cells["coefX2"].Value);
                int x3 = Convert.ToInt32(row.Cells["coefX3"].Value);
                int r = Convert.ToInt32(row.Cells["coefRes"].Value);

                matrizRestricciones.Last().Add(x1);
                matrizRestricciones.Last().Add(x2);
                matrizRestricciones.Last().Add(x3);
                matrizRestricciones.Last().Add(r);
            }

            int filas = matrizRestricciones.Count, columnas = matrizRestricciones[0].Count;

            double[,] res = new double[filas, columnas];
            for(int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    res[x, y] = matrizRestricciones[x][y];
                }
            }
         
            return res;
        }

        private string ArgumentosPython(double[] coeficientes, double[,] matrizRestricciones, string tipoOptimizacion)
        {
            // Construir la cadena de texto con los argumentos que se pasarán al script de Python
            // Puedes utilizar un formato específico, como CSV, para facilitar el procesamiento en Python

            string argumentos = $"{string.Join(",", coeficientes)}";

            for (int i = 0; i < matrizRestricciones.GetLength(0); i++)
            {
                string fila = "";
                for (int j = 0; j < matrizRestricciones.GetLength(1); j++)
                {
                    //MessageBox.Show($"M[{i}, {j}]: {matrizRestricciones[i, j]}");

                    fila += matrizRestricciones[i, j].ToString();
                    if (j < matrizRestricciones.GetLength(1) - 1)
                        fila += ",";
                }

                argumentos += $" {fila}";
            }

            argumentos += $" {tipoOptimizacion}";
            //MessageBox.Show($"Argumentos:{argumentos}");
            return argumentos;
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            string resourcesFolder = Path.Combine(projectDirectory, "Resources");
            // Obtener los datos ingresados por el usuario
            double[] coeficientes = { Double.Parse(txtbX1.Text), Double.Parse(txtbX2.Text), Double.Parse(txtbX3.Text) };

            try
            {
                double[,] matrizRestricciones = ObtenerMatrizRestricciones();
                //MessageBox.Show($"ScriptPath: {Path.Combine(resourcesFolder, "simplexScript.py") + ArgumentosPython(coeficientes, matrizRestricciones, rbMaximizacion.Checked ? "max" : "min")}");
                // Crear una instancia de ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "python", // Ruta al ejecutable de Python
                    Arguments = Path.Combine(resourcesFolder, "simplexScript.py ") + ArgumentosPython(coeficientes, matrizRestricciones, rbMaximizacion.Checked ? "max" : "min"),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Crear el proceso
                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;

                    // Iniciar el proceso
                    process.Start();

                    // Leer la salida del proceso
                    string resultadoPython = process.StandardOutput.ReadToEnd();

                    // Actualizar la interfaz con los resultados
                    //MostrarResultados(resultadoPython);
                    //MessageBox.Show($"resPython: {resultadoPython}");
                    lblResult.Text = "Resultado:" + resultadoPython.Split(':')[1];
                }
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }


    }
}
