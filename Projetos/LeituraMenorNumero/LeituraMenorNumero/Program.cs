namespace LeituraMenorNumero
{
    internal class LeituraMenorNumero
    {
        static void Main(string[] args)
        {
            string[] vet;
            int numero1, numero2, numero3, numeroMenor;

            Console.WriteLine("Digite 3 numeros");
            vet = Console.ReadLine().Split(' ');

            numero1 = int.Parse(vet[0]);
            numero2 = int.Parse(vet[1]);
            numero3 = int.Parse(vet[2]);

            if (numero1 < numero2 && numero1 < numero3)
            {
                Console.WriteLine("Menor Numero dentre os três é o " + numero1);
            } else if (numero2 < numero3) {
                Console.WriteLine("Menor Numero dentre os três é o " + numero2);
            } else
            {
                Console.WriteLine("Menor Numero dentre os três é o " + numero3);
            }
           
        }
    }
}