using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockHolidays.Data.Infrastructure;
using RockHolidays.Model.Models;

namespace RockHolidays.Data.Repository.Interfaces
{
    /// <summary>
    /// Contract for holiday request repository
    /// </summary>
    public interface IHolidayRequestRepository : IRepository<HolidayRequest>
    {

    }
}
