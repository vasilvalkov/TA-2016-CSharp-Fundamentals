using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input.Length >= 3)
        {
            string sub = input.Remove(input.Length - 2);
            char thirdDigit = sub[sub.Length - 1];
            Console.WriteLine(thirdDigit == '7' ? "true" : "false {0}", thirdDigit);
        }
        else
        {
            Console.WriteLine("false 0");
        }
    }
}