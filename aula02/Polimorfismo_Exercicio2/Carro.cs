using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exercicio2
{
    class Carro
    {

        private string modelo;
        private string cor;
        private float velocidadeMaxima;

        public Carro(string modelo, string cor, float velocidadeMaxima)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }
        }

        public float VelocidadeMaxima
        {
            get
            {
                return velocidadeMaxima;
            }
        }

        public string DescreverCarro()
        {            
            return $"{modelo} _ {cor} _ {velocidadeMaxima}Km/h";
        }

        public virtual string MostrarDetalhes()
        {
            return "";
        }
    }
}
