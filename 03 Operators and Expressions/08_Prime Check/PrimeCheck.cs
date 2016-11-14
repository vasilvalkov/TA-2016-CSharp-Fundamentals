using System;

class PrimeCheck
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (input > 1)
        {
            double maxDivider = Math.Sqrt(input);

            for (int i = 2; i <= maxDivider; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                }
            }
        }
        else
        {
            isPrime = false;
        }       

        Console.WriteLine(isPrime ? "true" : "false");
    }
}