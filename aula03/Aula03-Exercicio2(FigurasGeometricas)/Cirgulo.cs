using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicio2_FigurasGeometricas_
{
    class Cirgulo : FiguraGeometrica
    {
        const float valorPI = 22/7;


        public Cirgulo(float medida) : base(medida)
        {
        }

        public override double CalcularArea()
        {
            return valorPI * Medida*Medida;
        }

        public override float CalcularPerimetro()
        {
            
            return 2 * valorPI * Medida;
        }
    }
}
