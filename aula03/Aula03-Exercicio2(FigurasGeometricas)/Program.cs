using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicio2_FigurasGeometricas_
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(10);
            TrianguloEquilatero triangulo = new TrianguloEquilatero(10);
            Exagono exagono = new Exagono(10);
            Cirgulo cirgulo = new Cirgulo(10);




            Console.WriteLine("Quadrado");
            Console.WriteLine("Area igual a :" + quadrado.CalcularArea());
            Console.WriteLine("Perimetro igual a :" + quadrado.CalcularPerimetro());
            Console.ReadLine();

            Console.WriteLine("Triangulo");
            Console.WriteLine("Area igual a :" + triangulo.CalcularArea());
            Console.WriteLine("Perimetro igual a :" + triangulo.CalcularPerimetro());
            Console.ReadLine();

            Console.WriteLine("Exagono");
            Console.WriteLine("Area igual a :" + exagono.CalcularArea());
            Console.WriteLine("Perimetro igual a :" + exagono.CalcularPerimetro());
            Console.ReadLine();

            Console.WriteLine("Circulo");
            Console.WriteLine("Area igual a :" + cirgulo.CalcularArea());
            Console.WriteLine("Perimetro igual a :" + cirgulo.CalcularPerimetro());
            Console.ReadLine();
        }
    }
}
