using System;

class BitSwap
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte q = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());
        // prepare mask for positions p... p+k-1 and verify it will not overflow
        uint maskP = (p + k) >= 32 ? (1U << p + k) - (1U << p) - (uint)(p + k - 31)
                                   : (1U << p + k) - (1U << p);
        // clear positions p... p+k-1 of n, so we can modify them later
        uint modifiedN = n & ~maskP;
        // prepare mask for positions q... q+k-1 and verify it will not overflow
        uint maskQ = (q + k) >= 32 ? (1U << q + k) - (1U << q) - (uint)(q + k - 31)
                                   : (1U << q + k) - (1U << q);
        // clear positions q... q+k-1 of n
        modifiedN = modifiedN & ~maskQ;
        // copy bits p... p+k-1 of n and shift them to positions q... q+k-1
        maskP = p > q ? (n & maskP) >> Math.Abs(p - q)
                      : (n & maskP) << Math.Abs(p - q);
        // copy bits q... q+k-1 of n and shift them to positions p... p+k-1
        maskQ = p > q ? (n & maskQ) << Math.Abs(p - q)
                      : (n & maskQ) >> Math.Abs(p - q);
        // merge masks and copy them to modifiedN 
        modifiedN |= maskP | maskQ;

        Console.WriteLine(modifiedN);
    }
}