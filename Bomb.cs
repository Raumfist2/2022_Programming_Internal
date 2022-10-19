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

        public Image bomb;//variable for the bomb's image

        public Rectangle bombRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Bomb(Rectangle playerRec)
        {
            x = playerRec.X + 4; // move the bomb towards the center of the player
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
