using System;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = (width + height) * 2;

        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
    }
}
