namespace treinamentoSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaSemana;
            string diaDescrito;

            Console.WriteLine("Digite o dia da semana (sendo 1 = domingo, 2= segunda e assim por diante): ");
            diaSemana = int.Parse(Console.ReadLine()); 

            switch (diaSemana)
            {
                case 1:
                    diaDescrito = "Domingo";
                    break;
                case 2:
                    diaDescrito = "Segunda";
                    break;
                case 3:
                    diaDescrito = "Terça";
                    break;
                case 4:
                    diaDescrito = "Quarta";
                    break;
                case 5:
                    diaDescrito = "Quinta";
                    break;
                case 6:
                    diaDescrito = "Sexta";
                    break;
                case 7:
                    diaDescrito = "Sabado";
                    break;
                default:
                    diaDescrito = "Dia inválido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + diaDescrito);
        }
    }
}