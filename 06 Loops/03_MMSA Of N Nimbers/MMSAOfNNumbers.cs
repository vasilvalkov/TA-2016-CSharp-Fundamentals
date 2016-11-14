using System;

class MMSAOfNNumbers
{
    static void Main()
    {
        ushort count = ushort.Parse(Console.ReadLine());
        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double number;
        ushort counter = 0;

        do
        {
            number = double.Parse(Console.ReadLine());

            if (min > number)
            {
                min = number;
            }
            if (max < number)
            {
                max = number;
            }

            sum += number;
            counter++;

        } while (counter != count);
        
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", sum / count);
    }
}