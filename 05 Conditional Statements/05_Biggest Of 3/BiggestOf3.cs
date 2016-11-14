using System;

class BiggestOf3
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggest;

        if (a > b && a > c)
        {
            biggest = a;
        }
        else if (b > a && b > c)
        {
            biggest = b;
        }
        else
        {
            biggest = c;
        }

        Console.WriteLine(biggest);
    }
}