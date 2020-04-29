using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Module2
{
    public static class  Converter
    {
        public static ConverterResult<double> ConvertToDouble(string stringNumber)
        {
            if (stringNumber.Contains('.') &&
                Thread.CurrentThread.CurrentCulture.IetfLanguageTag == "ru-RU")
            {
                stringNumber = stringNumber.Replace('.', ',');
            }

            if (stringNumber.Contains(',') &&
                Thread.CurrentThread.CurrentCulture.IetfLanguageTag != "ru-RU")
            {
                stringNumber = stringNumber.Replace(',', '.');
            }

            if (double.TryParse(stringNumber, out double number))
            {
                return new ConverterResult<double>
                {
                    Value = number,
                    IsOk = true
                };
            }

            return ErrorMessage();
        }
        private static ConverterResult<double> ErrorMessage()
        {
            return new ConverterResult<double>
            {
                IsOk = false
            };
        }
    }
}
