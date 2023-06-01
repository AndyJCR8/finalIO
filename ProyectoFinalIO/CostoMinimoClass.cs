using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCostoMinimo
{
    public class CostoMinimoClass
    {
        public CostoMinimoClass() { }

        List<int> indiceMinMaxVal(List<List<decimal>> matriz, bool min)
        {
            List<int> indice = new List<int>();
            indice.Add(0);
            indice.Add(0);


            for (int fila = 0; fila < matriz.Count; fila++)
            {
                for (int columna = 0; columna < matriz[fila].Count; columna++)
                {
                    if (min)
                    {
                        if (matriz[fila][columna] < matriz[indice[0]][indice[1]])
                        {
                            indice.Clear();
                            indice.Add(fila);
                            indice.Add(columna);
                        }
                    }
                    else
                    {
                        if (matriz[fila][columna] > matriz[indice[0]][indice[1]])
                        {
                            indice.Clear();
                            indice.Add(fila);
                            indice.Add(columna);
                        }
                    }
                }
            }

            return indice;
        }

        public string calcular(List<List<decimal>> costos, List<string> fuentes, List<decimal> ofertas, List<string> destinos, List<decimal> demandas, string unidades, string moneda)
        {
            List<List<string>> asignaciones = new List<List<string>>();
            decimal total = 0, subt;

            List<int> indiceMaxVal = this.indiceMinMaxVal(costos, false);
            decimal maxValP1 = costos[indiceMaxVal[0]][indiceMaxVal[1]] + 1;

            while (ofertas.Sum() != 0 && demandas.Sum() != 0)
            {
                List<int> minValIndice = this.indiceMinMaxVal(costos, true);
                //MessageBox.Show(minValIndice[0] + ", " + minValIndice[1]);

                if (demandas[minValIndice[1]] < ofertas[minValIndice[0]])
                {
                    subt = costos[minValIndice[0]][minValIndice[1]] * demandas[minValIndice[1]];
                    asignaciones.Add(new List<string>() { "(" + minValIndice[0] + ", " + minValIndice[1] + ")", demandas[minValIndice[1]] + " " + unidades + " de " + fuentes[minValIndice[0]] + " a " + destinos[minValIndice[1]] + " con un costo unitario de " + moneda + costos[minValIndice[0]][minValIndice[1]] + " y un subtotal de " + moneda + subt });
                    //MessageBox.Show(demandas[minValIndice[1]] + "");
                    ofertas[minValIndice[0]] -= demandas[minValIndice[1]];
                    demandas[minValIndice[1]] = 0;

                    for (int fila = 0; fila < costos.Count; fila++)
                    {
                        costos[fila][minValIndice[1]] = 0;
                        costos[fila][minValIndice[1]] += maxValP1;
                    }
                }
                else
                {
                    subt = costos[minValIndice[0]][minValIndice[1]] * ofertas[minValIndice[0]];
                    asignaciones.Add(new List<string>() { "(" + minValIndice[0] + ", " + minValIndice[1] + ")", ofertas[minValIndice[0]] + " " + unidades + " de " + fuentes[minValIndice[0]] + " a " + destinos[minValIndice[1]] + " con un costo unitario de " + moneda + costos[minValIndice[0]][minValIndice[1]] + " y un subtotal de " + moneda + subt });
                    demandas[minValIndice[1]] -= ofertas[minValIndice[0]];
                    ofertas[minValIndice[0]] = 0;

                    for (int columna = 0; columna < costos[0].Count; columna++)
                    {
                        costos[minValIndice[0]][columna] = 0;
                        costos[minValIndice[0]][columna] += maxValP1;
                    }
                }
                total += subt;
            }

            string msg = "";

            for (int fila = 0; fila < asignaciones.Count; fila++)
            {
                for (int columna = 0; columna < asignaciones[fila].Count; columna++)
                {
                    msg += asignaciones[fila][columna] + "\t";
                }

                msg += "\n";
            }

            msg += "Total: " + moneda + total;

            return msg;
        }
    }
}
