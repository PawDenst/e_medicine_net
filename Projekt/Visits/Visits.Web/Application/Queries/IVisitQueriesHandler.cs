namespace Visits.Web.Application
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Visits.Web.Application.Commands;
    using Visits.Web.Application.Dtos;

    public interface IVisitQueriesHandler
    {
        Task<IEnumerable<VisitDto>> GetVisitsByPatientId(int patientId);
        Task<IEnumerable<VisitDto>> AddVisitsByPatientName(AddVisitCommand AddvisitCommand);
        Task<IEnumerable<VisitDto>> GetAllAsync();
        Task<IEnumerable<VisitDto>> GetVisitsByDoctorId(int doctorId);
    }
}
