namespace Visits.Domain.VisitAggregate
{

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public interface IVisitsRepository
    {
        Task <IEnumerable<Visit>> GetVisitsByPatientId(int patientId);
        Task AddVisitAsync(Visit visit);
        Task<IEnumerable<Visit>> GetAllAsync();
        Task<IEnumerable<Visit>> GetVisitsByDoctorId(int doctorId);
    }
}
