using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Data.Infrastructure
{
    /// <summary>
    /// Contract for database factory
    /// </summary>
    public interface IDatabaseFactory : IDisposable
    {
        /// <summary>
        /// Gets rock holidays data context
        /// </summary>
        /// <returns></returns>
        RockHolidaysEntities Get();
    }
}
