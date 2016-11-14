using System;

class IndexOfLetters
{
    static void Main()
    {
        // INITIALIZE INPUT AND VARIABLES
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(97 + i);
        }
        string input = Console.ReadLine();
        char[] inputArr = input.ToCharArray();
        // IMPLEMENTATION
        for (int i = 0; i < inputArr.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (inputArr[i] == alphabet[j])
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}