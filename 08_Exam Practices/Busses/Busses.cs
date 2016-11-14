using System;

class Busses
{
    static void Main()
    {
        int busCount = int.Parse(Console.ReadLine());
        int[] speeds = new int[busCount];
        int groups = 1;
        int currentSpeed;

        for (int i = 0; i < busCount; i++)
        {
            speeds[i] = int.Parse(Console.ReadLine());
        }

        currentSpeed = speeds[0];

        for (int i = 1; i < speeds.Length; i++)
        {
            if (currentSpeed >= speeds[i])
            {
                currentSpeed = speeds[i];
                groups++;
            }
        }
        
        Console.WriteLine(groups);
    }
}