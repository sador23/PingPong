using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Player
    {
        private int score;
        private int level;
        private String username;

        public Player()
        {
            this.score = 0;
            this.level = 0;
            this.username = "";

        }

        public void SetUsername(String username)
        {
            this.username = username;

        }

        public void AddScore()
        {
            this.score++;
        }

        public int  GetScore()
        {
            return this.score;
        }

        public String GetUsername()
        {
            return this.username;
        }

    }
}
