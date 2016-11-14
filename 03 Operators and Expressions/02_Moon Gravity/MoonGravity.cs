using System;

namespace _02_Moon_Gravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            float weight = float.Parse(Console.ReadLine());
            float moonWeight = (weight * 17) / 100;

            Console.WriteLine("{0:F3}", moonWeight);
        }
    }
}
