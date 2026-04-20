using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16RichTExtBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBoxUrl.Text);
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonDetener_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();  
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
