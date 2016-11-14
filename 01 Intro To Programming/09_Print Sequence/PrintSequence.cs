using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i += 2)
        {
            Console.WriteLine(i);
            Console.WriteLine((i + 1) * -1);
        }
    }
}