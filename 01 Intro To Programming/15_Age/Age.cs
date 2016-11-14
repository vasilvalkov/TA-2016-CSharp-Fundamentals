using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        DateTime birthDate = Convert.ToDateTime(Console.ReadLine(), CultureInfo.InvariantCulture);
        DateTime today = DateTime.Today;
        byte age = (byte)(today.Year - birthDate.Year);
        
        if (age > 0 && today.Month < birthDate.Month && today.Day < birthDate.Day)
        {
            Console.WriteLine(--age);
            Console.WriteLine(age + 10);
        }
        else
        {
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
