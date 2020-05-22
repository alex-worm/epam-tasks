using Module4;
using System.Collections.Generic;

namespace Module4Tests
{
    public static class TestCaseSource
    {
        public static IEnumerable<TestCaseValues> TestsCases = new List<TestCaseValues>()
        {
            new TestCaseValues((x=>x*x-4), -5, 0, 0.001, -2),
            new TestCaseValues((x=>x*x- 4), 0, 5, 0.001, 2)            
        };
    }
}
