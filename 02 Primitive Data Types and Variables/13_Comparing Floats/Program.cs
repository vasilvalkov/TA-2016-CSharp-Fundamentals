using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine(), culture);
        double b = double.Parse(Console.ReadLine(), culture);
        double eps = 0.000001;
        bool areEven = Math.Abs(a - b) <= eps;

        Console.WriteLine(areEven ? "true" : "false");
    }
}
