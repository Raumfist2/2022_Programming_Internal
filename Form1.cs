using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_Programming_Internal
{
    public partial class Game : Form
    {
        Graphics g;
        Enemy[] enemy = new Enemy[6];

        public Game()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                int x = 10 + (i * 75);
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
                enemy[i].DrawEnemy(g);
            }

        }
    }
}
