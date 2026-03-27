using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34Calculaodra
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;

        private int operacion;


        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Número 2
            calcDisplay.Text = calcDisplay.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Número 9
            calcDisplay.Text = calcDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //Numero 0
            calcDisplay.Text = calcDisplay.Text+"0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Numero 1
            calcDisplay.Text = calcDisplay.Text + "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Número 3
            calcDisplay.Text = calcDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // Número 4
            calcDisplay.Text = calcDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Número 5
            calcDisplay.Text = calcDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // Número 6
            calcDisplay.Text = calcDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // Número 7
            calcDisplay.Text = calcDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // Número 8
            calcDisplay.Text = calcDisplay.Text + "8";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Botón limpiar
            calcDisplay.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Botón Suma
            operacion = 1;
            valor1 = Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text="";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Botón Igual
            valor2=Convert.ToDouble(calcDisplay.Text);
            
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;

                case 2:
                    resultado = valor1 - valor2;
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    break;
                
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }


            calcDisplay.Text=resultado.ToString();  
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // Botón Resta
            operacion = 2;
            valor1 =Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            // Botón Multipicación
            operacion=3;
            valor1=Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // Botón División
            operacion = 4;
            valor1 = Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Botón . (punto)
            calcDisplay.Text = calcDisplay.Text + ".";
        }
    }
}
