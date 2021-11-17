using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic-Tac-Toe!");

            TicTacToe obj1 = new TicTacToe();
            obj1.inputs();
            obj1.boardDisplay();

        }
    }
}
