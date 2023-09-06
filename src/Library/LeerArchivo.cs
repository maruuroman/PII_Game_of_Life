using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class LeerArchivo
    {
        // Este método se encarga de leer un archivo y crear un tablero.
        // Cumple con SRP para la lectura de archivos y creación de tablero
        //Cumple con exper porque esta relacionado a la lectura del juego

        public static Board TableroNuevo()
        {    
            string url = "board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            } 
            Board board1 = new Board(board);
            return board1;
              
        }
    }
}