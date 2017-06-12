using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Player
    {
        private int score;
        private int level;
        private String username;

        public Player(int score, int level, String username)
        {
            this.score = score;
            this.level = level;
            this.username = username;

        }

    }
}
