using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDatabaseFactory _databaseFactory;
        private RockHolidaysEntities _dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this._databaseFactory = databaseFactory;
        }

        protected RockHolidaysEntities DataContext
        {
            get
            {
                return this._dataContext ?? (this._dataContext = this._databaseFactory.Get());
            }
        }

        public void Commit()
        {
            this.DataContext.Commit();
        }
    }
}
