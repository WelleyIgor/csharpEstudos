using System;
using System.Globalization;

namespace exercicioPropostoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTerreno, alturaTerreno, areaTerreno, perimetroTerreno, diagonalTerreno;

            Console.WriteLine("Ola, seja bem vindo!");
            Console.WriteLine("Digite o valor da Base do terreno: ");
            baseTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a largura do terreno: ");
            alturaTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculos
            areaTerreno = baseTerreno * alturaTerreno;
            perimetroTerreno = (2 * baseTerreno) + (2 * alturaTerreno);
            diagonalTerreno = Math.Sqrt(Math.Pow(baseTerreno, 2) + Math.Pow(alturaTerreno, 2));

            //resultados
            Console.WriteLine("Area Total: " + areaTerreno.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro Total: " + perimetroTerreno.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal Total: " + diagonalTerreno.ToString("F4", CultureInfo.InvariantCulture));
        }

    }
}
