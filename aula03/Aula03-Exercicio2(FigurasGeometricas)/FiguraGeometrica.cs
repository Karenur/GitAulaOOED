using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicio2_FigurasGeometricas_
{
    abstract class FiguraGeometrica
    {

        float medida;
        public float Medida { get => medida;}
        public FiguraGeometrica(float medida)
        {
            this.medida = medida;
        }

        public abstract double CalcularArea();

        public abstract float CalcularPerimetro();



    }
}
