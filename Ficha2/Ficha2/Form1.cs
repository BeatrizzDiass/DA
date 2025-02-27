using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);

        }

        private DateTime contadorTempo;

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
            contadorTempo = contadorTempo.AddMilliseconds(10);
            toolStripStatusLabelContador.Text = contadorTempo.ToString("HH:mm:ss:fff");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                button1.Text = "Ativar";
            }
            else
            {
                button1.Text = "Parar";
            }

            timer1.Enabled = !timer1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorTempo = new DateTime(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(toolStripStatusLabelHora.Text + "@" + toolStripStatusLabelContador.Text);
        }
    }
}
