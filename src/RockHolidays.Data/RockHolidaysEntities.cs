﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockHolidays.Data
{
    public class RockHolidaysEntities : DbContext
    {
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
