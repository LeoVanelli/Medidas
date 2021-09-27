using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Receba uma medida em metros e exiba seus equivalentes em quilômetros e centímetros.

            Console.Write("Entre com a medida em metros: ");

            double medida = double.Parse(Console.ReadLine());

            Console.WriteLine("----- Equivalência -----");
            Console.WriteLine($"Centimetros: {medida*100} cm");
            Console.WriteLine($"Metros: {medida} m");
            Console.WriteLine($"QUilômetros: {medida/1000} km");
        }
    }
}
