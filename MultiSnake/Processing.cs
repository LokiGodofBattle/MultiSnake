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
    class Processing
    {

        public static Snake player1;
        public static Snake player2;
        private static Random rdm;
        public static bool lose;

        public static void init()
        {
            rdm = new Random();
            lose = false;

            player1 = new Snake(rdm.Next(0, 64), rdm.Next(0, 36));
            player2 = new Snake(rdm.Next(0, 64), rdm.Next(0, 36));
        }

        public static void render()
        {
            
                for (int i = 0; i < Processing.player1.trail.Count; i++)
                {
                    if (Tile.tiles[(int)Processing.player1.trail[i].X, (int)Processing.player1.trail[i].Y].color != Color.Black)
                    {
                        Tile.tiles[(int)Processing.player1.trail[i].X, (int)Processing.player1.trail[i].Y].color = Color.Black;
                    }
                }

                for (int j = 0; j < Processing.player2.trail.Count; j++)
                {
                    if (Tile.tiles[(int)Processing.player2.trail[j].X, (int)Processing.player2.trail[j].Y].color != Color.Brown)
                    {
                        Tile.tiles[(int)Processing.player2.trail[j].X, (int)Processing.player2.trail[j].Y].color = Color.Brown;
                    }
                }
          
            }
        

    }
}
