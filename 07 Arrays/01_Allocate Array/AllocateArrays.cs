using System;

class AllocateArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrayN = new int[n];

        for (int i = 0; i < arrayN.Length; i++)
        {
            arrayN[i] = i * 5;
        }

        foreach (var item in arrayN)
        {
            Console.WriteLine(item);
        }
    }
}