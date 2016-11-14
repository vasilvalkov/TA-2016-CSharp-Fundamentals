using System;

class MaximalSum
{
    static void Main()
    {
        // READ INPUT AND INITIALIZE VARIABLES
        int elemCount = int.Parse(Console.ReadLine());
        int[] arr = new int[elemCount];
        int sum = 0;
        int maxSum = 0;
        // populate array
        for (int i = 0; i < elemCount; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        // FIND MAX SUM OF CONSEQUENTIAL ELEMENTS
        for (int i = 0; i < elemCount; i++)
        {
            if (sum + arr[i] >= 0)
            {
                sum += arr[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }             
            }
            else
            {                
                sum = 0;
            }
        }
        // PRINT SUM
        Console.WriteLine(maxSum);
    }
}