using System;

namespace ExercicioQuatro.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base do triangulo: ");
            var baseTriaguloReadLine = Console.ReadLine();
            float.TryParse(baseTriaguloReadLine, out var baseTriangulo);

            Console.WriteLine("Digite o valor da altura do triangulo: ");
            var alturaTriaguloReadLine = Console.ReadLine();
            float.TryParse(alturaTriaguloReadLine, out var alturaTriagulo);

            var areaTriangulo = baseTriangulo * alturaTriagulo / 2;

            Console.WriteLine($"A area do triangulo é de: {Math.Round(areaTriangulo, 2)}  ");

        }
    }
}
