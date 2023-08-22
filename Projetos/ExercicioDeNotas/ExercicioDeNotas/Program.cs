using System;
using System.Globalization;

namespace ExercicioDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeAluno;
            double Nota1, Nota2, Media;

            Console.WriteLine("Calculo das Notas Finais!");
            Console.WriteLine("Digite o Nome do Aluno(a): ");
            NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a nota 1 do Aluno(a) " + NomeAluno + ": ");
            Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 2 do Aluno(a) " + NomeAluno + ": ");
            Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Media = (Nota1 + Nota2) / 2;

            if (Media >= 60.0)
            {
                Console.WriteLine("PARABENS!");
                Console.WriteLine("O aluno(a) " + NomeAluno + " foi APROVADO!");
                Console.WriteLine("Nota Final: " + Media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("O aluno(a) " + NomeAluno + " foi REPROVADO!");
                Console.WriteLine("Nota Final: " + Media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

    }

}

