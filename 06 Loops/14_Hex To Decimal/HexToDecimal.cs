using System;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        int len = input.Length;
        ulong value = 1;
        ulong inputDec = 0;
        ulong index = 0;

        for (int i = len - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    value = (ulong)(input[i] - 48); break;
                case 'A': value = 10; break;
                case 'B': value = 11; break;
                case 'C': value = 12; break;
                case 'D': value = 13; break;
                case 'E': value = 14; break;
                case 'F': value = 15; break;
                default:
                    break;
            }

            inputDec += value * (ulong)Math.Pow(16, index);
            index++;
        }

        Console.WriteLine(inputDec.ToString("F0"));
    }
}