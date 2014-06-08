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
        private IHolidayRequestJournalEntryRepository _holidayRequestJournalEntryRepository;

        public HolidayRequestService(IHolidayRequestRepository holidayRequestRepository
                                   , IUnitOfWork unitOfWork
                                   , IHolidayRequestJournalEntryRepository holidayRequestJournalEntryRepository)
        {
            this._holidayRequestRepository = holidayRequestRepository;
            this._unitOfWork = unitOfWork;
            this._holidayRequestJournalEntryRepository = holidayRequestJournalEntryRepository;
        }

        public HolidayRequest CreateHolidayRequest(HolidayRequest holidayRequest)
        {
            this._holidayRequestRepository.Add(holidayRequest);
            this.SaveHolidayRequest();

            //we also need to save new holiday request transaction when creating one
            var holidayRequestJournalEntry = new HolidayRequestJournalEntry()
            {
                CreatedDate = DateTime.Now
              , Employee = holidayRequest.Employee
              , EmployeeId = holidayRequest.EmployeeId
              , HolidayRequestId = holidayRequest.HolidayRequestId
              , HolidayRequest = holidayRequest
              , OperationDescription = "Utworzenie wniosku o urlop"
            };

            this._holidayRequestJournalEntryRepository.Add(holidayRequestJournalEntry);
            this.SaveHolidayRequest();

            return holidayRequest;
        }

        public void SaveHolidayRequest()
        {
            this._unitOfWork.Commit();
        }
    }
}