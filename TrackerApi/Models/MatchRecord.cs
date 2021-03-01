using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerApi.Models
{
    /// <summary>
    /// Represents a match record.
    /// </summary>
    public class MatchRecord
    {
        /// <summary>
        /// Gets/sets the number of wins
        /// </summary>
        public int Win { get; set; }

        /// <summary>
        /// Gets/sets the number of Losses
        /// </summary>
        public int Loss { get; set; }

        /// <summary>
        /// Gets the win percentage.
        /// </summary>
        public float Pct
        {
            get
            {
                if (Win + Loss == 0)
                    return 0;

                return (float)Win / (Win + Loss);
            }
        }
    }
}
