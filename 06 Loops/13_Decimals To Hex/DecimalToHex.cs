using System;

class DecimnalToHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long divident = input;
        long divisor = 16;
        long quotient = divident / divisor;
        string inputHex = "";
        string value = null;
        long remainder;

        while (divident >= 1)
        {
            // calculate the remainder
            remainder = divident - (quotient * 16);
            // get the base 16 value of remainder and assign it to value
            switch (remainder)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    value = remainder.ToString(); break;
                case 10: value = "A"; break;
                case 11: value = "B"; break;
                case 12: value = "C"; break;
                case 13: value = "D"; break;
                case 14: value = "E"; break;
                case 15: value = "F"; break;
                default:
                    break;
            }
            // always add the value to the hex string at index 0
            inputHex = inputHex.Insert(0, value);
            // next divident will be the current quotient
            divident = quotient;
            // calculate the next quotient
            quotient = divident / divisor;
            // repeat the calculations until divident >= 1
        }

        Console.WriteLine(inputHex);
    }
}