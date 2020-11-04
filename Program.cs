using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double maior = 0;

            Console.Write("Digite o 1ºNúmero: ");
            numero = double.Parse(Console.ReadLine());
            if (numero > maior)
            {
                maior = numero;
            }

            Console.Write("Digite o 2ºNúmero: ");
            numero = double.Parse(Console.ReadLine());
            if (numero > maior)
            {
                Console.WriteLine();
                maior = numero;
            }
            Console.Write("O maior número digitado é: {0}", maior);

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
