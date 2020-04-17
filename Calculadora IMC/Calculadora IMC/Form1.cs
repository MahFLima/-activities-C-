using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        private double peso;
        private double altura;
        private string resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Digite o Peso");
            }

            if (string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                MessageBox.Show("Digite a Altura");
            }

            peso = TrySetValue(txtPeso.Text, "Peso");
            altura = TrySetValue(txtAltura.Text, "Altura");

            double imc = CalcularIMC(peso, altura);
            SetResultado(imc);

        }

        private static double CalcularIMC(double peso, double altura) 
            => (peso / (altura * altura));

        private static double TrySetValue(string textValue, string componentName)
        {
            double result = 0;

            try
            {
                textValue = textValue.Replace(".", ",");
                result = Convert.ToDouble(textValue);
            }
            catch (Exception)
            {
                MessageBox.Show($"Valor inválido para o campo {componentName}!");
                return result;
            }

            return result;
        }

        private void SetResultado(double imc)
        {
            String X = " ";  
            if (imc <= 18.5)
                resultado = "Abaixo do peso!";
            else if (imc > 18.5 && imc <= 24.9)
                resultado = "Peso normal!";
            else if (imc > 24.9 && imc <= 29.9)
                resultado = "Sobrepeso!";
            else if (imc > 29.9 && imc <= 34.9)
                resultado = "Obesidade grau 1!";
            else if (imc > 34.9 && imc <= 39.9)
                resultado = "Obesidade grau 2!";
            else if (imc > 39.9)
                resultado = "Obesidade mórbida!";

            labelResultado.Text = resultado;
            X = Convert.ToString(imc);
            labelIMC.Text = X;
        }

    }
}
