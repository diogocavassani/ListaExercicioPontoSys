using System;

namespace ExercicioUm.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite um numero para calculo tabuada: ");
            var numeroReadLine = Console.ReadLine();
            int.TryParse(numeroReadLine, out var numero);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        
    }
}
