using Patient.Web.Application.Commands;
using Patient.Web.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Web.Application.Queries
{
    public interface IPatientHandler
    {
        public void AddNewVisit(AddVisitCommand visitCommand);
        Task<IEnumerable<VisitDto>> GetVisitsByPatientId(int patientId);
        Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByPatientId(int patientId);
        Task<IEnumerable<VisitDto>> GetAllVisits();
        List<string> GetFavoriteDrugs(int patientid);
    }
}
