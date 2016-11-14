using System;

class PointInCirlce
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        Console.WriteLine(dist > 2.00 ? "no "+ dist.ToString("F2") : "yes " + dist.ToString("F2"));
    }
}
