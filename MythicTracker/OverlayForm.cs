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
    public partial class OverlayForm : Form
    {
        public OverlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the session record field.
        /// </summary>
        /// <param name="win">The number of wins.</param>
        /// <param name="loss">The number of losses.</param>
        public void SetSessionRecord(int win, int loss)
        {
            labelSession.Text = $"Session: {win} - {loss}";
        }

        /// <summary>
        /// Sets the season record field.
        /// </summary>
        /// <param name="win">The number of wins.</param>
        /// <param name="loss">The number of losses.</param>
        public void SetSeasonRecord(int win, int loss)
        {
            labelSeason.Text = $"Season: {win} - {loss}";
        }

        /// <summary>
        /// Sets the rank field.
        /// </summary>
        /// <param name="rank">The rank text.</param>
        public void SetRank(string rank)
        {
            labelRank.Text = rank;
        }

        /// <summary>
        /// Sets the streak field.
        /// </summary>
        /// <param name="streak">The length of the streak.</param>
        /// <remarks>If <paramref name="streak"/> is a positive value, then it represents a winning streak, otherwise if negative, it represents a losing streak.</remarks>
        public void SetStreak(int streak)
        {
            if(streak == 0)
            {
                labelStreak.Text = "Streak: None";
            }
            else if(streak > 0)
            {
                labelStreak.Text = $"Streak: Win {Math.Abs(streak)}";
            }
            else
            {
                labelStreak.Text = $"Streak: Lose {Math.Abs(streak)}";
            }
        }

        /// <summary>
        /// Sets the number of steps remaining.
        /// </summary>
        /// <param name="remianing">The number of steps needed for Mythic.</param>
        public void SetRemaining(int remianing)
        {
            labelSteps.Text = $"Steps needed: {remianing}";
        }

        /// <summary>
        /// Sets the Mythic record.
        /// </summary>
        /// <param name="win">The number of wins.</param>
        /// <param name="loss">The number of losses.</param>
        public void SetMythicRecord(int win, int loss)
        {
            labelSteps.Text = $"Mythic: {win} - {loss}";
        }

        /// <summary>
        /// Sets the record for the last 10 games.
        /// </summary>
        /// <param name="win">The number of wins.</param>
        /// <param name="loss">The number of losses.</param>
        public void SetLast10(int win, int loss)
        {
            labelLast10.Text = $"Last 10: {win}-{loss}";
        }
    }
}
