using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Model.Models
{
    /// <summary>
    /// Transaction journal for holiday requests
    /// </summary>
    public class HolidayRequestJournalEntry
    {
        /// <summary>
        /// Gets or sets identity of holiday request journal entry
        /// </summary>
        public int HolidayRequestJournalId { get; set; }

        /// <summary>
        /// Gets or sets holiday request this entry is about
        /// </summary>
        public HolidayRequest HolidayRequest { get; set; }

        /// <summary>
        /// Gets or sets identity of holiday request this entry is about
        /// </summary>
        public int HolidayRequestId { get; set; }

        /// <summary>
        /// Employee who created transaction
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Identity of employee who created this transaction
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Description of this transaction 
        /// </summary>
        public string OperationDescription { get; set; }

        /// <summary>
        /// Date of entry
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
