using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PingPong
{
    static class Program
    {

        static int level = 0;
        static bool isLost;
        static bool isWon;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            isLost = false;
            Player player = new Player();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Menu(player));

            while((isLost == false) && level < 7)
            {
                
                level++;
                Ball ball = new Ball(level);
                Application.Run(new Form1(ball, player, level));
            }
            if (isLost) Application.Run(new GameOver(player.GetScore()));
            else if(level == 7 ) Application.Run(new GameWon(player.GetScore()));

        }

        public static void FlipIsLost()
        {
            isLost = !isLost;
        }


    }
}
