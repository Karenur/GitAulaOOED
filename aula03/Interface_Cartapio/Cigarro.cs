using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cartapio
{
    class Cigarro : ItemMenu, IAvisoRestricao
    {

        double preco;

        public Cigarro(double preco, string nome) : base(nome)
        {
            this.preco = preco;
        }

        public double Preco { get => preco;}

        public override string InformarNome()
        {
            return nome;
        }

        public override string InformarPreco()
        {
            return preco.ToString("C");
        }

        public string AvisarRestricaoVendaMenores()
        {

            return "Proibido venda para menores";
        }


    }
}
