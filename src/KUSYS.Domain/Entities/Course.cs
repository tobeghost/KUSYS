using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Domain.Entities
{
    /// <summary>
    /// Represents a course
    /// </summary>
    public partial class Course : BaseEntity
    {
        /// <summary>
        /// Gets or sets the course short code
        /// </summary>
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or sets the couse name
        /// </summary>
        public string Name { get; set; }
    }
}
