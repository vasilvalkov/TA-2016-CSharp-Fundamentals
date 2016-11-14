using System;

class OddOrEven
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        bool isEven = input % 2 == 0;

        Console.WriteLine( isEven ? "even " + input
                                  : "odd " + input);
    }
}