namespace testeFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDefinicao, numSoma;

            Console.WriteLine("Digite a quantidade de numeros que deseja inserir na soma: ");
            numDefinicao = int.Parse(Console.ReadLine());
            numSoma = 0;

            for (int numCalc = 1; numCalc <= numDefinicao; numCalc ++)
            {
                Console.WriteLine("Certo, o numero de repetições será " + numDefinicao + ".");
                Console.WriteLine("Digite o " + numCalc + "º numero");
                numSoma += int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("A Soma dos numeros digitados foi: " + numSoma);
        }
    }
}