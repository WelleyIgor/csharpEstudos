using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.38600;
            int Idade = 29;
            string Nome = "Welley";
            string Sexo = "Masculino";
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine("O Valor do troco é " + x.ToString("F3") + " Reais");
            Console.WriteLine("O Paciente " + Nome + " Tem " + Idade + " anos, e é do sexo: " + Sexo);
        }
    }
}