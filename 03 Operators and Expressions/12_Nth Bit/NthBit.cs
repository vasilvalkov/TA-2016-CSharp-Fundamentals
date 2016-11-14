using System;

class Program
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        ulong mask = 1UL << pos;
        ulong bit = input & mask;

        Console.WriteLine(bit == 0 ? 0 : 1);
    }
}