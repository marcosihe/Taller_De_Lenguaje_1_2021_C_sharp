using System;
using FormasGeometricas;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo1 = new Rectangulo();
            rectangulo1.Base = 15;
            rectangulo1.Altura = 10;
            Console.WriteLine("Perimetro: " + rectangulo1.perimetro(rectangulo1.Base, rectangulo1.Altura));
        }
    }
}
