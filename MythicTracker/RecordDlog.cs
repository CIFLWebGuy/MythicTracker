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
    public partial class RecordDlog : Form
    {
        /// <summary>
        /// Gets/set the number of wins.
        /// </summary>
        public int Wins
        {
            get
            {
                return (int)upDownWin.Value;
            }
            set
            {
                if (value < 0 || value > 9999)
                    throw new ArgumentOutOfRangeException("Value must be between 0 and 9999.");

                upDownWin.Value = value;
            }
        }

        /// <summary>
        /// Gets/sets the number of losses.
        /// </summary>
        public int Losses
        {
            get
            {
                return (int)upDownLoss.Value;
            }
            set
            {
                if (value < 0 || value > 9999)
                    throw new ArgumentOutOfRangeException("Value must be between 0 and 9999.");

                upDownLoss.Value = value;
            }
        }

        /// <summary>
        /// Gets/sets the number of season wins.
        /// </summary>
        public int SeasonWin
        {
            get
            {
                return (int)upDownSeasonWin.Value;
            }
            set 
            {
                if (value < 0 || value > 9999)
                    throw new ArgumentOutOfRangeException("Value must be between 0 and 9999.");

                upDownSeasonWin.Value = value;
            }
        }

        /// <summary>
        /// Gets/sets the number of season losses.
        /// </summary>
        public int SeasonLoss
        {
            get
            {
                return (int)upDownSeasonLoss.Value;
            }
            set
            {
                if (value < 0 || value > 9999)
                    throw new ArgumentOutOfRangeException("Value must be between 0 and 9999.");

                upDownSeasonLoss.Value = value;
            }
        }

        /// <summary>
        /// Gets/sets the number of wins at Mythic level.
        /// </summary>
        public int MythicWin
        {
            get
            {
                return (int)upDownMythicWin.Value;
            }
            set
            {
                upDownMythicWin.Value = value;
            }
        }

        /// <summary>
        /// Gets/sets the number of losses at Mythic.
        /// </summary>
        public int MythicLoss
        {
            get
            {
                return (int)upDownMythicLoss.Value;
            }
            set
            {
                upDownMythicLoss.Value = value;
            }
        }

        /// <summary>
        /// Gets/sets the current streak. Values below 0 represent a losing streak.
        /// </summary>
        public int Streak
        {
            get
            {
                if (comboBoxStreak.SelectedIndex == 0)
                    return (int)upDownStreak.Value;
                else
                    return (int)-upDownStreak.Value;
            }
            set
            {
                if (value < -9999 || value > 9999)
                    throw new ArgumentException("Value cannot exceed 9999.");

                upDownStreak.Value = Math.Abs(value);

                if (value > 0)
                    comboBoxStreak.SelectedIndex = 0;
                else
                    comboBoxStreak.SelectedIndex = 1;
            }
        }

        /// <summary>
        /// Initalizes a RecordDlog object.
        /// </summary>
        public RecordDlog()
        {
            InitializeComponent();
        }

        private void RecordDlog_Load(object sender, EventArgs e)
        {
            
        }
    }
}
