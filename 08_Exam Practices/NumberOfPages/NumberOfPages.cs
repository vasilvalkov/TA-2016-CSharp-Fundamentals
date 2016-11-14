using System;

class NumberOfPages
{
    static void Main()
    {
        int digits = int.Parse(Console.ReadLine());
        int pages = 0;

        for (int page = 1; digits != 0; page++)
        {
            digits -= page.ToString().Length;
            pages++;
        }

        Console.WriteLine(pages);
    }
}