using System;

class BinarySearch
{
    static void Main()
    {
        // READ INPUT AND INITIALIZE VARIABLES
        int elemCount = int.Parse(Console.ReadLine());
        int[] arr = new int[elemCount];
        // Populate array
        for (int i = 0; i < elemCount; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int numberX = int.Parse(Console.ReadLine());
        int index = -1;
        decimal left = 0;
        decimal right = elemCount - 1;
        int mid;
        // FIND NUMBER X USING BINARY SEARCH ALGORHYTHM
        // Sort the array
        for (int j = 0; j < elemCount - 1; j++)
        {
            for (int i = 1; i < elemCount; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
            }
        }
        // Binary search
        while (left <= right)
        {
            mid = (int)Math.Floor((left + right) / 2);

            if (arr[mid] == numberX)
            {
                index = mid; break;
            }
            else
            {
                if (arr[mid] < numberX)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        // PRINT RESULT
        Console.WriteLine(index);
    }
}