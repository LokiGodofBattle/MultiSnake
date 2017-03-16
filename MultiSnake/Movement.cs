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
    class Movement
    {
        private static KeyboardState state;

        public Movement()
        {

        }

        public static void render()
        {
            state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.W) && Processing.player1.direction != 2)
            {
                Processing.player1.direction = 0;
            }

            if (state.IsKeyDown(Keys.A) && Processing.player1.direction != 1)
            {
                Processing.player1.direction = 3;
            }

            if (state.IsKeyDown(Keys.S) && Processing.player1.direction != 0)
            {
                Processing.player1.direction = 2;
            }

            if (state.IsKeyDown(Keys.D) && Processing.player1.direction != 3)
            {
                Processing.player1.direction = 1;
            }

            if (state.IsKeyDown(Keys.Up) && Processing.player2.direction != 2)
            {
                Processing.player2.direction = 0;
            }

            if (state.IsKeyDown(Keys.Left) && Processing.player2.direction != 1)
            {
                Processing.player2.direction = 3;
            }

            if (state.IsKeyDown(Keys.Down) && Processing.player2.direction != 0)
            {
                Processing.player2.direction = 2;
            }

            if (state.IsKeyDown(Keys.Right) && Processing.player2.direction != 3)
            {
                Processing.player2.direction = 1;
            }
        }
    }
}
