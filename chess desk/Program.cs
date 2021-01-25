using System;

namespace chess_desk
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }

        private static void WriteBoard(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(((i + j) % 2 == 0) ? "#" : ".");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
