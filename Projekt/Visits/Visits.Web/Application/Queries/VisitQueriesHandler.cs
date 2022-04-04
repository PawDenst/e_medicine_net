namespace Visits.Web.Application
{
    using Visits.Domain;
    using Visits.Domain.VisitAggregate;
    using Visits.Web.Application.Mapper;
    using Visits.Web.Application.Dtos;
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    using Visits.Web.Application.Commands;

    public class VisitQueriesHandler : IVisitQueriesHandler
    {
        private readonly IVisitsRepository visitsRepository;

        public VisitQueriesHandler(IVisitsRepository visitsRepository)
        {
            this.visitsRepository = visitsRepository;
        }

        public async Task<IEnumerable<VisitDto>> GetVisitsByPatientId(int patientId)  
        {
            return (await visitsRepository.GetVisitsByPatientId(patientId)).Select(Id => Id.Map());
        }

        public async Task<IEnumerable<VisitDto>> GetVisitsByDoctorId(int doctorId)
        {
            return (await visitsRepository.GetVisitsByDoctorId(doctorId)).Select(Id => Id.Map());
        }
        public async Task<IEnumerable<VisitDto>> GetAllAsync()
        {
             return (await visitsRepository.GetAllAsync()).Select(r => r.Map());
          }

        public Task<IEnumerable<VisitDto>> AddVisitsByPatientName(AddVisitCommand AddvisitCommand)
        {
            throw new NotImplementedException();
        }
    }
}
