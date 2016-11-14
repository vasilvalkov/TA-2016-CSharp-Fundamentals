using System;

class Decoding
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        char[] textChar = text.ToCharArray();
        double encoded = 0;

        for (int ch = 0; ch < textChar.Length; ch++)
        {
            if (textChar[ch] == '@')
            {
                break;
            }

            if ((65 <= textChar[ch] && textChar[ch] <= 90) ||
                 97 <= textChar[ch] && textChar[ch] <= 122)
            {
                encoded = textChar[ch] * salt + 1000;
            }
            else if (48 <= textChar[ch] && textChar[ch] <= 57)
            {
                encoded = textChar[ch] + salt + 500;                
            }
            else
            {
                encoded = textChar[ch] - salt;
            }

            if (ch % 2 == 0)
            {
                Console.WriteLine("{0:F2}", (encoded / 100));
            }
            else
            {
                Console.WriteLine(encoded * 100);
            }            
        }
    }
}