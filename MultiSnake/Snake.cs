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
    class Snake
    {
        private Vector2 v;
        private int x;
        private int y;
        public List<Vector2> trail;
        public int direction; //0 = up, 1 = right, 2 = down, 3 = left
        private long time;

        public Snake(int x, int y)
        {
            this.x = x;
            this.y = y;
            trail = new List<Vector2>();

            trail.Add(new Vector2(x, y));
            direction = 0;
        }

        public void render(GameTime gameTime)
        {
            time += gameTime.ElapsedGameTime.Milliseconds;

            if (time >= 50)
            {
                
                switch (direction)
                {
                        

                    case 0:
                        v = new Vector2(x, y - 1);

                        check(v);
                        if (!Processing.lose && !checkBounds())
                        {
                            trail.Add(v);
                            y--;
                        }

                        break;
                    case 1:
                        v = new Vector2(x+1, y);

                        check(v);
                        if (!Processing.lose && !checkBounds())
                        {
                            
                            trail.Add(v);
                            x++;
                        }

                        

                        break;
                    case 2:
                        v = new Vector2(x, y+1);

                        check(v);
                        if (!Processing.lose && !checkBounds())
                        {
                          
                            trail.Add(v);
                            y++;
                        }


                        break;
                    case 3:
                        v = new Vector2(x-1, y);

                        check(v);
                        if (!Processing.lose && !checkBounds())
                        {
                            
                            trail.Add(v);
                            x--;
                        }


                        break;

                }

                time -= 50;
            }
        }

        private bool checkBounds()
        {
            if (v.X >= 64)
            {
                v = new Vector2(0, v.Y);

                trail.Add(v); x = 0;
                return true;
            }

            if (v.Y >= 36)
            {
                v = new Vector2(v.X, 0);
                y = 0;
                trail.Add(v);
                return true;
            }

            if (this.v.X <= -1)
            {
                v = new Vector2 (63, v.Y);
                x = 63;
                trail.Add(v);
                return true;
            }

            if (v.Y <= -1)
            {
                v = new Vector2(v.X,35);
                y = 35;
                trail.Add(v);
                return true;
            }

            return false;
        }
        


        private void check(Vector2 v)
        {
            for (int i = 0; i < Processing.player1.trail.Count; i++)
            {
                if (Processing.player1.trail[i].X == v.X && Processing.player1.trail[i].Y == v.Y) Processing.lose = true;
            }

            for (int i = 0; i < Processing.player2.trail.Count; i++)
            {
                if (Processing.player2.trail[i].X == v.X && Processing.player2.trail[i].Y == v.Y) Processing.lose = true;
            }

        }

    }
}
