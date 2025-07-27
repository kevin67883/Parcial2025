namespace Saludos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "¡Hola, " + txtombre.Text + "!";
        }
    }
}
