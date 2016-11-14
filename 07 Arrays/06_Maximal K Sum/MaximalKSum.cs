using System;

class MaximalKSum
{
    static void Main()
    {
        // read input data
        int elemCount = int.Parse(Console.ReadLine());
        int kElem = int.Parse(Console.ReadLine());
        int kSum = 0;
        int[] arr = new int[elemCount];
        // populate array
        for (int i = 0; i < elemCount; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        // sort array
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
        // find max sum of k lagrest elemnets
        for (int i = elemCount - kElem; i < elemCount; i++)
        {
            kSum += arr[i];
        }
        // print sum
        Console.WriteLine(kSum);
    }
}