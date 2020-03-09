using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioDois.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaNumero = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                var numeroRequisitado = i +1;
                Console.WriteLine($"{numeroRequisitado})Favor digite um numero:");
                var numeroReadLine = Console.ReadLine();
                int.TryParse(numeroReadLine, out var numero);

                listaNumero.Add(numero);
            }
            
            Console.WriteLine($"A média  dos numero é = {Math.Round(listaNumero.Average(), 2)}");
        }
    }
}
