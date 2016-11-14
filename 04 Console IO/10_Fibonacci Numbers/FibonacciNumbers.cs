using System;

class FibonacciNumbers
{
    static void Main()
    {
        byte membersCount = byte.Parse(Console.ReadLine());
        ulong previousNum = 0;
        ulong currentNum = 1;
        ulong nextNum = 1;

        if (membersCount == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.Write("0, ");

            for (byte i = 1; i < membersCount - 1; i++)
            {
                Console.Write("{0}, ", nextNum);
                nextNum = previousNum + currentNum;
                previousNum = currentNum;
                currentNum = nextNum;
            }

            Console.WriteLine("{0}", nextNum);
        }
        
    }
}