using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3_GerePessoas
{
    class Pessoa
    {
        private string nome;
        private string morada;
        private int pontuacao;
        private DateTime DataNascimento;


        public Pessoa(string nomePessoa, DateTime dataNascimento, string moradaPessoa)
        {
            this.nome = nomePessoa;
            this.DataNascimento = dataNascimento;
            this.morada = moradaPessoa;
            this.pontuacao = 0;
        }

        public void Pontuar()
        {
            pontuacao = pontuacao + 1;
        }


        public int idade()
        {

            int idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                idade--;
                //MessageBox.Show("Idade invalida");

            }

            return idade;
        }

        public override string ToString()
        {
            return nome + " " + this.idade() + ": " + this.pontuacao;
        }

    }
}
