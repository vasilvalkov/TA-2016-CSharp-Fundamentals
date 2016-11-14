using System;

class NUmbersFrom1toN
{
    static void Main()
    {
        ushort input = ushort.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(i);
        }
    }
}