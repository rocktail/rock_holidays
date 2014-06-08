﻿using System;
using System.Collections.Generic;
using RockHolidays.Model.Models;
namespace RockHolidays.Service
{
    /// <summary>
    /// Contract for holiday request service
    /// </summary>
    public interface IHolidayRequestService
    {
        HolidayRequest CreateHolidayRequest(HolidayRequest holidayRequest);

        void SaveHolidayRequest();
    }
}
