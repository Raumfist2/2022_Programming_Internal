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
        public int x, y, width, height;
        public Image enemyImage;
        public Rectangle enemyRec;
        public int score;

        //Create a constructor (initialises the values of the fields)
        public Enemy(int spacing)
        {
            x = spacing;
            y = 10;
            width = 40;
            height = 40;
            enemyImage = Properties.Resources.Enemy1;
            enemyRec = new Rectangle(x, y, width, height);
        }


        // Methods for the Planet class
        public void DrawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enemyRec);
        }

    }
}
