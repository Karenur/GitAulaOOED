using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__exercicio_5
{
    class Bebida : ItemMenu
    {
        double precoPequeno;
        double precoMedio;
        double precoGrande;

        public Bebida(double precoPegueno, double precoMedio, double precoGrande,string nome):base(nome)
        {
            this.precoPequeno = precoPegueno;
            this.precoMedio = precoMedio;
            this.precoGrande = precoGrande;
        }

        public double PrecoPegueno
        {
            get
            {
                return precoPequeno;
            }
        }

        public double PrecoMedio
        {
            get
            {
                return precoMedio;
            }
        }

        public double PrecoGrande
        {
            get
            {
                return precoGrande;
            }
        }


        public override string InformarNome()
        {
            return nome;
        }
        public override string InformarPreco()
        {
            return ($"Tamanho Pequeno: {precoPequeno.ToString("C")}\n "+
                    $"Tamanho Medio: {precoMedio.ToString("C")}\n " +
                    $"Tamanho Grande: {precoGrande.ToString("C")}\n ");
        }


    }
}
