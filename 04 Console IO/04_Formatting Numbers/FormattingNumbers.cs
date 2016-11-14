using System;

class FormattingNumbers
{
    static void Main()
    {
        ushort a = ushort.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine($"{a:X} |{Convert.ToString(a,2).PadLeft(10, '0')}| {b:F2} | {c:F3}");
    }
}