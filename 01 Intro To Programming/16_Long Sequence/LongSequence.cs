using System;

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i += 2)
        {
            Console.WriteLine(i);
            Console.WriteLine((i + 1) * -1);
        }
    }
}