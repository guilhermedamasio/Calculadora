using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Valor2 : Form
    {
        public Valor2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void soma_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void botao20_Click(object sender, EventArgs e)
        {
            histNum1.Text = numeroDigitado1.Text + " + ";
            double primeiroNumero = Convert.ToDouble(numeroDigitado1.Text);


            numeroDigitado1.Text = "";
           

        }

        private void botao17_Click(object sender, EventArgs e)
        {
            numeroDigitado1.Text = numeroDigitado1.Text + "1";
            if (numeroDigitado1.Text == "" && histNum1.Text != null)
            {
                numeroDigitado1.Text = numeroDigitado1.Text + "1";
            }
        }

        private void numeroSalvo_Click(object sender, EventArgs e)
        {

        }

        private void numeroDigitado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botao18_Click(object sender, EventArgs e)
        {
            numeroDigitado1.Text = numeroDigitado1.Text + "2";
            if (numeroDigitado1.Text == "" && histNum1.Text != null)
            {
                numeroDigitado1.Text = numeroDigitado1.Text + "2";
            }
        }

        private void botao24_Click(object sender, EventArgs e)
        {
            if (histNum1.Text != null && numeroDigitado1.Text != "")
            {
                double segundoNumero = Convert.ToDouble(numeroDigitado1.Text);
                double resultado = Convert.ToDouble(histNum1.Text.Split(' ')[0]) + segundoNumero;
                numeroDigitado1.Text = resultado.ToString();
                histNum1.Text = "";
            }
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            numeroDigitado1.Text = "";
            histNum1.Text = "";
        }
    }
}