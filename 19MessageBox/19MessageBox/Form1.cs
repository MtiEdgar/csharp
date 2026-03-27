using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola a quien me mando llamar, I am a message box");
            //MessageBox.Show("Hi there, I am a message box", "Titulo de la ventana del mensaje");
            MessageBox.Show("Hola ㄟ(≧◇≦)ㄏ", "Titulo", MessageBoxButtons.YesNoCancel);
        }
    }
}
