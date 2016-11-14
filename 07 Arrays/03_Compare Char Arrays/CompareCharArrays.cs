using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        char[] firstArr = firstInput.ToCharArray();
        char[] secondArr = secondInput.ToCharArray();

        int len = firstArr.Length <= secondArr.Length ? firstArr.Length : secondArr.Length;

        for (int i = 0; i < len; i++)
        {
            if (i == len - 1 && firstArr[i] == secondArr[i])
            {
                if (firstArr.Length < secondArr.Length)
                {
                    Console.WriteLine("<");
                    break;
                }
                if (firstArr.Length > secondArr.Length)
                {
                    Console.WriteLine(">");
                    break;
                }
                Console.WriteLine("=");
                break;
            }            
            else if (firstArr[i] > secondArr[i])
            {
                Console.WriteLine(">");
                break;
            }
            else if (firstArr[i] < secondArr[i])
            {
                Console.WriteLine("<");
                break;
            }
        } 
    }
}