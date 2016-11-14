using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        BigInteger factorial2N = 1;
        BigInteger factorialN = 1;
        BigInteger factorialNPlus1 = 1;
        BigInteger result;

        for (int i = 1; i <= n * 2; i++)
        {
            if (i <= n)
            {
                factorialN *= i;
            }

            if (i <= n + 1)
            {
                factorialNPlus1 *= i;
            }

            factorial2N *= i;
        }

        result = factorial2N / (factorialNPlus1 * factorialN);

        Console.WriteLine(result);
    }
}