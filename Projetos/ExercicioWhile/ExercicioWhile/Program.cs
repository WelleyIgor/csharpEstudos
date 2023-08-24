namespace ExercicioWhile
{
    internal class Program
    {
        //Exercicio URI 1113 - Leia uma quantidade indeterminada de duplas de valores inteiros X e Y.
        //Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.
        //A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.
        //Para cada teste a saída deve ser crescente ou decrescente.
        static void Main(string[] args)
        {
            string[] numeros;
            int numeroX, numeroY;

            Console.WriteLine("Digite dois numeros inteiros: ");
            numeros = Console.ReadLine().Split(' ');
            numeroX = int.Parse(numeros[0]);
            numeroY = int.Parse(numeros[1]);

            while (numeroX != numeroY)
            {
                if (numeroX < numeroY)
                {
                    Console.WriteLine("Crescente");
                } else
                {
                    Console.WriteLine("Decrescente");
                }
                numeros = Console.ReadLine().Split(' ');
                numeroX = int.Parse(numeros[0]);
                numeroY = int.Parse(numeros[1]);
            }
        }
    }
}