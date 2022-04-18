using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_Encapsulamento
{
    class Carro
    {
        string cor;
        string modelo;
        float velocidadeAtual = 0;
        float velocidadeMaxima;
        int anoFabricacao;
        bool ligado;

        public Carro(string cor, string modelo, float velocidadeMaxima, int anoFabricacao)
        {
            this.cor = cor;
            this.modelo = modelo;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = velocidadeMaxima;
            this.anoFabricacao = anoFabricacao;
            this.ligado = false;
        }

        public string Cor
        {
            get
            {
                return cor;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
        }

        public float VelocidadeAtual
        {
            get
            {
                return velocidadeAtual;
            }
        }

        public float VelocidadeMaxima
        {
            get
            {
                return velocidadeMaxima;
            }
        }

        public int AnoFabricacao
        {
            get
            {
                return anoFabricacao;
            }
        }

        public bool Ligado
        {
            get
            {
                return ligado;
            }
        }

        public void Ligar()
        {
            if (ligado == false)
            {
                ligado = true;
            }
            else
            {
                Console.WriteLine("O carro ja esta ligado");
            }
        }
        public void Desligar()
        {
            if (ligado == true & VelocidadeAtual == 0)
            {
                ligado = false;
            }
            else if (VelocidadeAtual >= 0)
            {
                Console.WriteLine("Pare o carro para desliga-lo");
            }
            else
            {
                Console.WriteLine("O carro ja esta desligado");
            }

        }

        public void Acelerar(float acelerarX)
        {
            if (ligado == true & VelocidadeAtual <= VelocidadeMaxima)
            {
                velocidadeAtual += acelerarX;
                Console.WriteLine($"Velocidade atual: {VelocidadeAtual} K/m");
            }
            else
            {
                Console.WriteLine("Ligue o carro para acelerar");
            }

        }
        public void Freiar(float freiarX)
        {
            if (ligado == true & VelocidadeAtual > 0)
            {
                velocidadeAtual -= freiarX;
                Console.WriteLine($"Velocidade atual: {VelocidadeAtual} K/m");
            }
            else if (VelocidadeAtual <= freiarX)
            {
                velocidadeAtual = 0;
                Console.WriteLine("Ja esta parado");
            }            

        }



    }
}
