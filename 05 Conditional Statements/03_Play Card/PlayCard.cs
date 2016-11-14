using System;

class PlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        byte inputNum;
        bool isNum = byte.TryParse(input, out inputNum);
        bool isCard = (inputNum >= 2 && inputNum <= 10) || 
                      input == "J" || 
                      input == "K" || 
                      input == "Q" || 
                      input == "A";

        Console.WriteLine(isCard ? "yes " + input : "no " + input);
        //switch (input)
        //{
        //    case "3": Console.WriteLine("yes " + input); break;
        //    case "4": Console.WriteLine("yes " + input); break;
        //    case "5": Console.WriteLine("yes " + input); break;
        //    case "6": Console.WriteLine("yes " + input); break;
        //    case "7": Console.WriteLine("yes " + input); break;
        //    case "8": Console.WriteLine("yes " + input); break;
        //    case "9": Console.WriteLine("yes " + input); break;
        //    case "2": Console.WriteLine("yes " + input); break;
        //    case "10": Console.WriteLine("yes " + input); break;
        //    case "J": Console.WriteLine("yes " + input); break;
        //    case "Q": Console.WriteLine("yes " + input); break;
        //    case "K": Console.WriteLine("yes " + input); break;
        //    case "A": Console.WriteLine("yes " + input); break;
        //    default:
        //        Console.WriteLine("no " + input);
        //        break;
        //}
    }
}