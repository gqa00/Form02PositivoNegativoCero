namespace Form02PositivoNegativoCero
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

        private void button1_Click(object sender, EventArgs e)
        {
            //capturamos el numero de la caja de texto
            int numero = int.Parse(this.txtNumero.Text);
            //preguntamos las opciones del programa. positivo negativo o ceor
            if (numero > 0)
            {
                this.lblResultado.Text = "POSITIVO";
            }
            else if (numero < 0)
            {
                this.lblResultado.Text = "NEGATIVO";
            }
            else
            {
                this.lblResultado.txt = "CERO";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
