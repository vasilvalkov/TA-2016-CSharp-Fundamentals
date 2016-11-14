using System;

namespace _14_Print_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
