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
        private string atualCalculo = "";  
        public Valor2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            atualCalculo += (sender as Button).Text;
            txt.Text = atualCalculo;
        }
        private void button_Equals_click(object sender, EventArgs e)
        {
            string formatodeCalculo = atualCalculo.ToString();
            try
            {
                var resultado = new DataTable().Compute(formatodeCalculo, null).ToString();
                formatodeCalculo = txt.Text;
            }
            catch (Exception)
            {
                txt.Text = "ERROR";
                atualCalculo = "";
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            atualCalculo = "";
            txt.Text = "0";
        }
        private void button_clearEnter_Click(object sender, EventArgs e)
        {
            if (atualCalculo.Length > 0)
            {
                atualCalculo = atualCalculo.Remove(atualCalculo.Length - 1, 1);

            }
            txt.Text = atualCalculo;
        }
        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void botao20_Click(object sender, EventArgs e)
        {

           

        }

        private void botao17_Click(object sender, EventArgs e)
        {

        }

        private void numeroSalvo_Click(object sender, EventArgs e)
        {

        }

        private void numeroDigitado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botao18_Click(object sender, EventArgs e)
        {

        }

        private void botao24_Click(object sender, EventArgs e)
        {

        }

        private void botao3_Click(object sender, EventArgs e)
        {

        }

        private void botao19_Click(object sender, EventArgs e)
        {

        }

        private void botao13_Click(object sender, EventArgs e)
        {

        }

        private void botao14_Click(object sender, EventArgs e)
        {

        }

        private void botao15_Click(object sender, EventArgs e)
        {

        }

        private void botao9_Click(object sender, EventArgs e)
        {

        }

        private void botao10_Click(object sender, EventArgs e)
        {

        }

        private void botao11_Click(object sender, EventArgs e)
        {

        }

        private void botao22_Click(object sender, EventArgs e)
        {

        }

        private void botao16_Click(object sender, EventArgs e)
        {

        }

        private void histNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}