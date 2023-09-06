using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero 
    {
        // Esta clase hace operaciones lógicas y se encarga de imprimir el tablero.
        // Cumple con SRP para imprimir el tablero.
        public static Board ImpTablero(Board tablero1)
        {
            bool[,] b = tablero1.Tablero; //variable que representa el tablero
            int width= b.GetLength(0); //variabe que representa el ancho del tablero
            int height = b.GetLength(1); //variabe que representa altura del tablero
        
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            //=================================================
            tablero1 = Logica.LogicaJuego(tablero1) ;                //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
            return tablero1;
        }
    }
}