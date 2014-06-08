using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockHolidays.Data.Infrastructure;
using RockHolidays.Data.Repository.Interfaces;
using RockHolidays.Model.Models;

namespace RockHolidays.Data.Repository
{
    public class HolidayRequestRepository : RepositoryBase<HolidayRequest>, IHolidayRequestRepository
    {
        public HolidayRequestRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
}
