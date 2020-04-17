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
    public partial class calculadora : Form
    {
        private double primeiroValor;
        private double segundoValor;
        private double Resultado;


        
        public calculadora()
        {
            InitializeComponent();
        }

        private void botaoSomar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPValor.Text) || string.IsNullOrWhiteSpace(txtSValor.Text))
            {
                MessageBox.Show("Informe os Valores");
                return;
            }

            String X = " ";
                primeiroValor = Convert.ToDouble(txtPValor.Text);
                segundoValor = Convert.ToDouble(txtSValor.Text);
                Resultado = primeiroValor + segundoValor;

                X = Convert.ToString(Resultado);
                txtResultado.Text = X;

                LimparValores();
            
        }

        protected void LimparValores()
        {
            txtPValor.Clear();
            txtSValor.Clear();

            txtPValor.Focus();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPValor.Text) || string.IsNullOrWhiteSpace(txtSValor.Text))
            {
                MessageBox.Show("Informe os Valores");
                return;
            }

            String X = " ";
            primeiroValor = Convert.ToDouble(txtPValor.Text);
            segundoValor = Convert.ToDouble(txtSValor.Text);
            Resultado = primeiroValor - segundoValor;

            X = Convert.ToString(Resultado);
            txtResultado.Text = X;

            LimparValores();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPValor.Text) || string.IsNullOrWhiteSpace(txtSValor.Text))
            {
                MessageBox.Show("Informe os Valores");
                return;
            }

            String X = " ";
            primeiroValor = Convert.ToDouble(txtPValor.Text);
            segundoValor = Convert.ToDouble(txtSValor.Text);
            Resultado = primeiroValor * segundoValor;

            X = Convert.ToString(Resultado);
            txtResultado.Text = X;

            LimparValores();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPValor.Text) || string.IsNullOrWhiteSpace(txtSValor.Text))
            {
                MessageBox.Show("Informe os Valores");
                return;
            }

            String X = " ";
            primeiroValor = Convert.ToDouble(txtPValor.Text);
            segundoValor = Convert.ToDouble(txtSValor.Text);
            Resultado = primeiroValor / segundoValor;

            X = Convert.ToString(Resultado);
            txtResultado.Text = X;

            LimparValores();
        }
    }
}
