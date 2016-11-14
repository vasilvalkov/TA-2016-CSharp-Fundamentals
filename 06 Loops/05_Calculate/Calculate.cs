using System;

class Calculate
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double factorial = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / Math.Pow(x,i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}