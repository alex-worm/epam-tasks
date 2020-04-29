using System;
using System.Collections.Generic;
using System.Text;

namespace Module2
{
    public class ConverterResult<T>
    {
        public T Value { get; set; }

        public bool IsOk { get; set; }
    }
}
