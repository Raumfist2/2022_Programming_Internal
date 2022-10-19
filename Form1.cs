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
        //Defining variables
        Graphics g;
        Enemy[] enemy = new Enemy[6];
        Random yspeed = new Random();
        Player player = new Player();
        bool left, right;
        public int score, lives;
        bool allowShoot = true;
        bool allowBomb = false;
        string move;
        //declare a list bullets from the bullet class
        List<Bullet> bullets = new List<Bullet>();
        //declare a list bombs from the bomb class
        List<Bomb> bombs = new List<Bomb>();

        public Game()
        {
            InitializeComponent();
            //Stop the panel from flickering
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });

            //Setting the enemies in the array with their x-value
            for (int i = 0; i < 6; i++)
            {
                int x = 10 + (i * 65);
                enemy[i] = new Enemy(x);
            }

        }

        //Once game launches
        private void Game_Load(object sender, EventArgs e)
        {
            score = 0;//reset score to 0
            lives = 3;//Set base value of lives to 3
            LblScore.Text = score.ToString();
            //passes lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);
            //disables power up gui
            testbox.Visible = false;
            LblPower.Visible = false;
            //passes lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);
        }

        //Once start is pressed
        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //enable all timers
            TmrEnemy.Enabled = true;
            TmrPlayer.Enabled = true;
            TmrBullet.Enabled = true;
            TmrCooldown.Enabled = true;
            TmrCooldownBomb.Enabled = true;
            TmrBomb.Enabled = true;
            TmrDifficulty.Enabled = true;
        }

        //When pause is clicked
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //disable all timers
            TmrPlayer.Enabled = false;
            TmrEnemy.Enabled = false;
            TmrBullet.Enabled = false;
            TmrCooldown.Enabled = true;
            TmrCooldownBomb.Enabled = true;
            TmrBomb.Enabled = false;
            TmrDifficulty.Enabled = false;
        }

        //Drawing the objects
        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 6; i++)
            {
                // generates a random number from 5 to 10 and put it in rndmspeed
                int rndmspeed = yspeed.Next(2, 10);
                enemy[i].y += rndmspeed;
                enemy[i].DrawEnemy(g);//draw enemy
            }
            //draw player
            player.DrawPlayer(g);
            //draw the bomb in the Bomb class
            foreach (Bomb o in bombs)
            {
                o.MoveBomb(g);
            }
            //draw the bullet in the Bullet class
            foreach (Bullet b in bullets)
            {
                b.MoveBullet(g);
            }
        }

        //When a key is held
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; } //Sets left to true after the left key is pressed
            if (e.KeyData == Keys.Right) { right = true; } //Sets right to true after right key is pressed

            if (allowBomb == true)//Checks if the bomb can be released
            {
                if (e.KeyData == Keys.G)//If key "g" is pressed
                {
                    allowBomb = false;//sets the bomb back to being unreleasable
                    bombs.Add(new Bomb(player.playerRec));//Add a bomb
                    TmrCooldownBomb.Enabled = true;//Re-enable cooldown
                }
            }
        }

        //When a key is released
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }//Sets the left to false after key is let go
            if (e.KeyData == Keys.Right) { right = false; }//Sets the right to false after key is let go
        }

        //Player timer tick
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

        //When a key is pressed
        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowShoot == true)//if shoot cooldown off
            {
                allowShoot = false;//reset cooldown
                if (e.KeyChar == (char)Keys.Space)//if space pressed
                {
                    bullets.Add(new Bullet(player.playerRec));//Add a bullet
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
                        bullets.Remove(b);//removes bullet
                        score += 100;//update the score
                        LblScore.Text = score.ToString();// display score
                        break;
                    }
                }
            }
            pnlGame.Invalidate();//refresh the panel
        }

        private void TmrBomb_Tick(object sender, EventArgs e) //When Bomb collides with enemy
        {

            foreach (Enemy g in enemy)
            {
                foreach (Bomb o in bombs)
                {
                    if (g.enemyRec.IntersectsWith(o.bombRec))
                    {
                        foreach (Enemy enemys in enemy)
                        {
                            enemys.y = -20;// relocate Enemy to the top of the form
                        }
                        bombs.Remove(o);//removes bomb
                        score += 100;//update the score
                        LblScore.Text = score.ToString();// display score
                        break;
                    }
                }
            }
            pnlGame.Invalidate();//refresh the panel

        }
        //when bullet cooldown interval is done
        private void TmrCooldown_Tick(object sender, EventArgs e)
        {
            if (allowShoot == false)//if cooldown is down
            {
                allowShoot = true;//ready bullet
            }
        }
        //when bomb cooldown interval is done
        private void TmrCooldownBomb_Tick(object sender, EventArgs e)
        {
            if (allowBomb == false)//if cooldown is down
            {
                allowBomb = true;//ready bomb
                testbox.Visible = true;//ui show
                LblPower.Visible = true;
                TmrCooldownBomb.Enabled = false;//pause bomb cooldown
            }

        }
        //when the TmrDifficulty ticks
        private void TmrDifficulty_Tick(object sender, EventArgs e)
        {
            if (score >= 5000)//if score is >5000
            {
                foreach (Enemy enemies in enemy)//set enemy speed to 5
                {
                    enemies.speed = 5;
                }
                if (score >= 10000)//if score is >10000
                {
                    foreach (Enemy enemies in enemy)//set enemy speed to 10
                    {
                        enemies.speed = 10;
                    }
                    if (score >= 20000)//if score is >20000
                    {
                        foreach (Enemy enemies in enemy)
                        {
                            enemies.speed = 20;//set enemy speed to 10
                        }
                    }
                }
            }
            else
            {
                foreach (Enemy enemies in enemy)
                {
                    enemies.speed = 2;//if score is <5000 than set speed to 2
                }
            }

            //using difficulty timer interval, hiding the bomb powerup ui
            if (allowBomb == false)
            {
                testbox.Visible = false;
                LblPower.Visible = false;
            }
        }

        //when Tmrenemy ticks
        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)//for each enemy
            {
                enemy[i].MoveEnemy();//move enemy

                if (player.playerRec.IntersectsWith(enemy[i].enemyRec))//if Enemy intercepts player
                {
                    //Resets the enemy to the top the panel
                    enemy[i].y = 30;// The Y value it is set to 30
                    lives -= 1;// Removes a life
                    LblLives.Text = lives.ToString();// displays the number of lives
                    CheckLives();//check live left
                }
                if (enemy[i].y >= pnlGame.Height)//Enemy reaches bottom
                {
                    score += 100;//update the score
                    LblScore.Text = score.ToString();// display score
                    enemy[i].y = 30;// The Y value it is set to 30
                }
            }
            pnlGame.Invalidate();//refresh the panel
        }

        //check if lives left
        private void CheckLives()
        {
            if (lives == 0)//all lives lost
            {
                //disable timers
                TmrEnemy.Enabled = false;
                TmrPlayer.Enabled = false;
                MessageBox.Show("Game Over");//show game over screen
                this.Close();//close game
            }
        }
    }
}
