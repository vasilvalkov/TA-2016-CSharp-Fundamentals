using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger result;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorialK *= i;
            }

            factorialN *= i;
        }

        result = factorialN / factorialK;

        Console.WriteLine(result);
    }
}
