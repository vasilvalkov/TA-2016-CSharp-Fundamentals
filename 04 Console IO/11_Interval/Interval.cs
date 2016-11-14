using System;

class Interval
{
    static void Main()
    {
        ushort a = ushort.Parse(Console.ReadLine());
        ushort b = ushort.Parse(Console.ReadLine());
        ushort count = 0;

        for (int i = a + 1; i < b; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}