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
        List<List<double>> Data = new List<List<double>>();
        List<TextBox> textBoxes = new List<TextBox>();

        public Simplex()
        {
            InitializeComponent();
        }

        private void Simplex_Load(object sender, EventArgs e)
        {
            textBoxes.Add(txtbX1);
            textBoxes.Add(txtbX2);
            textBoxes.Add(txtbX3);

            textBoxes.Add(txtbEc1X1);
            textBoxes.Add(txtbEc1X2);
            textBoxes.Add(txtbEc1X3);

            textBoxes.Add(txtbEc2X1);
            textBoxes.Add(txtbEc2X2);
            textBoxes.Add(txtbEc2X3);

            textBoxes.Add(txtbEc3X1);
            textBoxes.Add(txtbEc3X2);
            textBoxes.Add(txtbEc3X3);
        }                        
                                 
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //FILAS
            for(int x = 0; x < 4; x++) Data.Add(new List<double>());
            int cont = 0;
            
            for(int x = 0; x < textBoxes.Count - 1; x++)
            {
                double value = Convert.ToDouble(textBoxes[x].Text);
                Data[cont].Add(value);
                if ((x + 1) % 3 == 0) cont++;
            }
        }

        private void FindColumnAndRow()
        {

        }

    }
}
