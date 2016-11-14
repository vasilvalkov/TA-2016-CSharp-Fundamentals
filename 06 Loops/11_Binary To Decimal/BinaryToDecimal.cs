using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        int len = input.Length;
        long inputDec = 0;

        for (int i = len - 1, j = 0; i >= 0; i--, j++)
        {
            if (input[i] == '1')
            {
                inputDec += (long)Math.Pow(2,j);
            }
        }

        Console.WriteLine(inputDec);
    }
}