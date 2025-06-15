using System;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        string operador = "";
        bool nuevoNumero = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "";
                nuevoNumero = false;
            }

            Button btn = (Button)sender;
            txtPantalla.Text += btn.Text;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out num1))
            {
                Button btn = (Button)sender;
                operador = btn.Text;
                nuevoNumero = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double num2;
            if (double.TryParse(txtPantalla.Text, out num2))
            {
                double resultado = 0;

                switch (operador)
                {
                    case "+": resultado = num1 + num2; break;
                    case "-": resultado = num1 - num2; break;
                    case "*": resultado = num1 * num2; break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                            MessageBox.Show("No se puede dividir por cero");
                        break;
                }

                txtPantalla.Text = resultado.ToString();
                nuevoNumero = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            num1 = 0;
            operador = "";
            nuevoNumero = false;
        }
    }
}
