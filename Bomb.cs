using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_Programming_Internal
{
    internal class Bomb
    {
        public int x, y, width, height;

        public Image bomb;//variable for the missile's image

        public Rectangle bombRec;//variable for a rectangle to place our image in

        // in the following constructor we pass in the values of spaceRec which
        // gives us the position of the spaceship which we can then use to place the
        // missile where the spaceship is located
        public Bomb(Rectangle playerRec)
        {
            x = playerRec.X + 4; // move missile to middle of spaceship
            y = playerRec.Y;
            width = 30;
            height = 30;
            bomb = Properties.Resources.LargeProj;
            bombRec = new Rectangle(x, y, width, height);
        }

        public void MoveBomb(Graphics g)
        {
            y -= 5;//speed of bomb
            bombRec = new Rectangle(x, y, width, height);
            g.DrawImage(bomb, bombRec);
        }

    }
}
