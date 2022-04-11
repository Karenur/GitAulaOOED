using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__exercicio_5
{
    abstract class ItemMenu
    {
        protected string nome;

        public ItemMenu(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public abstract string InformarNome();

        public abstract string InformarPreco();


    }
}
