using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(input % 7 == 0 && input % 5 == 0 ? "true " + input 
                                                           : "false " + input);
    }
}
