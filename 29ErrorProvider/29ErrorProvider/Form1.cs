using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = true;
            if (error)
            {
                //errorProvider1.SetError(textBox1, "Hay un error en este campo");
                errorProvider1.SetError(progressBar1, "Hay un error en este campo");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
