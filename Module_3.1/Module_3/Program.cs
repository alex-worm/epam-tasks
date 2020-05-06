using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Module_3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }

    }
    public class Task1
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// Throw ArgumentException if user input is invalid
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int ParseAndValidateIntegerNumber(string source)
        {
            if (int.TryParse(source, out int result))
            {
                return result;
            }

            throw new ArgumentException("Invalid input");
        }

        public int Multiplication(int num1, int num2)
        {
            return (int)Math.Round(num1 / (1 / (double)num2));
        }
    }

    public class Task2
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        {
            while (true)
            {
                if (int.TryParse(input, out result) && (result >= 0))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                    input = Console.ReadLine();
                }
            }
        }

        public List<int> GetEvenNumbers(int naturalNumber)
        {
            var evenNumbers = new List<int>();

            for(var i = 0; i < naturalNumber; i++)
            {
                evenNumbers.Add(i * 2);
            }

            return evenNumbers;
        }
    }

    public class Task3
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        {
            while (true)
            {
                if (int.TryParse(input, out result) && (result >= 0))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                    input = Console.ReadLine();
                }
            }
        }

        public string RemoveDigitFromNumber(int source, int digitToRemove)
        {
            return source
                .ToString()
                .Replace(digitToRemove.ToString(), string.Empty)
                .ToString();
        }
    }
}
