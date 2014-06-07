using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Model.Models
{
    /// <summary>
    /// Department in organization
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Gets or sets department unique identity
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets department name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets enitity created date
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
