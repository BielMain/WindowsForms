using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbInvestimento_Click(object sender, EventArgs e)
        {

        }

        private void rbInvestimento_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacao.Text = "Investimento";
            lblOperacao.ForeColor = Color.Blue;
           
        }

        private void rbDivida_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacao.Text = "Divida";
            lblOperacao.ForeColor = Color.Red;

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double result, diferencial;
            double valor = Convert.ToDouble(txbValor.Text);
            double porcentagem = Convert.ToDouble(txbPorcentagem.Text);

            diferencial = (valor * porcentagem) / 100.00;
            if (rbInvestimento.Checked == true) {
                result = valor + diferencial;
                txbResultado.Text = result.ToString();
            }
            else if (rbDivida.Checked == true)
            {
                result = valor - diferencial;
                txbResultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Operação não selecionada", "Erro");
            }
        }
    }
}
