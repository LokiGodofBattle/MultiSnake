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
    class Endscreen
    {
        private static Random rdm;

        public Endscreen(){

        }

        public static void init(){
            rdm = new Random();
        }

        public static void run()
        {
            while (true)
            {
                int x = rdm.Next(0, 64);
                int y = rdm.Next(0, 36);
                if (Tile.tiles[x, y].color != Color.Green)
                {
                    Tile.tiles[x, y].color = Color.Green;
                    break;
                }
            }
        }

    }
}
