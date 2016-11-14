using System;

class ThirdBit
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint bit = input & mask;

        Console.WriteLine(bit == 0 ? 0 : 1);
    }
}
