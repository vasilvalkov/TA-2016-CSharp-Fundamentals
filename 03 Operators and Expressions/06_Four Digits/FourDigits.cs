using System;

class FourDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        string a = input[0].ToString();
        string b = input[1].ToString();
        string c = input[2].ToString();
        string d = input[3].ToString();

        int sum = input[0] + input[1] + input[2] + input[3] - 48*4;

        Console.WriteLine(sum);
        Console.WriteLine(d + c + b + a);
        Console.WriteLine(d + a + b + c);
        Console.WriteLine(a + c + b + d);
    }
}