using System;
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
    public partial class GameWon : Form
    {
        public GameWon(int score)
        {
            InitializeComponent();
            label2.Text = score.ToString();
        }
    }
}
