﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2022_Programming_Internal
{
    class Bullet
    {
        public int x, y, width, height;

        public Image bullet;//variable for the bullet's image

        public Rectangle bulletRec;//variable for a rectangle to place our image in

        // in the following constructor we pass in the values of playerRec which
        // gives us the position of the player which we can then use to place the
        // bullet where the player is located
        public Bullet(Rectangle playerRec)
        {
            x = playerRec.X + 37; // move bullet to middle of player
            y = playerRec.Y;
            width = 20;
            height = 20;
            bullet = Properties.Resources.Small_Proj;
            bulletRec = new Rectangle(x, y, width, height);
        }

        public void MoveBullet(Graphics g)
        {
            y -= 5;//speed of bullet

            bulletRec = new Rectangle(x, y, width, height);
            g.DrawImage(bullet, bulletRec);
        }
    }
}
