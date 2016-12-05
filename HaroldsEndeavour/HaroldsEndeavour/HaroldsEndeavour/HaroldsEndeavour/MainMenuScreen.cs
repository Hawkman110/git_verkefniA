using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen(Player player)
        {
            _currentPlayer = player;
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Player _currentPlayer;
    }
}
