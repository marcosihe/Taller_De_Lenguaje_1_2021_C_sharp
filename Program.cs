using System;
using FormasGeometricas;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo1 = new Rectangulo();
            Triangulo triangulo1 = new Triangulo();

            rectangulo1.Base = 15;
            rectangulo1.Altura = 10;
            triangulo1.BaseT = 15;
            triangulo1.AlturaT = 10;

            Console.WriteLine("Perimetro del rectángulo: " + rectangulo1.perimetro());
            Console.WriteLine("Área del rectángulo: " + rectangulo1.area());
            Console.WriteLine("Área del triángulo: " + triangulo1.area());
        }
    }
}
