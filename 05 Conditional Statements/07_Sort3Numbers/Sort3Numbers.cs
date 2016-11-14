using System;

    class Sort3Numbers
{
    static void Main()
    {
        short a = short.Parse(Console.ReadLine());
        short b = short.Parse(Console.ReadLine());
        short c = short.Parse(Console.ReadLine());

        if ((a >= b) && (a >= c))
        {
            Console.Write("{0} ", a);
            if (b > c)
            {
                Console.WriteLine("{0} {1}", b, c);
            }
            else if (b < c)
            {
                Console.WriteLine("{0} {1}", c, b);
            }
        }

        if ((b >= a) && (b >= c))
        {
            Console.Write("{0} ", b);
            if (a > c)
            {
                Console.WriteLine("{0} {1}", a, c);
            }
            else if (a < c)
            {
                Console.WriteLine("{0} {1}", c, a);
            }
        }

        if ((c >= a) && (c >= b))
        {
            Console.Write("{0} ", c);
            if (a > b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }
        }
    }
}