using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Unidades y equivalencias en metros cuadrados
        string[] unidades = { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea" };
        double[] valores = { 0.092903, 0.705012, 0.836127, 1.0, 628.86, 6970, 10000 };

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    lblRespuesta.Text = "Ingrese un valor";
                    return;
                }
                if (cboDe.SelectedIndex == -1 || cboA.SelectedIndex == -1)
                {
                    lblRespuesta.Text = "Seleccione ambas unidades";
                    return;
                }

                // Usar TryParse para evitar excepciones en números mal escritos
                if (!double.TryParse(txtValor.Text, out double valor))
                {
                    lblRespuesta.Text = "Error: ingrese solo números válidos";
                    return;
                }

                int de = cboDe.SelectedIndex;
                int a = cboA.SelectedIndex;

                double resultado = valor * valores[de] / valores[a];
                lblRespuesta.Text = $"RESPUESTA: {resultado:N4}";
            }
            catch (Exception)
            {
                lblRespuesta.Text = "Error inesperado";
            }
        }
    }
}