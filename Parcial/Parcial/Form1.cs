using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {

        }

    }

    namespace Parcial1
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
            }

            private double[][] tablaImpuesto = {
            new double[] {0.01, 500, 1.5, 0},
            new double[] {500.01, 1000, 1.5, 3},
            new double[] {1000.01, 2000, 3, 3},
            new double[] {2000.01, 3000, 6, 3},
            new double[] {3000.01, 6000, 9, 2},
            new double[] {8000.01, 18000, 15, 2},
            new double[] {18000.01, 30000, 39, 2},
            new double[] {30000.01, 60000, 63, 1},
            new double[] {60000.01, 100000, 93, 0.8},
            new double[] {100000.01, 200000, 125, 0.7},
            new double[] {200000.01, 300000, 195, 0.6},
            new double[] {300000.01, 400000, 255, 0.45},
            new double[] {400000.01, 500000, 300, 0.4},
            new double[] {500000.01, 1000000, 340, 0.30},
            new double[] {1000000.01, 99999999, 490, 0.18}
        };
            private object lblImpuestoActividad;
            private object txtActividad;

            // Método que calcula el impuesto según el monto
            private double calcularImpuestoActividad(double monto)
            {
                double impuesto = 0;
                for (int i = 0; i < tablaImpuesto.Length; i++)
                {
                    if (monto >= tablaImpuesto[i][0] && monto <= tablaImpuesto[i][1])
                    {
                        impuesto = ((monto - tablaImpuesto[i][0]) / 1000 * tablaImpuesto[i][3]) + tablaImpuesto[i][2];
                    }
                }
                return impuesto;
            }

            // Evento del botón
            private void btnCalcular_Click(object sender, EventArgs e)
            {
                double montoActividad = 0, impuesto = 0;

                try
                {
                    montoActividad = double.Parse(txtActividad.Text);
                    impuesto = calcularImpuestoActividad(montoActividad);

                    lblImpuestoActividad.Text = "Impuesto a pagar: " + impuesto.ToString("C2");
                }
                catch (Exception)
                {
                    MessageBox.Show("Por favor ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
