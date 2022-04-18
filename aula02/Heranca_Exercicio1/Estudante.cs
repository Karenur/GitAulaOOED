using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1
{
    class Estudante : Humano
    {
        private float notaFinal;

        public Estudante (string primeiroNome, string ultimoNome, float notaFinal):base(primeiroNome,ultimoNome)
        {
           this.notaFinal = notaFinal;
        }

        public float NotaFinal
        {
            get
            {
                return notaFinal;
            }
        }
    }
}
