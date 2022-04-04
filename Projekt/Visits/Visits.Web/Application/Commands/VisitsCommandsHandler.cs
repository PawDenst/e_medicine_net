using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Visits.Domain.VisitAggregate;

namespace Visits.Web.Application.Commands
{
    public class VisitsCommandsHandler : ICommandHandler<AddVisitCommand>
    {
        private readonly IVisitsRepository visitsRepository;
    
        public VisitsCommandsHandler(IVisitsRepository visitsRepository)
        {
            this.visitsRepository = visitsRepository;
        }

        public void Handle(AddVisitCommand command)
        {
            var Visit = new Visit(0, command.VisitDate, command.RoomNumber, new Doctor(0, command.DoctorName, command.DoctorSurname), new Patient(0, command.PatientName, command.PatientSurname));
            visitsRepository.AddVisitAsync(Visit);
        }
    }
}
