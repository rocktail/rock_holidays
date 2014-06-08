using System;
using System.Collections.Generic;
using RockHolidays.Data.Repository.Interfaces;
using RockHolidays.Model.Models;

namespace RockHolidays.Service
{
    /// <summary>
    /// Service performing business logic for holiday requests
    /// </summary>
    public class HolidayRequestService : RockHolidays.Service.IHolidayRequestService
    {
        private IHolidayRequestRepository _holidayRequestRepository;

        public HolidayRequestService(IHolidayRequestRepository holidayRequestRepository)
        {
            this._holidayRequestRepository = holidayRequestRepository;
        }

        public HolidayRequest CreateHolidayRequest(HolidayRequest holidayRequest)
        {
            this._holidayRequestRepository.Add(holidayRequest);

            //TODO: add saving
            return holidayRequest;
        }
    }
}