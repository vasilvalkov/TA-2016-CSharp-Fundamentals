using System;

class SpiralMatrix
{
    static void Main()
    {
        uint size = uint.Parse(Console.ReadLine());
        uint[,] matrix = new uint[100, 100];
        char direction = 'r';
        uint row = 0;
        uint column = 0;

        for (uint i = 0; i < size * size; i++)
        {
            matrix[row, column] = i + 1;
            switch (direction)
            {
                case 'r':
                    if (column >= size - 1 || matrix[row, column + 1] != 0) direction = 'd';
                    break;
                case 'd':
                    if (row >= size - 1 || matrix[row + 1, column] != 0) direction = 'l';
                    break;
                case 'l':
                    if (column <= 0 || matrix[row, column - 1] != 0) direction = 'u';
                    break;
                case 'u':
                    if (row <= 0 || matrix[row - 1, column] != 0) direction = 'r';
                    break;
            }
            switch (direction)
            {
                case 'r':
                    column++;
                    break;
                case 'd':
                    row++;
                    break;
                case 'l':
                    column--;
                    break;
                case 'u':
                    row--;
                    break;
            }
        }

        for (uint i = 0; i < size; i++)
        {
            for (uint j = 0; j < size; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
