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
            int valor1, valor2, resultado;
            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);
            resultado = valor1 + valor2;
            label3.Text = resultado.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}