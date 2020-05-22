using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Module3_2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
    }

    public class Task4
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        {
            if (int.TryParse(input, out result) && (result >= 0))
            {
                return true;
            }

            return false;
        }

        public int[] GetFibonacciSequence(int n)
        {
            if (n <= 0)
            {
                return new int[0];
            }

            return GetFibonacciNums().TakeWhile((el, index) => index < n).ToArray();
        }

        public static IEnumerable<int> GetFibonacciNums()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                yield return current;
                var temp = next;
                next = current + next;
                current = temp;
            }
        }
    }

    public class Task5
    {
        public int ReverseNumber(int sourceNumber)
        {
            var charArray = sourceNumber.ToString().ToCharArray();

            Array.Reverse(charArray);
            var str = new string(charArray);

            if (str[str.Length-1] == '-')
            {
                str = '-' + str.Remove(str.Length - 1);
            }

            return int.Parse(str);
        }
    }

    public class Task6
    {
        /// <summary>
        /// Use this method to generate array. It shouldn't throws exception.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] GenerateArray(int size)
        {
            if (size <= 0)
            {
                return new int[0];
            }

            var lineArray = new int[size];

            for (var i = 0; i < lineArray.Length; i++)
            {
                lineArray[i] = i;
            }

            return lineArray;
        }

        public int[] UpdateElementToOppositeSign(int[] source)
        {
            for (var i = 0; i < source.Length; i++)
            {
                source[i] *= -1;
            }

            return source;
        }
    }

    public class Task7
    {
        /// <summary>
        /// Use this method to generate array. It shouldn't throws exception.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] GenerateArray(int size)
        {
            if (size <= 0)
            {
                return new int[0];
            }

            var lineArray = new int[size];

            for (var i = 0; i < lineArray.Length; i++)
            {
                lineArray[i] = i;
            }

            return lineArray;
        }

        public List<int> FindElementGreaterThenPrevious(int[] source)
        {
            if (source.Length < 2)
            {
                return default;
            }

            var resultSource = new List<int>();

            for (int i = 0; i < source.Length - 1; i++)
            {
                if (source[i] < source[i + 1])
                {
                    resultSource.Add(source[i + 1]);
                }
            }

            return resultSource;
        }
    }

    public class Task8
    {
        public int[,] FillArrayInSpiral(int size)
        {
            if (size < 1)
            {
                return new int[0, 0];
            }

            if (size == 1)
            {
                return new int[1, 1] { { 1 } };
            }

            var squareArray = new int[size, size];

            var spiralValue = 1;
            var squareSizeMax = size - 1;
            var squareSizeMin = 0;

            while (CheckZeros(squareArray))
            {
                for (var i = squareSizeMin; i < squareSizeMax; i++)
                {
                    squareArray[squareSizeMin, i] = spiralValue++;
                }

                for (var j = squareSizeMin; j < squareSizeMax; j++)
                {
                    squareArray[j, squareSizeMax] = spiralValue++;
                }

                for (var i = squareSizeMax; i > squareSizeMin; i--)
                {
                    squareArray[squareSizeMax, i] = spiralValue++;
                }

                for (var j = squareSizeMax; j > squareSizeMin; j--)
                {
                    squareArray[j, squareSizeMin] = spiralValue++;
                }

                squareSizeMax--;
                squareSizeMin++;

                if (squareSizeMax == squareSizeMin)
                {
                    break;
                }
            }

            if (size % 2 == 1)
            {
                squareArray[(size - 1) / 2, (size - 1) / 2] = spiralValue;
            }

            return squareArray;
        }

        private static bool CheckZeros(int[,] arr)
        {
            foreach(var i in arr)
            {
                if (i == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
