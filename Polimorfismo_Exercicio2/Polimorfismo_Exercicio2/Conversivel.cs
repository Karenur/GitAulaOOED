using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exercicio2
{
    class Conversivel :Carro
    {
        private bool estaConversivel;

        public Conversivel(bool estaConversivel,string modelo ,string cor, float velocidadeMaxima) :base(modelo,cor, velocidadeMaxima)
        {
            this.estaConversivel = estaConversivel;
        }

        public bool EstaConversivel
        {
            get
            {
                return estaConversivel;
            }
        }
        public override string MostrarDetalhes()
        {
            if (estaConversivel)
                return $"Aproveite o vendo na cara";
            else
                return "Abra o teto para aproveitar";
        }
    }
}
