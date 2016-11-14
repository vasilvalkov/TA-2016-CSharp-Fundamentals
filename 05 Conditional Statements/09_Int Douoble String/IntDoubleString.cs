using System;

class IntDoubleString
{
    static void Main()
    {
        string inputFormat = Console.ReadLine();
        string input = Console.ReadLine();

        switch (inputFormat)
        {
            case "integer": Console.WriteLine((int.Parse(input) + 1)); break;
            case "real": Console.WriteLine("{0:F2}", (double.Parse(input) + 1.0)); break;
            case "text": Console.WriteLine("{0}*", input); break;
            default:
                break;
        }

        //if ((inputFormat == "integer") || (inputFormat == "real"))
        //{
        //    Console.WriteLine((double.Parse(input) + 1));
        //}
        //else if (inputFormat == "text")
        //{
        //    Console.WriteLine("{0}*", input);
        //}
    }
}