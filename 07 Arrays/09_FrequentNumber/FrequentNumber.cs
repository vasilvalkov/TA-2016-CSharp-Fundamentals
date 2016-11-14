using System;

class FrequentNumber
{
    static void Main()
    {
        // READ INPUT AND INITIALIZE VARIABLES
        int elemCount = int.Parse(Console.ReadLine());
        int[] arr = new int[elemCount];
        int freqNum = 0;
        int times = 0;
        int maxTimes = 0;
        // populate array
        for (int i = 0; i < elemCount; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        // FIND MOST FREQUENT NUMBER
        for (int i = 0; i < elemCount; i++)
        {
            foreach (var num in arr)
            {
                if (arr[i] == num)
                {
                    times++;
                    if (maxTimes < times)
                    {
                        maxTimes = times;
                        freqNum = arr[i];
                    }
                }
            }
            times = 0;
        }
        // PRINT RESULT
        Console.WriteLine("{0} ({1} times)", freqNum, maxTimes);
    }
}
