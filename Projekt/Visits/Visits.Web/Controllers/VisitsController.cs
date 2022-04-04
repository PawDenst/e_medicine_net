
namespace Visits.Web.Controllers { 
using Visits.Domain;
using Visits.Domain.VisitAggregate;
using Visits.Web.Application;
using Visits.Web.Application.Commands;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    using Visits.Web.Application.Dtos;
  

    [ApiController]

    public class VisitsController : ControllerBase
    {
        private readonly ILogger<VisitsController> logger;
        private readonly IVisitQueriesHandler visitQueriesHandler;
        private readonly ICommandHandler<AddVisitCommand> addVisitCommandHandler;

        public VisitsController(ILogger<VisitsController> logger, IVisitQueriesHandler visitQueriesHandler, ICommandHandler<AddVisitCommand> addVisitCommandHandler)
        {
            this.logger = logger;
            this.visitQueriesHandler = visitQueriesHandler;
            this.addVisitCommandHandler = addVisitCommandHandler;
        }
        [HttpGet("visits")]
        public async Task<IEnumerable<VisitDto>> GetAllAsync()
        {
            return await visitQueriesHandler.GetAllAsync();
        }
        [HttpGet("visitsByPatientId")]
        public async Task<IEnumerable<VisitDto>> GetVisitsByPatientId([FromQuery] int patientId)
        {
            return await visitQueriesHandler.GetVisitsByPatientId(patientId);
        }
        [HttpGet("visitsByDoctorId")]
        public async Task<IEnumerable<VisitDto>> GetVisitsByDoctorId([FromQuery] int doctorId)
        {
            return await visitQueriesHandler.GetVisitsByDoctorId(doctorId);
        }

        [HttpPost("addVisit")]
        public void AddVisit([FromBody] AddVisitCommand visitCommand)
        {
            addVisitCommandHandler.Handle(visitCommand);
        }

    }
}
