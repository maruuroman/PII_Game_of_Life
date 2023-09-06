using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Board
    {
        //Esta clase representa el tablero del juego 
        // Cumple con expert ya que toda la información esta relacionada unicamente al tablero
        // Cumple con SRP porque es responsable de almacenar el tablero
        public bool [,] Tablero { get; set;}

        public Board(bool[,] tablero)
        {
            this.Tablero= tablero;
        }
    }
}