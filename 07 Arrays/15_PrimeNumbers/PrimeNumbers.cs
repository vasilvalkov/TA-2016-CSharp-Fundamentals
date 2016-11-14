using System;

class PrimeNumbers
{
    static void Main()
    {
        //INITIALIZE INPUT AND VARIABLES
        ulong num = ulong.Parse(Console.ReadLine());
        bool[] arr = new bool[num + 1];
        ulong x = 1;
        for (ulong i = 0; i <= num; i++)            // Populate bool array with true
        {
            arr[i] = true;
        }
        // FIND ALL PRIME INDICES USING THE SIEVE OF ERATOSTHENES ALGO
        for (ulong i = 2; i <= Math.Sqrt(num); i++)
        {
            if (arr[i])
            {
                for (ulong j = i * i; j <= num; j = i*i + x*i)
                {
                    arr[j] = false;
                    x++;
                }
                x = 1;
            }
        }
        // FIND THE LARGEST PRIME NUMBER THAT IS SMALLER THAN INPUT NUM
        for (ulong i = num; i >= 0; i--)
        {
            if (arr[i])
            {
                Console.WriteLine(i); break;
            }
        }
    }
}