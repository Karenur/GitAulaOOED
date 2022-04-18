using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicio2_FigurasGeometricas_
{
    class Quadrado : FiguraGeometrica
    {
        const int numeroLados = 4;

        public Quadrado(float medida) : base(medida){}

        public override double CalcularArea()
        {
            return Medida*Medida;
        }

        public override float CalcularPerimetro()
        {
            return Medida*numeroLados;
        }
    }
}
