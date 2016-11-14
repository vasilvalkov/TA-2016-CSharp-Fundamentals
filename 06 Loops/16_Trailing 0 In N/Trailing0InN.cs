using System;

class Trailing0InN
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong countZeros = 0;

        for (uint i = 1; i < n; i++)
        {
            countZeros += (ulong)(n / Math.Pow(5, i));
        }

        Console.WriteLine(countZeros);
    }
}