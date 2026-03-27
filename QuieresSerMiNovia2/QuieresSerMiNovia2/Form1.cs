using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuieresSerMiNovia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelQuieresSer.Parent = pictureBox1;
            labelSiempreSupe.Parent = pictureBox2;
            panel2.Hide();
            buttonSi.TabStop = false;
            buttonNo.TabStop = false;
        }
        public void MoverBoton()
        {
            Random r=new Random();
            int x=r.Next(0,this.Width-buttonNo.Width);
            int y=r.Next(0,this.Height-buttonNo.Height);
            buttonNo.Location = new Point(x,y);
        }

        private void buttonNo_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if(buttonNo.Location==buttonSi.Location || buttonNo.Location==labelQuieresSer.Location)
            {
                MoverBoton();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void AceptarSiAcepto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
