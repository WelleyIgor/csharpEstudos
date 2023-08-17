using System;
using System.Globalization;

namespace calculadoraHorasFabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSegundos, horas,minutos, segundos, resto;

            Console.WriteLine("Controle da Fabrica!!!");
            Console.WriteLine("Digite a quantidade de segundos: ");
            numeroSegundos = int.Parse(Console.ReadLine());

            horas = numeroSegundos / 3600;
            resto = numeroSegundos % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine("Você trabalhou: " + horas + ":" + minutos + ":" + segundos + "h.");
        }

    }

}