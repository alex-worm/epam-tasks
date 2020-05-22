using System;
using System.Linq;
using Module1;

namespace M1
{
    public class Module1
    {
        static void Main(string[] args)
        {
            var module = new Module1();

            module.SwapItems(1, 2);

            module.GetMinimumValue(new int[] { 10, 20, 1 });
        }


        public int[] SwapItems(int a, int b)
        {
            (a, b) = (b, a);
            return new int[] { a, b };
        }

        public int GetMinimumValue(int[] input)
        {
            return input.Min();
        }
    }
}
