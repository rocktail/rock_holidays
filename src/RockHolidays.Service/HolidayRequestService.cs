using System;
using System.Collections.Generic;
using RockHolidays.Data.Repository.Interfaces;
using RockHolidays.Model.Models;

namespace RockHolidays.Service
{
    /// <summary>
    /// Service performing business logic for holiday requests
    /// </summary>
    public class HolidayRequestService : IHolidayRequestService
    {
        private IHolidayRequestRepository _holidayRequestRepository;

        public HolidayRequestService(IHolidayRequestRepository holidayRequestRepository)
        {
            this._holidayRequestRepository = holidayRequestRepository;
        }

        public HolidayRequest CreateHolidayRequest(HolidayRequest holidayRequest)
        {
            this._holidayRequestRepository.Add(holidayRequest);
            this.SaveHolidayRequest();

            //we also need to save new holiday request transaction when creating one
            //TODO: save holiday request transaction
            return holidayRequest;
        }

        public void SaveHolidayRequest()
        {
            //TODO: commit unit of work
        }
    }
}