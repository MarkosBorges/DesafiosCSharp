using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            DESAFIO 02 - 18/FEV
            Objetivo
            Escreva um programa que calcula o IMC (Índice de massa corporal de uma pessoa) e exibe o resultado.

            Resultado esperado
            Informe sua altura: 1,75
            Informe seu peso: 85

            > Seu IMC é 27.76
            > Sobrepeso
            > Obesidade Grau I
            > Risco: Aumentado

            */
            Console.Clear();
            Console.WriteLine(" ======= DESAFIO 02 ====== ");

            Console.WriteLine("Informa e sua altura:");
            var altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o seu peso:");
            var peso = double.Parse(Console.ReadLine());

            var IMC = peso / (altura * 2);

            if (IMC < 16.0)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Magreza Grau III");
                Console.WriteLine("Você esta muito abaixo do peso!");
                Console.WriteLine("Risco: ");
            }
            else if (IMC >= 16.0 && IMC <= 16.9)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Magreza Grau II");
                Console.WriteLine("Você está abaixo do peso!");
                Console.WriteLine("Risco: ");
            }
            else if (IMC >= 17.0 && IMC <= 18.4)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Magreza Grau I");
                Console.WriteLine("Risco: ");
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Eutrofia");
                Console.WriteLine("Risco: ");
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Sobrepeso");
                Console.WriteLine("Risco: Aumentado");
            }
            else if (IMC >= 30.0 && IMC <= 34.9)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Obesidade Grau I");
                Console.WriteLine("Risco: Moderado");
            }
            else if (IMC >= 35.0 && IMC <= 40.0)
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Obesidade Grau II");
                Console.WriteLine("Risco: Grave ");
            }
            else
            {
                Console.WriteLine($"Seu IMC é {Math.Round(IMC, 2)}");
                Console.WriteLine("Obesidade Grau III");
                Console.WriteLine("Você está muito acima do peso!");
                Console.WriteLine("Risco: Muito grave");
            }


        }
    }
}