using System;

class PeaceOfCake
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal result = (a / b) + (c / d);

        if (result >= 1m)
        {
            Console.WriteLine("{0}", Math.Floor(result));
        }
        else
        {
            Console.WriteLine("{0:F22}", result);
        }

        Console.WriteLine("{0}/{1}", (a * d) + (c * b), (b * d));
    }
}