using System;

class AngryFemaleGPS
{
    static void Main()
    {
        // Initialize input and variables
        long input = long.Parse(Console.ReadLine());
        long number = input;
        long evenSum = 0;
        long oddSum = 0;
        int len = number.ToString().Length;
        // If number is negative, work with its absolute
        if (number < 0)
        {
            number = number * -1;
        }
        // Count the sums
        for (int i = 0; i < len; i++)
        {
            if (number % 2 == 0)
            {
                evenSum += number % 10;
            }
            else
            {
                oddSum += number % 10;
            }

            number /= 10;
        }
        // Give direction based on sums
        if (evenSum > oddSum)
        {
            Console.WriteLine("right {0}", evenSum);
        }
        if (evenSum < oddSum)
        {
            Console.WriteLine("left {0}", oddSum);
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("straight {0}", evenSum);
        }
    }
}