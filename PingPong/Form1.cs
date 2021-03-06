﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        private Ball ball;
        private Player player;
        private bool isStopped;
        System.Windows.Forms.Timer t;

        private void Timer_Shown(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 20;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }
        
        void t_Tick(object sender, EventArgs e)
        {

            score.Text = this.player.GetScore().ToString();
            if (!isStopped)
            {
            this.ball.move();
                if(ball.IsOutOfGame())
                {
                    Program.FlipIsLost();
                    this.Close();
                }
            this.ball.CheckCollide(progressBar1, player);
            if (ball.GetCurrent() == ball.GetDiff()) this.Close();
            Invalidate();
            }
        }

        public Form1(Ball ball, Player player, int level)
        {
            this.ball = ball;
            this.player = player;
            this.KeyPreview = true;
            this.isStopped = false;
            InitializeComponent();
            username.Text = this.player.GetUsername();
            this.level.Text = level.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Program.FlipIsLost();
                this.Close();
            }
            if (e.KeyData == Keys.Space) isStopped = !isStopped;
            if (!isStopped)
            {
                if (progressBar1.Location.X > 1 && progressBar1.Location.X < (this.Size.Width/2+25))
                {
                    if(e.KeyData == Keys.Left)
                    {
                        progressBar1.Location = new Point(progressBar1.Location.X -5, progressBar1.Location.Y);
                    }
                    else if (e.KeyData == Keys.Right)
                    {
                        progressBar1.Location = new Point(progressBar1.Location.X +5, progressBar1.Location.Y);
                    }
                }
                else
                {
                    if (progressBar1.Location.X < 2) progressBar1.Location = new Point(2, progressBar1.Location.Y);
                    else progressBar1.Location = new Point(173, progressBar1.Location.Y);
                }
            }
        }

        void Form1_Load(object sender, System.EventArgs e)
        {
            
            this.KeyPreview = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red);
            g.DrawEllipse(p, this.ball.GetBall());
            g.Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

    
}
