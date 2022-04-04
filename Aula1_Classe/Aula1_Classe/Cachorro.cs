using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Classe
{
    class Cachorro
    {
        public String   nome;
        public String   raca;
        public int      idade;
        public float    peso;

        public void Latir()
        {

            Console.WriteLine($"{nome} está latindo.");

        }

        public void AbanarRabo()
        {

            Console.WriteLine($"{nome} está abando o rabo");

        }

    }
}
