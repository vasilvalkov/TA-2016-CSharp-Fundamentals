using System;

class DecimalToBinary
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string inputDec = "";
        long modifiedInput = input;
        int index = 0;

        for (int i = 31; i >= 0; i--)
        {
            long power = (long)Math.Pow(2, i);

            if (modifiedInput / power >= 1)
            {
                inputDec = inputDec.Insert(index, "1");
                modifiedInput -= power;
                index++;
            }
            else
            {
                inputDec = inputDec.Insert(index, "0");
                index++;
            }
        }

        Console.WriteLine(inputDec.TrimStart('0'));
    }
}