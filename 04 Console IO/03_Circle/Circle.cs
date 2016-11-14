using System;
class Circle
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * radius * 2;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}