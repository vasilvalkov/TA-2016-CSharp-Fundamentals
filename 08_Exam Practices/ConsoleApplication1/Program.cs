using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        ulong number;
        BigInteger currentProd = BigInteger.One;
        BigInteger first10Prod = BigInteger.One;
        short numbersCount = 0;
        ulong remainder;
        bool input;

        do
        {
            input = ulong.TryParse(Console.ReadLine(), out number);
            if (!input)
                break;  // Break at END

            numbersCount++;

            if (numbersCount % 2 == 0)
            {   // Number is at an odd position (starting from 0)
                int len = number.ToString().Length;

                for (int i = 0; i < len; i++, number /= 10)
                {   // Find sum of the number`s digits
                    remainder = number % 10;

                    switch (remainder)
                    {
                        case 0: continue;   //Skip zeros
                        default: currentProd *= remainder; break;
                    }
                }

                if (numbersCount <= 10)
                {   // Get first 10 numbers` product when more numbers
                    first10Prod = currentProd;
                }
                if (numbersCount == 10)
                {
                    currentProd = 1;
                }
            }
        } while (true);
        // Print result
        if (numbersCount <= 10)
        {
            Console.WriteLine(first10Prod);
        }
        else
        {
            Console.WriteLine(first10Prod);
            Console.WriteLine(currentProd);
        }
    }
}