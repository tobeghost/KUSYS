using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Domain.Entities
{
    /// <summary>
    /// Represents a user
    /// </summary>
    public partial class User : BaseEntity
    {
        /// <summary>
        /// Gets or sets username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets role of user (Admin or User)
        /// </summary>
        public string Role { get; set; }
    }
}
