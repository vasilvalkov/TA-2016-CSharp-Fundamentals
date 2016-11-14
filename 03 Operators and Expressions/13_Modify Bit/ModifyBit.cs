using System;

class ModifyBit
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        byte value = byte.Parse(Console.ReadLine());

        ulong mask = 1UL << pos;
        ulong modifiedBit = value == 1 ? input | mask : input & ~mask;

        Console.WriteLine(modifiedBit);
    }
}