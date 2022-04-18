using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploEncapsulamento
{
    class Cachorro
    {
        string nome;
        string raca;
        int idade;

        public string Nome
        {
            get;set;
        }

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public Cachorro(string nome, string raca, int idade)
        {
            this.Nome = nome;
            this.Raca = raca;
            this.Idade = idade;
        }


        

        

    }
}
