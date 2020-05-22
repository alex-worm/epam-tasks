using System;

namespace Module4
{
    public class TestCaseValues
    {
        public TestCaseValues(Func<double, double> func, double x1, double x2, double e, double expected)
        {
            this.Func = func;
            this.X1 = x1;
            this.X2 = x2;
            this.E = e;
            this.Expected = expected;
        }

        public double X1 { get; private set; }
        public double X2 { get; private set; }
        public double E { get; private set; }
        public double Expected { get; private set; }
        public Func<double, double> Func { get; private set; }

    }
}
