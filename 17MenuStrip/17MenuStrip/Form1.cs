using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Esto deberia activar una nueva ventana";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Esto deberia mostrar las opciones para abrir un archivo";
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Esto va a cerrar algo";
        }
    }
}
