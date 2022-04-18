using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cartapio
{
    class Program
    {
        static void Main(string[] args)
        {

            ItemMenu cafe = new Bebida(2, 4, 6, "Cafe expresso");






            Console.WriteLine(cafe.InformarNome());
            Console.WriteLine(cafe.InformarPreco());
            
            

            Console.ReadLine();



        }
    }
}
