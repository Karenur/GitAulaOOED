using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__exercicio_5
{
    class Aperitivo : ItemMenu
    {
        double precoPorcao;

        public Aperitivo(double precoPorcao, string nome):base(nome)
        {
            this.precoPorcao = precoPorcao;
        }

        public double PrecoPorcao
        {
            get
            {
                return precoPorcao;
            }
        }

        public override string InformarNome()
        {
            return nome;
        }
        public override string InformarPreco()
        {
            return precoPorcao.ToString("C");
        }


    }
}
