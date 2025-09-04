using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hacer un ejercicio en C# haciendo uso de matrices, estructuras de repeticion y condicionales, que 
            //determinar el sueldo neto a pagar a n empleado descartando las deduciones correspondientes de ley.
            //isss, afp, isr.
        }    //isss, afp, isr.

        Private double[][] tablaIsr =
        {
             new double[] {0,01, 472, 0, 0 },
             new double[] {472.01, 895.24, 0.10, 17.67 },
             new double[] {895.25, 2038.10, 0.20, 60 },
             new double[] {2038.11, 99999999, 0.30, 288.57 },

        }private double calcularDeducciones(double sueldo, double porcentaje)
            resturn sueldo *porcentaje;

        }

    }        private void brCalcular_Click(object sender, EventArgs e)

            double sueldo = 0; isss = 0, afp = 0, isr = 0, sueldoNeto = 0;
        sueldo = double.Parse(txtSueldo.Text);

        {

        }

}
