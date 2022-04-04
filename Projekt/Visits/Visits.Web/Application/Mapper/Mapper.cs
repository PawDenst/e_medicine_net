namespace Visits.Web.Application.Mapper
{
    using Visits.Domain.VisitAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Visits.Web.Application.Dtos;

    public static class Mapper
    {
        public static VisitDto Map(this Visit visit)
        {
            if (visit == null)
                return null;

            return new VisitDto
            {

                DoctorName = visit.Doctor.Name,
                DoctorSurname = visit.Doctor.Surname,

                PatientName = visit.Patient.Name,
                PatientSurname = visit.Patient.Surname,
                VisitDate = visit.VisitDate,
                RoomNumber = visit.RoomNumber


            };
        }
    }
}
