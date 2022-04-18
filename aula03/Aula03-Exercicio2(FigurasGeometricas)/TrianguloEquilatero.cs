using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula03_Exercicio2_FigurasGeometricas_
{
    
    class TrianguloEquilatero : FiguraGeometrica
    {
        const int numeroLados = 3;
        public TrianguloEquilatero(float medida) : base(medida)
        {
        }

        public override double CalcularArea()
        {
            Math.Sqrt(3);
            return Medida * Medida * (Math.Sqrt(3)) / 4;
        }

        public override float CalcularPerimetro()
        {
            return Medida * numeroLados;
        }
    }
}
