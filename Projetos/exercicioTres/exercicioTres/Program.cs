using System;
using System.Globalization;

namespace exercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarações.
            string[] nomeIdade1, nomeIdade2;
            string nome1, nome2;
            int idade1, idade2;
            double mediaIdade;

            //Entrada de dados.
            Console.WriteLine("Digite o Primeiro nome e a idade de uma pessoa: ");
            nomeIdade1 = Console.ReadLine().Split(' ');
            nome1 = nomeIdade1[0];
            idade1 = int.Parse(nomeIdade1[1]);

            Console.WriteLine("Digite o Primeiro nome e a idade de uma segunda pessoa: ");
            nomeIdade2 = Console.ReadLine().Split(' ');
            nome2 = nomeIdade2[0];
            idade2 = int.Parse(nomeIdade2[1]);

            //Calculos e resultado.
            mediaIdade = (double) (idade1 + idade2) / 2;
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + mediaIdade.ToString("F1", CultureInfo.InvariantCulture) + " anos.");



        }
    }
}