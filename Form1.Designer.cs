namespace _2022_Programming_Internal
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.TmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.pnlGame = new System.Windows.Forms.Panel();
            this.LblScore = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrBullet = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TmrCooldown = new System.Windows.Forms.Timer(this.components);
            this.TmrBomb = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TmrCooldownBomb = new System.Windows.Forms.Timer(this.components);
            this.testbox = new System.Windows.Forms.PictureBox();
            this.LblPower = new System.Windows.Forms.Label();
            this.TmrDifficulty = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrEnemy
            // 
            this.TmrEnemy.Interval = 75;
            this.TmrEnemy.Tick += new System.EventHandler(this.TmrEnemy_Tick);
            // 
            // TmrPlayer
            // 
            this.TmrPlayer.Interval = 40;
            this.TmrPlayer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.SlateGray;
            this.pnlGame.BackgroundImage = global::_2022_Programming_Internal.Properties.Resources.Back1;
            this.pnlGame.Location = new System.Drawing.Point(23, 55);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(400, 700);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.BackColor = System.Drawing.SystemColors.Control;
            this.LblScore.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(459, 254);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(16, 16);
            this.LblScore.TabIndex = 1;
            this.LblScore.Text = "0";
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.BackColor = System.Drawing.SystemColors.Control;
            this.LblLives.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLives.Location = new System.Drawing.Point(459, 354);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(16, 16);
            this.LblLives.TabIndex = 2;
            this.LblLives.Text = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::_2022_Programming_Internal.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(452, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(728, 24);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startGameToolStripMenuItem.Text = "Start";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // TmrBullet
            // 
            this.TmrBullet.Tick += new System.EventHandler(this.TmrBullet_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lives:";
            // 
            // TmrCooldown
            // 
            this.TmrCooldown.Interval = 1000;
            this.TmrCooldown.Tick += new System.EventHandler(this.TmrCooldown_Tick);
            // 
            // TmrBomb
            // 
            this.TmrBomb.Tick += new System.EventHandler(this.TmrBomb_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(429, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 41);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(445, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 346);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(429, 284);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(296, 19);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // TmrCooldownBomb
            // 
            this.TmrCooldownBomb.Interval = 30000;
            this.TmrCooldownBomb.Tick += new System.EventHandler(this.TmrCooldownBomb_Tick);
            // 
            // testbox
            // 
            this.testbox.Image = global::_2022_Programming_Internal.Properties.Resources.LargeProj;
            this.testbox.Location = new System.Drawing.Point(517, 489);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(118, 118);
            this.testbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testbox.TabIndex = 10;
            this.testbox.TabStop = false;
            this.testbox.Visible = false;
            // 
            // LblPower
            // 
            this.LblPower.AutoSize = true;
            this.LblPower.BackColor = System.Drawing.Color.Black;
            this.LblPower.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPower.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblPower.Location = new System.Drawing.Point(510, 449);
            this.LblPower.Name = "LblPower";
            this.LblPower.Size = new System.Drawing.Size(130, 37);
            this.LblPower.TabIndex = 11;
            this.LblPower.Text = "READY";
            this.LblPower.Visible = false;
            // 
            // TmrDifficulty
            // 
            this.TmrDifficulty.Tick += new System.EventHandler(this.TmrDifficulty_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(728, 853);
            this.Controls.Add(this.LblPower);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Game";
            this.Text = "Ealien Revenge";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer TmrEnemy;
        private System.Windows.Forms.Timer TmrPlayer;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.Timer TmrBullet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TmrCooldown;
        private System.Windows.Forms.Timer TmrBomb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer TmrCooldownBomb;
        private System.Windows.Forms.PictureBox testbox;
        private System.Windows.Forms.Label LblPower;
        private System.Windows.Forms.Timer TmrDifficulty;
    }
}

