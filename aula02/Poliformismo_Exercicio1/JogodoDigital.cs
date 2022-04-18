using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformismo_Exercicio1
{
    class JogodoDigital: Produto
    {

        private string fabricante;
        private string titulo;
        private string console;

        public JogodoDigital(string fabricante, string titulo, string console, float preco):base (preco)
        {
            this.fabricante = fabricante;
            this.titulo = titulo;
            this.console = console;
        }

        public string Fabricante
        {
            get
            {
                return fabricante;
            }            
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }

        public string Console
        {
            get
            {
                return console;
            }
        }

        public override string InformarDescricao()
        {
            return $"{this.titulo} - {this.console} - {this.fabricante}";
        }


    }
}
