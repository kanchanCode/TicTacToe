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
            Console.WriteLine("    "+  Board[1]+ " | "+   Board[2] +"     |"+   Board[3]);
            Console.WriteLine("-----|------|-----");
            Console.WriteLine("     |      |     ");
            Console.WriteLine("    " + Board[4] + " | " + Board[5] + "     |" + Board[6]);
            Console.WriteLine("-----|------|-----");
            Console.WriteLine("     |      |     ");
            Console.WriteLine("    " + Board[7] + " | " + Board[8] + "     |" + Board[9]);
            Console.WriteLine("     |      |     ");
        }




    }

}
