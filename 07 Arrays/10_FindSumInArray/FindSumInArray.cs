using System;
using System.Collections.Generic;

class FindSumInArray
{
    static void Main()
    {
        // READ INPUT AND INITIALIZE VARIABLES
        string input = Console.ReadLine();
        int sum = int.Parse(Console.ReadLine());
        string[] inputSplit =  input.Split(',');
        int[] arrNum = new int[inputSplit.Length];
        List<int> sequence = new List<int>();
        int currentSum = 0;
        int sumReachedAtIndex = 0;

        // populate int array
        for (int i = 0; i < inputSplit.Length; i++)
        {
            arrNum[i] = int.Parse(inputSplit[i]);
        }
        // FIND SUM IN A SEQUENCE OF THE ARRAY
        for (int i = 0; i < arrNum.Length; i++)
        {
            currentSum += arrNum[i];
            if (currentSum > sum)
            {
                currentSum = arrNum[i];
            }
            if (currentSum == sum)
            {
                currentSum = 0;
                sumReachedAtIndex = i;
                break;
            }
        }
        while (currentSum < sum)
        {
            currentSum += arrNum[sumReachedAtIndex];
            sequence.Add(arrNum[sumReachedAtIndex]);
            sumReachedAtIndex--;
        }

        sequence.Reverse();
        // PRINT RESULT
        foreach (var item in sequence)
        {
            Console.Write("{0}, ", item);
        }
    }
}
