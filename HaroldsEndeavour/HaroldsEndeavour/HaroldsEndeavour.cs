using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace HaroldsEndeavour
{
    public partial class HaroldsEndeavour : Form
    {
        private Player _player;

        public HaroldsEndeavour()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);

            lbHitPoints.Text = _player.CurrentHitPoints.ToString();
            lbGold.Text = _player.Gold.ToString();
            lbXP.Text = _player.ExperiencePoints.ToString();
            lbLevel.Text = _player.Level.ToString();
        }


    }
}
