﻿using System;

namespace ExercicioTres.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infome o nome do produto");
            var descricaoProdutoReadLine = Console.ReadLine();
            
            Console.WriteLine("Informe o valor do produto: ");
            var valorBrutoReadLine = Console.ReadLine();
            float.TryParse(valorBrutoReadLine, out var valorBrutoFloat);

            Console.WriteLine("Informe o valor do desconto: ");
            var valorDescontoReadLine = Console.ReadLine();
            float.TryParse(valorDescontoReadLine, out var valorDescontoFloat);

            var valorLiquido = valorBrutoFloat - (valorDescontoFloat/100 * valorBrutoFloat); 

            Console.WriteLine($"O valor liquido do produto é {Math.Round(valorLiquido, 2)}");
        }
    }
}
