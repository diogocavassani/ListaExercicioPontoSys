using System;

namespace ExercicioCinco.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor: ");
	        var numeroReadLine = Console.ReadLine();
	
	        int.TryParse(numeroReadLine, out var numero);
	
	        var resultado = numero % 2;
	
	        if(resultado == 0) 
		        Console.WriteLine("O numero é par");
	        else
		        Console.WriteLine("O numero é impar");
        }
    }
}
