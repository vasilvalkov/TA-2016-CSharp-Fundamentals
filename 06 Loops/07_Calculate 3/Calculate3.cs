using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());
        int diffenveNK = n - k;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialDiff = 1;
        BigInteger result;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorialK *= i;
            }

            if (i <= diffenveNK)
            {
                factorialDiff *= i;
            }

            factorialN *= i;
        }

        result = factorialN / (factorialK * factorialDiff);

        Console.WriteLine(result);
    }
}