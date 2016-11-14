using System;

class MatrixOfNumbers
{
    static void Main()
    {
        byte input = byte.Parse(Console.ReadLine());

        for (int i = 1, j = 1; i <= (input * 2) - 1; i++, j++)
        {
            if (j <= input)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                i -= input;
                j = 0;
                Console.Write("\b\n");
            }
        }

        Console.Write("\b\n");

        //for (int i = 0; i < input; i++)
        //{
        //    for (int j = 1; j <= input; j++)
        //    {
        //        Console.Write("{0} ", i + j);
        //    }

        //    Console.WriteLine("\b");
        //}
    }
}