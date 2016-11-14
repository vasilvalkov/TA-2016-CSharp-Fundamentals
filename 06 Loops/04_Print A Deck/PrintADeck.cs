using System;

class PrintADeck
{
    static void Main()
    {
        string input = Console.ReadLine();
        int card = 1;

        switch (input)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                card = int.Parse(input); break;
            case "10":
            case "T": card = 10; break;
            case "J": card = 11; break;
            case "Q": card = 12; break;
            case "K": card = 13; break;
            case "A": card = 14; break;
            default:
                break;
        }

        for (int i = 2; i <= card; i++)
        {
            if (i <= 10)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
            switch (i)
            {
                case 11:
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                    break;
                case 12:
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                    break;
                case 13:
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                    break;
                case 14:
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
                    break;
                default:
                    break;
            }
        }
    }
}