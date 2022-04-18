using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exercicio2
{
    class Minivan: Carro
    {

        private int assentos;

        public Minivan(int assentos,string modelo, string cor, float velocidadeMaxima):base(modelo,cor,velocidadeMaxima)
        {
            this.assentos = assentos;
        }

        public int Assentos
        {
            get
            {
                return assentos;
            }
        }
        public override string MostrarDetalhes()
        {
            return $"Posue {assentos} lugares";
        }


    }
}
