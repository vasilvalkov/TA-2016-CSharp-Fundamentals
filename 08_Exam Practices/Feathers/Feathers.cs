using System;

class Feathers
{
    static void Main()
    {
        double birds = double.Parse(Console.ReadLine());
        double feathers = double.Parse(Console.ReadLine());
        double evenMagic = 123123123123;
        double oddMagic = 317;
        double avg = feathers / birds;
        double result;

        if (birds % 2 == 0)
        {
            result = avg * evenMagic;
        }
        else
        {
            result = avg / oddMagic;
        }

        Console.WriteLine("{0:F4}", result);

    }
}