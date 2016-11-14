using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        int[] secondArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;

        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                areEqual = false;
                break;
            }
        }

        Console.WriteLine(areEqual ? "Equal" : "Not equal");
    }
}