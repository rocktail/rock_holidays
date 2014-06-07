using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Model.Models
{
    /// <summary>
    /// Employee is also our basic user. 
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets employee identity
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets first name of the employee
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Employee surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets department the employee is assigned to
        /// </summary>
        public virtual Department Department { get; set; }

        /// <summary>
        /// Gets or sets identity of department the employee is assigned to
        /// </summary>
        public int DepartmentId { get; set; }


    }
}
