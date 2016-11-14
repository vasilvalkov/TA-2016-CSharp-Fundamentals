using System;

class NumbersFrom1toN
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());

        for (int i = 1; i < input; i++)
        {
            Console.Write("{0} ", i);
        }

        Console.WriteLine(input);
    }
}