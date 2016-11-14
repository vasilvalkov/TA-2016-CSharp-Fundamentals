using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        int elemCount = int.Parse(Console.ReadLine());
        int[] arr = new int[elemCount];
        List<int> arrList = new List<int>();

        for (int i = 0; i < elemCount; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= arr.Length / 2; i++)
        {
            for (int j = 0; j < arr.Length - 2; j+=2)
            {
                if (arr[j] > arr[j + i])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + i];
                    arr[j + i] = temp;
                }
            }
        }

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}