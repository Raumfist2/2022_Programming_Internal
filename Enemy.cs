using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_Programming_Internal
{
    class Enemy
    {
        public int x, y, width, height, speed;//variables for the rectangle and speed

        public Image enemyImage;//variable for the enemy's image

        public Rectangle enemyRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Enemy(int spacing)
        {
            x = spacing;
            y = 10;
            width = 40;
            height = 40;
            enemyImage = Properties.Resources.Enemy1;//sources from the resources
            enemyRec = new Rectangle(x, y, width, height);
        }


        //Drawing the enemy on the panel
        public void DrawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enemyRec);//draws the enemy
        }

        //Moving the enemy
        public void MoveEnemy()
        {
            y += speed;//moves the player by the speed int
            enemyRec.Location = new Point(x, y);//sets the location
        }

    }
}
