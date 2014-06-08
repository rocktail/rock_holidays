using System;
using System.Collections.Generic;
using RockHolidays.Data.Infrastructure;
using RockHolidays.Data.Repository.Interfaces;
using RockHolidays.Model.Models;
using RockHolidays.Service.Interfaces;

namespace RockHolidays.Service
{
    /// <summary>
    /// Service performing business logic for holiday requests
    /// </summary>
    public class HolidayRequestService : IHolidayRequestService
    {
        private IHolidayRequestRepository _holidayRequestRepository;
        private IUnitOfWork _unitOfWork;

        public HolidayRequestService(IHolidayRequestRepository holidayRequestRepository, IUnitOfWork unitOfWork)
        {
            this._holidayRequestRepository = holidayRequestRepository;
            this._unitOfWork = unitOfWork;
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
            this._unitOfWork.Commit();
        }
    }
}