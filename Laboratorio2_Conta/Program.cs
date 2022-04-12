using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_Conta
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta contaBob = new Corrente("12345-6", "Bob Nelson");
            Conta contaTesteolfo = new Poupanca("71717-1", "Testolfo Rocha");
            Conta contaLisa = new Poupanca("65432-1", " Lisa Leite");


            contaBob.DepositarDinheiro(5000);
            contaLisa.DepositarDinheiro(2000);
            contaTesteolfo.DepositarDinheiro(1500);

            Console.WriteLine(contaBob.VerificarSaldo());
            Console.WriteLine(contaLisa.VerificarSaldo());
            Console.WriteLine(contaTesteolfo.VerificarSaldo());
            Console.ReadLine();

            
            Transferencia(contaBob,contaTesteolfo,600);  
            
            Sacar(contaLisa, 250);
                        
            Transferencia(contaLisa, contaTesteolfo, 400);
            
            Transferencia(contaTesteolfo, contaBob, 1000);

            Sacar(contaBob, 900);

            Transferencia(contaBob, contaLisa, 1500);

            Transferencia(contaTesteolfo,contaLisa,1200);

            Sacar(contaBob, 2000);

            Depositar(contaLisa, 100);

            Transferencia(contaTesteolfo, contaBob, 700);

        }

        public static void Transferencia(Conta contaOrigem, Conta contaDestino, double valor)
        {
            Console.WriteLine($"{contaOrigem.NomeCorrentista} transferiu {valor:C} para {contaDestino.NomeCorrentista}");
            Console.WriteLine(contaOrigem.TransferirDinheiro(contaDestino, valor));
            Console.WriteLine(contaOrigem.VerificarSaldo());
            Console.WriteLine(contaDestino.VerificarSaldo());
            Console.ReadLine();
        }

        public static void Sacar(Conta conta, double valor)
        {
            Console.WriteLine($"{conta.NomeCorrentista} sacou {valor:C}");
            Console.WriteLine(conta.SacarDinheiro(valor));
            Console.WriteLine(conta.VerificarSaldo());
            Console.ReadLine();
        }
        public static void Depositar(Conta conta, double valor)
        {
            Console.WriteLine($"{conta.NomeCorrentista} depositou {valor:C}");
            conta.DepositarDinheiro(valor);
            Console.WriteLine(conta.VerificarSaldo());
            Console.ReadLine();
        }

    }
    
}
