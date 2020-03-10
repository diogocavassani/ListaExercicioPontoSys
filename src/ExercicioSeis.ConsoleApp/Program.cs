using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioSeis.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var notas = new List<float>();
	        for(int i = 0; i < 4; i++) {
		        Console.WriteLine($"Digite a nota {i+1}: ");
		        var notaReadLine = Console.ReadLine();
				float.TryParse(notaReadLine, out var nota);
				notas.Add(nota);
	        }
	
	        if(notas.Average() <5) 
		        Console.WriteLine("O aluno foi reprovado");
	        else
		        Console.WriteLine("O aluno foi aprovado");
            }
    }
}
