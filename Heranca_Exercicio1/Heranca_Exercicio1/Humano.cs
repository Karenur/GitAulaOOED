using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1
{
    class Humano
    {
        private string primeiroNome;
        private string ultimoNome;

        public Humano(){}

        public Humano(string primeiroNome, string ultimoNome)
        {
            this.primeiroNome = primeiroNome;
            this.ultimoNome = ultimoNome;
        }

        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }
        }

        public string UltimoNome
        {
            get
            {
                return ultimoNome;
            }
        }

        public string InformarNomeCompleto()
        {
            return $"{PrimeiroNome} {UltimoNome}";
        }
    }
}
