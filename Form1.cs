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
        bool left, right;
        int score, lives;
        bool allowShoot = true;
        bool allowBomb = true;
        string move;
        //declare a list  missiles from the missile class
        List<Bullet> bullets = new List<Bullet>();
        //declare a list  missiles from the missile class
        List<Bomb> bombs = new List<Bomb>();

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
            TmrPlayer.Enabled = false;
            TmrEnemy.Enabled = false;
            testbox.Visible = false;
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = 0;
            lives = 3;
            LblScore.Text = score.ToString();
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);
            TmrEnemy.Enabled = true;
            TmrPlayer.Enabled = true;
            TmrBullet.Enabled = true;
            TmrCooldown.Enabled = true;
            TmrCooldownBomb.Enabled = true;
            TmrBomb.Enabled = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TmrPlayer.Enabled = false;
            TmrEnemy.Enabled = false;
            TmrBullet.Enabled = false;
            TmrBomb.Enabled = false;
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
            }
            player.DrawPlayer(g);

            foreach (Bomb o in bombs)
            {
                o.MoveBomb(g);
            }
            foreach (Bullet b in bullets)
            {
                b.MoveBullet(g);
            }

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.MovePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.MovePlayer(move);
            }
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowShoot == true)
            {
                allowShoot = false;

                if (e.KeyChar == (char)Keys.Space)
                {
                    bullets.Add(new Bullet(player.playerRec));

                }
            }

            if (allowBomb == true)
            {
                allowBomb = false;

                if (e.KeyChar == (char)Keys.G)
                {
                    bombs.Add(new Bomb(player.playerRec));
                    testbox.Visible = true;
                }
            }
        }


        private void TmrBullet_Tick(object sender, EventArgs e)
        {
            foreach (Enemy g in enemy)
            {
                foreach (Bullet b in bullets)
                {
                    if (g.enemyRec.IntersectsWith(b.bulletRec))
                    {
                        g.y = -20;// relocate Enemy to the top of the form
                        bullets.Remove(b);
                        score += 100;//update the score
                        LblScore.Text = score.ToString();// display score
                        break;
                    }
                }
            }
            pnlGame.Invalidate();
        }

        private void TmrBomb_Tick(object sender, EventArgs e) //When Bomb collides with enemy
        {
            foreach (Enemy g in enemy)
            {
                foreach (Bomb o in bombs)
                {
                    if (g.enemyRec.IntersectsWith(o.bombRec))
                    {
                        g.y = -20;// relocate Enemy to the top of the form
                        bombs.Remove(o);
                        score += 100;//update the score
                        LblScore.Text = score.ToString();// display score
                        break;
                    }
                }
            }
            pnlGame.Invalidate();
        }



        private void TmrCooldown_Tick(object sender, EventArgs e)
        {
            if (allowShoot == false)
            {
                allowShoot = true;
            }
        }

        private void TmrCooldownBomb_Tick(object sender, EventArgs e)
        {
            if (allowBomb == false)
            {
                allowBomb = true;
            }
        }

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                enemy[i].MoveEnemy();
                if (player.playerRec.IntersectsWith(enemy[i].enemyRec))
                {
                    //reset planet[i] back to top of panel
                    enemy[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }
                if (enemy[i].y >= pnlGame.Height)
                {
                    score += 100;//update the score
                    LblScore.Text = score.ToString();// display score
                    enemy[i].y = 30;

                }
            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrEnemy.Enabled = false;
                TmrPlayer.Enabled = false;
                MessageBox.Show("Game Over");
                this.Close();
            }
        }
    }
}
