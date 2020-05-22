using System;
using System.Linq;
using System.Collections;

namespace M4
{
    public class Module4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }


        public int Task_1_A(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            return array.Max();
        }

        public int Task_1_B(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            return array.Min();
        }

        public int Task_1_C(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            return array.Sum();
        }

        public int Task_1_D(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            return array.Max() - array.Min();
        }

        public void Task_1_E(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            var arrayMax = array.Max();
            var arrayMin = array.Min();

            for (var i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] += arrayMax;
                    continue;
                }

                array[i] -= arrayMin;
            }
        }

        public int Task_2(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Task_2(int a, int b)
        {
            return a + b;
        }

        public double Task_2(double a, double b, double c)
        {
            return a + b + c;
        }

        public string Task_2(string a, string b)
        {
            return string.Concat(a, b);
        }

        public int[] Task_2(int[] a, int[] b)
        {
            var isFirstBiggerThenSecond = a.Length > b.Length;

            if (isFirstBiggerThenSecond)
            {
                var sumArray = new int[a.Length];

                for (var i = 0; i < sumArray.Length; i++)
                {
                    if (i >= b.Length)
                    {
                        sumArray[i] = a[i];
                        continue;
                    }
                    sumArray[i] = a[i] + b[i];
                }

                return sumArray;
            }
            else
            {
                var sumArray = new int[b.Length];

                for (var i = 0; i < sumArray.Length; i++)
                {
                    if (i >= a.Length)
                    {
                        sumArray[i] = b[i];
                        continue;
                    }
                    sumArray[i] = a[i] + b[i];
                }

                return sumArray;
            }
        }

        public void Task_3_A(ref int a, ref int b, ref int c)
        {
            a += 10;
            b += 10;
            c += 10;
        }

        public void Task_3_B(double radius, out double length, out double square)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("radius", " is less then zero");
            }

            length = 2 * Math.PI * radius;

            square = Math.PI * radius * radius;
        }

        public void Task_3_C(int[] array, out int maxItem, out int minItem, out int sumOfItems)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            maxItem = array.Max();
            minItem = array.Min();
            sumOfItems = array.Sum();
        }

        public (int, int, int) Task_4_A((int, int, int) numbers)
        {
            return (numbers.Item1 + 10, numbers.Item2 + 10, numbers.Item3 + 10);
        }

        public (double, double) Task_4_B(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("radius", " is less then zero");
            }

            return (2 * Math.PI * radius, Math.PI * radius * radius);
        }

        public (int, int, int) Task_4_C(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            return (array.Min(), array.Max(), array.Sum());
        }

        public void Task_5(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            for (var i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }

        public void Task_6(int[] array, SortDirection direction)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("array", " is empty");
            }

            IComparer revComparer = new ReverseComparer();

            if (direction == SortDirection.Ascending)
            {
                Array.Sort(array);
            }
            else
            {
                Array.Sort(array, revComparer);
            }
        }      
        
        public class ReverseComparer : IComparer
        {
            public int Compare(Object x, Object y)
            {
                return (new CaseInsensitiveComparer()).Compare(y, x);
            }
        }

        public  double Task_7(Func<double, double> func, double x1, double x2, double e, double result = 0)
        {
            result = (x1 + x2) / 2;

            if (func(result) * func(x1) < 0)
            {
                x2 = result;
            }
            else
            {
                x1 = result;
            }

            if (Math.Abs(x2 - x1) > 2 * e)
            {
                Task_7(func, x1, x2, e);
            }

            return result;
        }
    }
}
