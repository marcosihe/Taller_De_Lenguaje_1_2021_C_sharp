using System;
using System.Globalization;
using FormasGeometricas;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo1 = new Rectangulo();
            Triangulo triangulo1 = new Triangulo();
            Triangulo triangulo2 = new Triangulo(20,30);

            rectangulo1.Base = 15;
            rectangulo1.Altura = 10;
            triangulo1.BaseT = 15;
            triangulo1.AlturaT = 10;

            Console.WriteLine("Perimetro del rectángulo 1: " + rectangulo1.Perimetro());
            Console.WriteLine("Área del rectángulo 1: " + rectangulo1.Area());
            Console.WriteLine("Área del triángulo 1: " + triangulo1.Area());
            Console.WriteLine("Área del triángulo 2: " + triangulo2.Area());

            // Date
            DateTime fechaPorDefecto = new DateTime();
            DateTime fechaAsignada = new DateTime(2020,12,21);
            DateTime hoy = System.DateTime.Now;
            TimeSpan dif = hoy - fechaAsignada;
            CultureInfo culture = new CultureInfo("Us-us");

            Console.WriteLine("La fecha y hora por defecto es: " + fechaPorDefecto);
            Console.WriteLine("Fecha: " + fechaAsignada.ToString());
            Console.WriteLine("Fecha en formato corto: " + fechaAsignada.ToShortDateString());
            Console.WriteLine("Hora por defecto: " + fechaAsignada.ToShortTimeString());
            Console.WriteLine("Fecha en formato largo: " + fechaAsignada.ToLongDateString());
            Console.WriteLine("Fecha y hora actual:" + hoy);
            Console.WriteLine("Diferencia de tiempo en días: " + dif.Days);
            Console.WriteLine("Diferencia de tiempo en horas: " + dif.TotalHours);
            Console.WriteLine("Fecha: " + hoy.ToString(culture));
        }
    }
}
