using System;

class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double dist = Math.Sqrt(Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2));

        Console.Write(dist <= 1.5
                      ? "inside circle "
                      : "outside circle ");

        Console.WriteLine(x >= -1 &&
                          x <= 5 &&
                          y >= -1 &&
                          y <= 1
                          ?
                          "inside rectangle"
                          :
                          "outside rectangle");
    }
}
