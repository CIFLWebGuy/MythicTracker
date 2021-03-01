using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerApi.Models
{
    /// <summary>
    /// Represents the session data.
    /// </summary>
    public class SessionData
    {
        /// <summary>
        /// Gets/sets the rank
        /// </summary>
        public Ranks Rank { get; set; }

        /// <summary>
        /// Gets/sets the level
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets/sets the number of rank wins
        /// </summary>
        public int RankWins { get; set; }

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

        /// <summary>
        /// Initalizes an instance of the SessionData class.
        /// </summary>
        public SessionData()
        {
            Season = new MatchRecord();
            Session = new MatchRecord();
            Mythic = new MatchRecord();
        }
    }
}
