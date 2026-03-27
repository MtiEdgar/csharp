using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoBiseccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            double error = 0.01;
            double margenError = 1.0;
            double limiteSuperior = double.Parse(txt_limSuper.Text);
            double limiteInferior = double.Parse(txt_limInfer.Text);
            int iteraciones = 0;
            double valorMedio = 0;

            while (margenError > error && iteraciones < 1000)
            {
                valorMedio = (limiteInferior + limiteSuperior) / 2;

                double fInferior = limiteInferior * limiteInferior - 2;  // f(x) = x² - 2
                double fMedio = valorMedio * valorMedio - 2;
                double fSuperior = limiteSuperior * limiteSuperior - 2;

                // Verificar si encontramos la raíz exacta
                if (fMedio == 0)
                {
                    margenError = 0;
                    break;
                }

                // El núcleo del método de bisección:
                if (fInferior * fMedio < 0)  // La raíz está en [inferior, medio]
                {
                    limiteSuperior = valorMedio;
                }
                else  // La raíz está en [medio, superior]
                {
                    limiteInferior = valorMedio;
                }

                margenError = Math.Abs(limiteSuperior - limiteInferior);
                iteraciones++;
            }

            double raiz = (limiteInferior + limiteSuperior) / 2;
            txt_solucion.Text = raiz.ToString("F6");
        }
    }
}
