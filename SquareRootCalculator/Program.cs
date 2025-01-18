using System;
using System.Globalization;

namespace SquareRootCalculator
{
    class MathSquareRoot
    {
        static void Main(string[] args)
        {
            double currentNumber;
            double result;
            string input;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Calcule a Raiz Quadrada");

            do
            {
                Console.Write("Digite o número a ser calculado: ");
                input = Console.ReadLine();

                if (!double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out currentNumber))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite apenas números.\n");
                    continue;
                }

                if (currentNumber <= 0)
                {
                    Console.WriteLine("Não é possível calcular a raiz quadrada de zero ou valores negativos\n");
                    continue;
                }

                break;

            }
            while (true);

            result = Math.Sqrt(currentNumber);

            Console.WriteLine($"A raiz quadrada de {currentNumber} é {result}");
        }
    }

}