using System;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbersSplit = input.Split(' ');
        int firstNum = int.Parse(numbersSplit[0]);
        int secondNum = int.Parse(numbersSplit[1]);
        int divident = 1;
        int divisor = 1;

        if (firstNum >= secondNum)
        {
            divident = firstNum;
            divisor = secondNum;
        }
        else
        {
            divident = secondNum;
            divisor = firstNum;
        }

        int quotient = divident / divisor;
        int remainder = divident % divisor;

        while (remainder > 0)
        {
            divident = divisor;
            divisor = remainder;
            quotient = divident / divisor;
            remainder = divident % divisor;
        }

        Console.WriteLine(divisor);
    }
}