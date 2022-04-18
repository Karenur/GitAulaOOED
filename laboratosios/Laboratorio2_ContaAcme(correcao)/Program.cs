using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_ContaAcme_correcao_
{
    class Program
    {
        static void Main(string[] args)
        {

            Corrente contaBob = new Corrente("12345-6", "Bob Nelson");
            Poupanca contaTestolfo = new Poupanca("71717-7", "Testolfo Rocha");
            Corrente contaLisa = new Corrente("65432-1", "Lisa Leite");


            RealizarDeposito(contaBob, 2000);





        }

        

}
}
