using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DESAFIO 01 - 17/FEV
            Objetivo
            Escreva um programa que conte a quantidade de palavras e caracteres que um determinado texto, escrito no Console, contém.

            Resultado esperado
            Digite um texto:

            Este texto foi digitado no console

            > 34 caracteres, 6 palavras

            */
            Console.WriteLine(" ======= DESAFIO 01 ====== ");
            //var text = "Texto de teste";
            int cont = 0;
            Console.WriteLine("Digite um breve texto/frase:");
            string text = Console.ReadLine();
            Console.WriteLine(text);

            //text = text.Trim();
            int tam = text.Length;
            string[] palavras = text.Split(new Char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in palavras)
            {
                cont++;
            }

            Console.WriteLine("====================================================");
            Console.WriteLine($"Seu texto contém: {tam} caracteres, {cont} palavras.");
            Console.WriteLine("====================================================");

        }
    }
}