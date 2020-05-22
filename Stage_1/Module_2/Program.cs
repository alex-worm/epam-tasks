using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Module2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int GetTotalTax(int companiesNumber, int tax, int companyRevenue)
        {
            double allTaxes = companiesNumber * tax * 0.01 * companyRevenue;

            return (int) Math.Truncate(allTaxes);
        }

        public string GetCongratulation(int input)
        {
            if (input >= 18 && input % 2 == 0)
            {
                return "Поздравляю с совершеннолетием!";
            }
            else if (input <18 && input > 12 && input % 2 == 1)
            {
                return "Поздравляю с переходом в старшую школу!";
            }
            else return $"Поздравляю с {input}-летием!";
        }

        public double GetMultipliedNumbers(string first, string second)
        {
            var firstResult = Converter.ConvertToDouble(first);
            var secondResult = Converter.ConvertToDouble(second);

            if (firstResult.IsOk && secondResult.IsOk)
            {
                var firstNumber = firstResult.Value;
                var secondNumber = secondResult.Value;

                return firstNumber * secondNumber;
            }
            throw new ArgumentException("Invalid value of input");
        }

        public double GetFigureValues(Figure figureType, Parameter parameterToCompute, Dimensions dimensions)
        {
            switch (figureType)
            {
                case Figure.Circle:
                    if (parameterToCompute == Parameter.Perimeter)
                    {
                        double perimeter = dimensions.Diameter * Math.PI;
                        return Math.Truncate(perimeter);
                    }
                    else
                    {
                        double square = Math.Pow(dimensions.Radius, 2) * Math.PI;
                        return Math.Truncate(square);
                    }

                case Figure.Rectangle:
                    if (parameterToCompute == Parameter.Perimeter)
                    {
                        double perimeter = 2 * (dimensions.FirstSide + dimensions.SecondSide);
                        return Math.Truncate(perimeter);
                    }
                    else
                    {
                        double square = dimensions.FirstSide * dimensions.SecondSide;
                        return Math.Truncate(square);
                    }

                case Figure.Triangle:
                    if (parameterToCompute == Parameter.Perimeter)
                    {
                        double perimeter = dimensions.FirstSide + dimensions.SecondSide + dimensions.ThirdSide;
                        return Math.Truncate(perimeter);
                    }
                    else
                    {
                        double square = dimensions.FirstSide * dimensions.Height * 0.5;
                        if (square == 0)
                        {
                            var p = (dimensions.FirstSide + dimensions.SecondSide + dimensions.ThirdSide) * 0.5;
                            square = Math.Pow(p * (p - dimensions.FirstSide) * 
                                (p - dimensions.SecondSide) * (p - dimensions.ThirdSide), 0.5);
                        }
                        return Math.Truncate(square);
                    }

                default: 
                    throw new ArgumentException("Invalid value of input");
            }
        }
    }
}
