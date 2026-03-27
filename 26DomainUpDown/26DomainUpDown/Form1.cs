using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26DomainUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            domainUpDown1.Items.Add("México");
            domainUpDown1.Items.Add("Estados unidos");
            domainUpDown1.Items.Add("Canada");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            string pais = (string) domainUpDown1.SelectedItem;
            label1.Text=string.Format("El mejor pais del mundo {0}",pais);
        }
    }
}
