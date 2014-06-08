using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Data.Infrastructure
{
    public class DatabaseFactory: IDatabaseFactory
    {
        private RockHolidaysEntities _dataContext;

        public RockHolidaysEntities Get()
        {
            return this._dataContext ?? (this._dataContext = new RockHolidaysEntities());
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
