using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace exercicioWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somaIdades, idades, quantidadeIdades, mediaTurma;

            Console.WriteLine("Digite as idades dos alunos da turma: ");
            idades = double.Parse(Console.ReadLine());

            somaIdades = 0;
            quantidadeIdades = 0;
            while (idades >= 0)
            {
                somaIdades += idades;
                quantidadeIdades += 1;
                idades = int.Parse(Console.ReadLine());
            }
            if (quantidadeIdades == 0)
            {
                Console.WriteLine("Impossivel Calcular...");
            }
            else
            {
                mediaTurma = somaIdades / quantidadeIdades;
                Console.WriteLine("A média da turma é " + mediaTurma.ToString("F2", CultureInfo.InvariantCulture) + ".");
            }
        }
    }
}