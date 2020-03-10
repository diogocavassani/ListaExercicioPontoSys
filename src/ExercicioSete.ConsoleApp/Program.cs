using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioSete.ConsoleApp
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
            Console.WriteLine("Digite o total de aulas: ");
            var quantidadeAulaReadLine = Console.ReadLine();
            int.TryParse(quantidadeAulaReadLine, out var quantidadeAula);
            
            Console.WriteLine("Digite o total de presença: ");
            var quantidadePresencaReadLine = Console.ReadLine();
            int.TryParse(quantidadePresencaReadLine, out var quantidadePresenca);
            
            var frequencia = quantidadePresenca * 100 / quantidadeAula;
            
            
            
            if(notas.Average() <5 && frequencia < 75) 
                Console.WriteLine("O aluno foi reprovado");
            else
                Console.WriteLine("O aluno foi aprovado");
        }
    }
}
