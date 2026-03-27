using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.Rows.Add();

            dataGridView1.Rows[num].Cells[0].Value = textBoxName.Text;
            dataGridView1.Rows[num].Cells[1].Value = textBoxLastName.Text;
            dataGridView1.Rows[num].Cells[2].Value = textBoxGrade.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
