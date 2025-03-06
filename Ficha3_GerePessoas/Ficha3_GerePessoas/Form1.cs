using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha3_GerePessoas
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            if (nome == "")
            {
                MessageBox.Show("nome inv");
                return;
            }

            DateTime dataNascimento = monthCalendar1.SelectionStart;

            if (dataNascimento > DateTime.Now)
            {
                MessageBox.Show("idade inv");
                return;
            }

            string morada = textBox2.Text;
            if (morada == "")
            {
                MessageBox.Show("morada inv");
                return;

            }

            listBox1.Items.Add(new Pessoa(nome, dataNascimento, morada));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa x = (Pessoa)listBox1.SelectedItem;
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("selecione uma pessoa");
                // return;
            }
            else
            {
                x.Pontuar();
                listBox1.Items[listBox1.SelectedIndex] = x;
            }

        }
    }
}
