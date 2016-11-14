using System;

class BobbyAvokadoto
{
    static void Main()
    {
        uint head = uint.Parse(Console.ReadLine());
        uint combsCount = uint.Parse(Console.ReadLine());
        uint bestComb = 0;
        uint bestCount = 0;

        for (int i = 0; i < combsCount; i++)
        {
            uint comb = uint.Parse(Console.ReadLine());

            if ((head & comb) == 0)
            {
                uint currentCount = 0;

                for (int j = 0; j < 32 && (comb >> j) > 0; j++)
                {
                    currentCount += (comb >> j) & 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestComb = comb;
                }
            }
        }
        
        Console.WriteLine(bestComb);
    }
}