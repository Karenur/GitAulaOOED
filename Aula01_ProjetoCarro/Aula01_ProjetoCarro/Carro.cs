using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_ProjetoCarro
{
    class Carro
    {
        public string cor;
        public int anoFabricacao;
        public string modelo;
        public float velocidadeAtual;
        public float velocidadeMaxima;
        public bool estaLigado;

        public Carro(string cor, int anoFabricacao, string modelo, float velocidadeAtual, float velocidadeMaxima, bool estaLigado)
        {
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
            this.modelo = modelo;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = velocidadeMaxima;
            this.estaLigado = estaLigado;
        }

        public void Ligar()
        {
            if (estaLigado == false)
            {
                estaLigado = true;
                Console.WriteLine("Ligando o carro");
                Console.ReadLine();
                Console.WriteLine("Carro esta ligado!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Carro ja esta ligado, animal!!");
                Console.ReadLine();
            }

        }
        public void Desligar()
        {

            if (estaLigado == true && velocidadeAtual == 0)
            {
                estaLigado = false;
                Console.WriteLine("desligando o carro");
                Console.ReadLine();
                Console.WriteLine("Carro esta desligado!");
                Console.ReadLine();
            }
            else if(estaLigado == true & velocidadeAtual > 0)
            {
                Console.WriteLine("Pare o carro andes de desligar");
                Console.ReadLine();
            }
            if (!estaLigado)            
            {
                Console.WriteLine("Carro ja esta desligado, animal!!");
                Console.ReadLine();
            }
        }

        public void Acelerar()
        {            
            Console.WriteLine("Acelerando o carro");
            if (estaLigado)
            {
                if (velocidadeAtual < velocidadeMaxima)
                {
                    velocidadeAtual += 10;
                    if (velocidadeAtual > velocidadeMaxima)
                    {
                        velocidadeAtual = velocidadeMaxima;
                    }
                }
            }
            else
            {
                Console.WriteLine("O carro esta desligado");
                Console.ReadLine();
            }
            if (velocidadeAtual == velocidadeMaxima)
            {
                Console.WriteLine("Velocidade maxima adingida!! freia seu animal");
                Console.ReadLine();
            }
            MostrarVelocidade();
        }

        public void Freiar()
        {
            
            Console.WriteLine("Freiando o carro");
            if(velocidadeAtual > 0)
            {
                
                if(velocidadeAtual <= 30)
                {
                    velocidadeAtual = 0;
                }
                else
                {
                    velocidadeAtual -= 30;
                }
            }
            else
            {
                Console.WriteLine("Carro ja esta parado");               
            }
            MostrarVelocidade();
        }
        public void MostrarVelocidade()
        {
            Console.WriteLine($"Velocidade atual do carro é: {velocidadeAtual} Km/h");
        }


    }
}
