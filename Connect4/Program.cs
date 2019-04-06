using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Board myBoard = new Board();

            myBoard.applyMove();
        }
    }
}
