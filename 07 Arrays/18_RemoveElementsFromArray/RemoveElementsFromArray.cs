using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        // INITIALIZE INPUT AND VARIALBES
        int elemCount = int.Parse(Console.ReadLine());
        int[] arr = new int[elemCount];
        for (int i = 0; i < elemCount; i++)     // Populate array.
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] seqLengths = new int[elemCount];  // Here we store lenghts of subsequences.
        seqLengths[0] = 1;                      // Shortest length is 1 at [0].
        int maxElCount = 0;                     // Counter for subsequence length.
        int index = -1;                         // Will help continue subsequence.
        // FIND LONGEST SUBSEQUENCE
        for (int i = 1; i < arr.Length; i++)
        {
            /* if i >= i - 1 => find index with biggest length such that arr[index] <= arr[i]
             *      then seqLengths[i] = seqLengths[index] + 1;
             *      
             * if i < i - 1 => find index with biggest length such that arr[index] <= arr[i]
             *      then seqLengths[i] = seqLengths[index] + 1;
             *      if no such index found, this is only beginning of a new length
             *      then seqLengths[i] = 1;  */
            for (int k = 0; k < i; k++)
            {
                if (seqLengths[k] > maxElCount && arr[k] <= arr[i])
                {
                    if (seqLengths[k] > maxElCount)
                    {
                        maxElCount = seqLengths[k];
                    }
                    index = k;
                }
            }

            if (index < 0)                              // True begins a new subsequence
            {
                seqLengths[i] = 1;
                index = i;
            }
            else
            {
                seqLengths[i] = seqLengths[index] + 1;  // Continue the longest subsequence possible with current i
            }
            maxElCount = 0;                             // Initialize counter for the next search
            index = -1;                                 // Initialize index
        }

        maxElCount = 0;                                 // Initialize counter

        for (int k = 0; k < seqLengths.Length; k++)     // Search for the longest subseq
        {
            if (seqLengths[k] > maxElCount)
            {
                maxElCount = seqLengths[k];
            }
        }
        // PRINT RESULT
        Console.WriteLine(arr.Length - maxElCount);
    }
}