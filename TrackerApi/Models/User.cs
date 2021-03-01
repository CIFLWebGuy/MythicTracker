using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerApi.Models
{
    /// <summary>
    /// Represents a user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets/sets the user ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets/sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets/sets the user's access token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Get/sets the user's email.
        /// </summary>
        public string Email { get; set; }  
        
        /// <summary>
        /// Gets/sets a flag that determines if the user is active.
        /// </summary>
        public bool Active { get; set; }
    }
}
