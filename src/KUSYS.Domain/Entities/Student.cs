using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Domain.Entities
{
    /// <summary>
    /// Represents a student
    /// </summary>
    public partial class Student : BaseEntity
    {
        /// <summary>
        /// Gets or sets name of student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets surname of student
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets birth date of student
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}
