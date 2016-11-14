using System;

class MaximalSequence
{
    static void Main()
    {
        // read input
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];

        int maxSeq = 1;
        int currentSeq = 1;
        // populate array
        for (int i = 0; i < count; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        // search for max sequence
        for (int i = 1; i < count; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentSeq++;
            }
            else
            {
                currentSeq = 1;
            }

            if (maxSeq < currentSeq)
            {
                maxSeq = currentSeq;
            }            
        }
        // print maximal sequence length
        Console.WriteLine(maxSeq);
    }
}