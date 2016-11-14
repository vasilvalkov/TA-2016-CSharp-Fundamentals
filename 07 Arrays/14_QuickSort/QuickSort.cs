using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        // INITIALIZE INPUT AND VARIABLES
        int elemCount = int.Parse(Console.ReadLine());
        int[] arr = new int[elemCount];
        for (int i = 0; i < elemCount; i++)             // Populate array
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int pivot = arr[arr.Length - 1];
        int wall = 0;
        int current = -1;
        int max = arr[0];
        // IMPLEMENT QUICK SORT ALGO
        //int left = 0;
        //int right = arr.Length - 1;
        //pivot = 0;

        //while (true)
        //{
        //    while (arr[right] > arr[pivot])
        //    {
        //        right--;
        //    }
        //    if (arr[right] < arr[pivot])
        //    {
        //        int temp = arr[right];
        //        arr[right] = arr[pivot];
        //        arr[pivot] = temp;
        //        pivot = right;
        //    }

        //    while (arr[left] < arr[pivot])
        //    {
        //        left++;
        //    }
        //    if (arr[left] > arr[pivot])
        //    {
        //        int temp = arr[left];
        //        arr[left] = arr[pivot];
        //        arr[pivot] = temp;
        //        pivot = left;
        //    }

        //    if (pivot == left && pivot != right)
        //    {
        //        right--;
        //    }
        //    if (pivot == right && pivot != left)
        //    {
        //        left++;
        //    }

        //    if (left == right && left == pivot)
        //    {
        //        left = 0;
        //        right--;
        //        pivot = 0;
        //    }

        //    if ((left == right && left == 0) ||
        //        (left == right && right == arr.Length - 1))
        //    {
        //        break;
        //    }
        //}
        
        while (true)
        {
            for (int j = 1; j < arr.Length; j++)
            {   // Find the max value in array
                if (max < arr[j])
                {
                    max = arr[j];
                }
            }
            if (pivot == max)
            {   // If max is at end of array, select new pivot at end - 1
                pivot = arr[arr.Length - 2];
            }
            // Quick sort the array
            for (int i = 0; i < arr.Length; i++)
            {
                current = wall;
                
                while (arr[current] > pivot)
                {   // Skip numbers greater than pivot
                    if (current < arr.Length - 1)
                    {
                        ++current;
                    }
                    else break;
                }
                
                if (arr[current] < pivot)
                {   // Swap smaller number with the wall and increment the wall
                    int temp = arr[wall];
                    arr[wall] = arr[current];
                    arr[current] = temp;
                    wall++;
                }
                // If pivot reached swap pivot with wall and new pivot = former wall value
                // Former pivot is now at ordered position
                if (current == arr.Length - 1)
                {
                    int temp = arr[wall];
                    arr[wall] = pivot;
                    pivot = temp;
                    wall++;
                }
            }
            if (arr[current] == pivot || arr[current] == max)
            {
                break;
            }
        }
        // PRINT SORTED ARRAY
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}