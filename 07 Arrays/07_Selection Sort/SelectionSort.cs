using System;

class SelectionSort
{
    static void Main()
    {
        // READ INPUT
        int elemCount = int.Parse(Console.ReadLine());
        int[] arr = new int[elemCount];
        int iMin;
        // populate array
        for (int i = 0; i < elemCount; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        // SORT ARRAY WITH SELECTION SORT ALGORHYTHM
        for (int i = 0; i < elemCount; i++)
        {
            // define selection start
            iMin = i;
            // find index of the smallest element int the selection from i to end
            for (int j = i + 1; j < elemCount; j++)
            {
                if (arr[iMin] > arr[j])
                {
                    iMin = j;
                }
            }
            // swap element i with smallest element in selection
            if (iMin != i)
            {
                int temp = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = temp;
            }
        }
        // PRINT SORTED ARRAY
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}