using System;
using System.Globalization;

namespace calculadoraTerrenoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de m² de um terreno!");
            Console.WriteLine("Digite a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do m²: ");
            double valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = (largura * comprimento);
            double valorTotal = (area * valorMetro);

            Console.WriteLine("Valor da área: " + area.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do m²: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}