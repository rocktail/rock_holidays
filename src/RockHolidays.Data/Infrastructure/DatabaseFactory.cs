using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Data.Infrastructure
{
    public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private RockHolidaysEntities _dataContext;

        public RockHolidaysEntities Get()
        {
            return this._dataContext ?? (this._dataContext = new RockHolidaysEntities());
        }

        protected override void DisposeCore()
        {
            if (this._dataContext != null)
                this._dataContext.Dispose();
        }
    }
}
