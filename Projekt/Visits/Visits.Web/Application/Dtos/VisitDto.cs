using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visits.Domain.VisitAggregate;

namespace Visits.Web.Application.Dtos
{
    public class VisitDto
    {
        public string VisitDate { get; set; }
        public string RoomNumber { get; set; }
        public string DoctorSurname { get; internal set; }
        public string DoctorName { get; internal set; }
        public string PatientName { get; internal set; }
        public string PatientSurname { get; internal set; }
    }
}