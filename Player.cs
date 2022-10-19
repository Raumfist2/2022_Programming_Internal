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

        public Image player;//variable for the player's image

        public Rectangle playerRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 10;
            y = 620;
            width = 30;
            height = 30;
            player = Properties.Resources.PlayerN;//sources from the resources
            playerRec = new Rectangle(x, y, width, height);
        }

        //Moving the player
        public void MovePlayer(string move)
        {
            playerRec.Location = new Point(x, y);//setting the players location

            if (move == "right")//if right key pressed
            {
                if (playerRec.Location.X > 360) // if player is within 50 of right side
                {

                    x = 360;
                    playerRec.Location = new Point(x, y);//max location is 360 = x
                }
                else
                {
                    x += 5;
                    playerRec.Location = new Point(x, y);//if smaller, it will move by 5
                }

            }


            if (move == "left")//if left key pressed
            {
                if (playerRec.Location.X < 10) // if player is within 10 of left side
                {

                    x = 10;
                    playerRec.Location = new Point(x, y);//min location is 10 = x
                }
                else
                {
                    x -= 5;
                    playerRec.Location = new Point(x, y);//If greater, it will move by -5
                }

            }
        }

    public void DrawPlayer(Graphics g)
        {
            g.DrawImage(player, playerRec);//draws the player
        }
    }
}
