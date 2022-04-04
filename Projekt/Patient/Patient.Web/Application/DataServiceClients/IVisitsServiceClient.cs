using Patient.Web.Application.Commands;
using Patient.Web.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Web.Application.DataServiceClients
{
    public interface IVisitsServiceClient
    {
        public void PostVisit(AddVisitCommand command);
        Task<IEnumerable<VisitDto>> GetVisitsByPatientId(int patientId);
        Task<IEnumerable<VisitDto>> GetAllVisits();
    }
}
