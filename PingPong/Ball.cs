using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PingPong
{
    public class Ball
    {

        private int x { get; set; }
        private int y
        {
            get; set;
        }

        private int xDir = 2;
        private int yDir = 2;
        private int diff = 3 ;
        private int current = 0;
        private Rectangle ball;

        public Ball(int level)
        {
            Random rand = new Random();
            this.x = rand.Next(80);
            this.y = rand.Next(20);
            this.ball = new Rectangle(x, y, 20, 20);
            xDir += level;
            yDir += level;
            diff += level;
            
        }

        public void move()
        {
            this.x += xDir;
            this.y += yDir;
            if (this.x < 0 || this.x > 250)
            {
                this.xDir = -this.xDir;
                this.x += xDir;
            }
            if (this.y < 0 || this.y > 250)
            {
                this.yDir = -this.yDir;
                this.y += this.yDir;
            }
            ball.Location = new Point(this.x, this.y);
        }

        public bool CheckCollide(ProgressBar bar, Player player)
        {
            if (bar.Bounds.IntersectsWith(this.ball))
            {
                yDir = -yDir;
                player.AddScore();
                current++;
                return true;
            }
            return false;
        }

        public bool IsOutOfGame()
        {
            if (ball.Location.Y >209) return true;
            return false;
        }

        public Rectangle GetBall()
        {
            return this.ball;
        }

        public int GetCurrent()
        {
            return current;
        }

        public int GetDiff()
        {
            return diff;
        }
    }
}
