using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicTracker
{
    /// <summary>
    /// Contains the session data.
    /// </summary>
    public class SessionData
    {
        /// <summary>
        /// Gets/sets the rank
        /// </summary>
        public RankData CurrentRank { get; }

        /// <summary>
        /// Gets/sets a flag that determines if the last game was won.
        /// </summary>
        public bool WonLastGame { get; set; }

        /// <summary>
        /// Gets/sets the number of games in the current streak.
        /// </summary>
        public int Streak { get; set; }

        /// <summary>
        /// Gets/sets the number of games remaining.
        /// </summary>
        public int Remaining { get; set; }

        /// <summary>
        /// Gets the session record.
        /// </summary>
        public MatchRecord Session { get; }

        /// <summary>
        /// Gets the season record.
        /// </summary>
        public MatchRecord Season { get; }
        
        /// <summary>
        /// Gets the Mythic record.
        /// </summary>
        public MatchRecord Mythic { get; }

        public SessionData()
        {
            Session = new MatchRecord();
            Season = new MatchRecord();
            Mythic = new MatchRecord();
            CurrentRank = new RankData();
        }
    }
}
