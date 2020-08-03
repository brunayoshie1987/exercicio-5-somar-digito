using System;

namespace Exercicio_5___Somar_Digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            var inteiro = Convert.ToInt32(Console.ReadLine());

            var resto = 0.0;
            var divisor = 10.0;
            var soma = 0.0;
            var intDivisao = 1;

            while (intDivisao != 0)
            {
                resto = inteiro % divisor;
                intDivisao = Convert.ToInt32(Math.Truncate(inteiro / divisor));

                soma += resto;

                inteiro = intDivisao;
            }

            Console.WriteLine("O resultado da soma dos dígitos é: " + soma);

            Console.ReadKey();
        }
    }
    }

