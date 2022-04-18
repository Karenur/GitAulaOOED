using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cartapio
{
    class BebidaAlcolica : Bebida,IAvisoRestricao
    {
        public BebidaAlcolica(double precoPegueno, double precoMedio, double precoGrande, string nome) : base(precoPegueno, precoMedio, precoGrande, nome)
        {

        }



        public override string InformarNome()
        {
            return nome;
        }
        public override string InformarPreco()
        {
            Console.WriteLine(AvisarRestricaoVendaMenores());
            return ($"Tamanho Pequeno: {PrecoPegueno.ToString("C")}\n " +
                    $"Tamanho Medio: {PrecoMedio.ToString("C")}\n " +
                    $"Tamanho Grande: {PrecoGrande.ToString("C")}\n ");
        }


        public string AvisarRestricaoVendaMenores()
        {
            return "Proibido venda para menores";

        }

    }
}
