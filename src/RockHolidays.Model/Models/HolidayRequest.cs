using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Model.Models
{
    /// <summary>
    /// Holiday request class
    /// </summary>
    public class HolidayRequest
    {
        /// <summary>
        /// Gets or sets identity of holiday request
        /// </summary>
        public int HolidayRequestId { get; set; }

        /// <summary>
        /// Gets or sets beginning date of requested holidays
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date of requested holidays
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets total amount of holiday working days
        /// </summary>
        public decimal TotalDays { get; set; }

        /// <summary>
        /// Gets or sets employee who handed the request
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets identity of employee who handed the request
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets cover for our employee during holiday period
        /// </summary>
        public virtual Employee Cover { get; set; }

        /// <summary>
        /// Gets or sets identityt of the cover for our employee during holiday period
        /// </summary>
        public int? CoverId { get; set; }

        /// <summary>
        /// Gets or sets notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets holiday request number
        /// </summary>
        public string HolidayRequestNumber { get; set; }

        /// <summary>
        /// Type of holiday request
        /// </summary>
        public virtual HolidayRequestType HolidayRequestType { get; set; }
        
        /// <summary>
        /// Identity of holiday request type
        /// </summary>
        public int HolidayRequestTypeId { get; set; }
    }
}
