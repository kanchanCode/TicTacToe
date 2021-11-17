using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        char[] Board = new char[10];
        public void gameBase()
        {
           for(int i = 1; i <= 9; i++)
          {
                Board[i] = ' ';
          }
       }
    }   
}
