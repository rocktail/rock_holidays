using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Model.Models
{
    /// <summary>
    /// Type of holiday request
    /// </summary>
    public class HolidayRequestType
    {
        /// <summary>
        /// Identity of holiday request type
        /// </summary>
        public int HolidayRequestTypeId { get; set; }

        /// <summary>
        /// Name of the holiday request type
        /// </summary>
        public string Name { get; set; }
    }
}
