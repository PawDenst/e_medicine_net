namespace Visits.Web.Application.Commands
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visits.Domain.VisitAggregate;


    public class AddVisitCommand : ICommand
    {
        public string VisitDate { get; set; }
        public string RoomNumber { get; set; }
        public string DoctorName { get;  set; }
        public string DoctorSurname { get; set; }
        public string PatientName { get;  set; }
        public string PatientSurname { get;  set; }
    }
}
