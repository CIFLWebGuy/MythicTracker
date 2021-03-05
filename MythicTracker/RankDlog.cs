using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicTracker
{
    public partial class RankDlog : Form
    {
        /// <summary>
        /// Gets/sets a flag that determines if the wins field is visible.
        /// </summary>
        public bool WinsVisible
        {
            get
            {
                return upDownWins.Visible;
            }
            set
            {
                upDownWins.Visible = value;
                labelWins.Visible = value;
            }
        }

        /// <summary>
        /// Gets/sets the rank.
        /// </summary>
        public int Rank
        {
            get
            {
                return comboBoxRank.SelectedIndex;
            }

            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentOutOfRangeException("value", "Rank must be between 0 and 5.");

                comboBoxRank.SelectedIndex = value;
            }
        }

        /// <summary>
        /// Gets/sets the level.
        /// </summary>
        public int Level
        {
            get
            {
                return 4 - (int)upDownLevel.Value;
            }

            set
            {
                if (value < 0 || value > 3)
                    throw new ArgumentOutOfRangeException("value", "Level must be between 0 and 3.");

                upDownLevel.Value = 4 - value;
            }
        }

        /// <summary>
        /// Gets/sets the number of wins.
        /// </summary>
        public int Wins
        {
            get
            {
                return (int)upDownWins.Value;
            }

            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException("value", "Wins must be between 0 and 5.");

                upDownWins.Value = value;
            }
        }

        public RankDlog()
        {
            InitializeComponent();
        }

        private void RankDlog_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRank.SelectedIndex == 5)
            {
                upDownLevel.Value = 4;
                upDownWins.Value = 0;

                panelLevel.Visible = false;
            }
            else
            {
                panelLevel.Visible = true;
            }
        }
    }
}
