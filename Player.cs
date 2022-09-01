using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2022_Programming_Internal
{
    class Player
    {

        public int x, y, width, height;//variables for the rectangle
        public Image player;//variable for the planet's image

        public Rectangle playerRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            player = Properties.Resources.Player;
            playerRec = new Rectangle(x, y, width, height);
        }
    }

    public void DrawPlayer(Graphics g)
    {

        g.DrawImage(player, playerRec);
    }

}
