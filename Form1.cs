using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_Programming_Internal
{
    public partial class Game : Form
    {
        Graphics g;
        Enemy[] enemy = new Enemy[6];
        Random yspeed = new Random();
        Player player = new Player();

        public Game()
        {
            InitializeComponent();
            //Stop the panel from flickering
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });

            for (int i = 0; i < 6; i++)
            {
                int x = 10 + (i * 65);
                enemy[i] = new Enemy(x);
            }

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 6; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(2, 10);
                enemy[i].y += rndmspeed;

                enemy[i].DrawEnemy(g);
                player.DrawPlayer(g);
            }

        }

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            foreach (Enemy E in enemy)
            {
                //If enemy reaches end of panel go to top
                E.MoveEnemy();
                if (E.y >= pnlGame.Height)
                {
                    E.y = 30;
                }


            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
