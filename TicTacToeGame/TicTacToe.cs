using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        char[] Board = new char[10];
        char X = 'X';
        char O = 'O';
        public void gameBase()
        {
            for(int i = 1; i < 9; i++)
            {
                Board[i] = ' ';
            }

        }

        public void inputs()
        {
            Console.WriteLine("Enter your choice O(capital O) or X(capital X");
            char userInput = Convert.ToChar(Console.ReadLine());

            if (userInput == 'X')
            {
                Console.WriteLine("Computer Input is "+O);
            }
            else 
            {
                Console.WriteLine("Computer Input is "+X);
            }
   
        }

        public void boardDisplay()
        {
     
            Console.WriteLine("     |      |     ");
            Console.WriteLine("-----|------|-----");
            Console.WriteLine("     |      |     ");
            Console.WriteLine("-----|------|-----");
            Console.WriteLine("     |      |     ");
            Console.WriteLine("     |      |     ");
        }




    }

}
