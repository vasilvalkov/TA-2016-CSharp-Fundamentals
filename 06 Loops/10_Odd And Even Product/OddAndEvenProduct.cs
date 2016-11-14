using System;

class OddAndEvenProduct
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] numbersSplit = numbers.Split(' ');
        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= long.Parse(numbersSplit[i]);
            }
            else
            {
                evenProduct *= long.Parse(numbersSplit[i]);
            }
            
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }

    }
}