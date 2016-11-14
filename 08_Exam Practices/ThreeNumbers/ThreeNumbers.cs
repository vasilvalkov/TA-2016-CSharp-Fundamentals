using System;

class ThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int biggest = Math.Max(a, b);
        biggest = Math.Max(biggest, c);
        int smallest = Math.Min(a, b);
        smallest = Math.Min(smallest, c);
        double avg = (double)(a + b + c) / 3;

        Console.WriteLine(biggest);
        Console.WriteLine(smallest);
        Console.WriteLine("{0:F2}", avg);
    }
}