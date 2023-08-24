namespace treinamentoEnquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, somaTotal;

            Console.WriteLine("Digite numeros a serem somados!!!");
            numero = double.Parse(Console.ReadLine());

            somaTotal = 0;

            while (numero != 0)
            {
                somaTotal +=  numero;
                numero = double.Parse(Console.ReadLine());  
            }

            Console.WriteLine("A soma de todos os numeros digitados acima é: " + somaTotal + ".");
        }
    }
}