using System;

class SumOfNNumbers
{
    static void Main()
    {
        byte numbCount = byte.Parse(Console.ReadLine());
        float sum = 0;

        for (int i = 1; i <= numbCount; i++)
        {
            float num = float.Parse(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine(sum);
    }
}