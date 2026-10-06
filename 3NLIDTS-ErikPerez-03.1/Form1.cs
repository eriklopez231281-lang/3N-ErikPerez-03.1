namespace _3NLIDTS_ErikPerez_03._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el usuario elige convertir desde Celsius
                if (rdbCelsius.Checked)
                {
                    double celsius = Convert.ToDouble(txtCelsius.Text);
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    double kelvin = celsius + 273.15;

                    txtFahrenheit.Text = fahrenheit.ToString("0.00");
                    txtKelvin.Text = kelvin.ToString("0.00");
                }
                // Si el usuario elige convertir desde Fahrenheit
                else if (rdbFahrenheit.Checked)
                {
                    double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    double kelvin = celsius + 273.15;

                    txtCelsius.Text = celsius.ToString("0.00");
                    txtKelvin.Text = kelvin.ToString("0.00");
                }
                // Si el usuario elige convertir desde Kelvin
                else if (rdbKelvin.Checked)
                {
                    double kelvin = Convert.ToDouble(txtKelvin.Text);
                    double celsius = kelvin - 273.15;
                    double fahrenheit = (celsius * 9 / 5) + 32;

                    txtCelsius.Text = celsius.ToString("0.00");
                    txtFahrenheit.Text = fahrenheit.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una opción (Celsius, Fahrenheit o Kelvin).", "Aviso");
                }
            }
            catch (FormatException)
            {
                // Esto evita que el programa se cierre si el usuario escribe letras en lugar de números
                MessageBox.Show("Por favor, ingresa un valor numérico válido.", "Error de formato");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Borrar el contenido de las cajas de texto
            txtCelsius.Clear();
            txtFahrenheit.Clear();
            txtKelvin.Clear();

            // Restablecer los radio buttons
            rdbCelsius.Checked = false;
            rdbFahrenheit.Checked = false;
            rdbKelvin.Checked = false;

            // Colocar el cursor parpadeando en la primera caja
            txtCelsius.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }
    }
}
