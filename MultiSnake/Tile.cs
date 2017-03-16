using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MultiSnake
{
    class Tile
    {
        private const int WIDTH = 30; //Nicht veränderbare Variable zur bestimmung der Breite eines Tile
        public Color color; // Erstellung der Variable color zur Farbgebung
        private Rectangle rect; // Erstellung der Variable rect zum Zeichnen der Tiles
        public static Tile[,] tiles;

        public Tile(Color color, int x, int y) // Parameterkonstruktor für jedes einzelne Tile
        {
            this.color = color; // Festlegung der Color
            rect = new Rectangle(x*WIDTH+2, y*WIDTH+2, WIDTH-4, WIDTH-4); // Übergabe der Werte zum Erstellen des Tile 
        }

        public static void init() // Methode zum Initialisieren der Werte
        {
            

            tiles = new Tile [64, 36]; // Tile Array zum Erstellen des Gitters

            for (int Xvalue = 0; Xvalue < 64; Xvalue++) // For Schleife zum erstellen des Tile an der X-Achse
            {
                for (int Yvalue = 0; Yvalue < 36; Yvalue++) // For Schleife zum Erstellen der Tiles auf der Y-Achse 
                {
                    tiles[Xvalue, Yvalue] = new Tile(Color.White, Xvalue, Yvalue); // Erstellen des Gitters basierend auf einem 2Dimensionalem Array mit den Werten der For Schleifen    
                                                                                                 // Farbe und Platzierung der Tiles wird an den Parameterkonstruktor für die Tiles übergeben.
                                                                                                 // x/y +2 u. WIDTH - 4 zum Erstellen eines kleineren Tiles auf einem Hintergrund für das Gittermuster!
                }
            }

        }

        public void draw(SpriteBatch spriteBatch, Texture2D texture)
        {
            spriteBatch.Draw(texture, rect, color);
        }

    }
}
