using System;
using System.Collections.Generic;

namespace FuncionesLogicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamadas a las funciones con ejemplos de uso

            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] numbersArray = { 2, 4, 6, 8, 10 };
            LoopArray(numbersArray);

            int[] numbersForMax = { -3, -5, -7, 0, 2, 4 };
            int max = FindMax(numbersForMax);
            Console.WriteLine($"El número máximo es: {max}");

            int[] numbersForAverage = { 2, 10, 3 };
            GetAverage(numbersForAverage);

            List<int> oddNumbersList = OddList();
            Console.WriteLine("Lista de números impares:");
            foreach (var number in oddNumbersList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            List<int> greaterThanList = new List<int> { 1, 3, 5, 7 };
            int y = 3;
            int greaterThanYCount = GreaterThanY(greaterThanList, y);
            Console.WriteLine($"Número de valores mayores que {y}: {greaterThanYCount}");

            List<int> squareValues = new List<int> { 1, 5, 10, -10 };
            SquareArrayValues(squareValues);
            Console.WriteLine("Valores al cuadrado:");
            foreach (var number in squareValues)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            List<int> eliminateNegativesList = new List<int> { 1, 5, 10, -2 };
            EliminateNegatives(eliminateNegativesList);
            Console.WriteLine("Eliminando números negativos:");
            foreach (var number in eliminateNegativesList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintOdds()
        {
            for (int i = 1; i <= 255; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        static void LoopArray(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static int FindMax(int[] numbers)
        {
            int max = int.MinValue;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            double average = (double)sum / numbers.Length;
            Console.WriteLine($"El promedio es: {average}");
        }

        static List<int> OddList()
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 1; i <= 255; i += 2)
            {
                oddNumbers.Add(i);
            }
            return oddNumbers;
        }

        static int GreaterThanY(List<int> numbers, int y)
        {
            int count = 0;
            foreach (var number in numbers)
            {
                if (number > y)
                {
                    count++;
                }
            }
            return count;
        }

        static void SquareArrayValues(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= numbers[i];
            }
        }

        static void EliminateNegatives(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
    }
}

