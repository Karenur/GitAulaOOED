using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicio2_FigurasGeometricas_
{
    class Exagono : FiguraGeometrica
    {
        const int numeroLados = 6;
        public Exagono(float medida) : base(medida)
        {
        }

        public override double CalcularArea()
        {

            return Medida*Medida*3*Math.Sqrt(3)/2;
        }

        public override float CalcularPerimetro()
        {

            return Medida*numeroLados;
        }
    }
}
