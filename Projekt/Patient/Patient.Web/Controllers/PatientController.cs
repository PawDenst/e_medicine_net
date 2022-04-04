using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Patient.Web.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patient.Web.Application.Commands;
using Patient.Web.Application.Dtos;

namespace Patient.Web.Controllers
{
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> logger;
        private readonly IPatientHandler PatientHandler;


        public PatientController(ILogger<PatientController> logger, IPatientHandler PatientHandler)
        {
            this.logger = logger;
            this.PatientHandler = PatientHandler;
        }

        [HttpPost("reserveVisit")]
        public void AddVisit([FromBody] AddVisitCommand visitCommand)
        {
            PatientHandler.AddNewVisit(visitCommand);
        }

        [HttpGet("visitsCalendar")]
        public async Task<IEnumerable<VisitDto>> GetVisitsByPatientId([FromQuery] int patientId)
        {
            return (await PatientHandler.GetVisitsByPatientId(patientId));

        }

        [HttpGet("patientsPrescriptions")]
        public async Task<IEnumerable<PrescriptionDto>> GetPresciptionsByPatientName([FromQuery] int patientId)
        {
            return (await PatientHandler.GetPrescriptionsByPatientId(patientId));
        }
        [HttpGet("visits")]
        public async Task<IEnumerable<VisitDto>> GetAllVisits()
        {
            return await PatientHandler.GetAllVisits();
        }
        [HttpGet("favoriteDrugs")]
        public List<string> GetFavoriteDrugs([FromQuery] int patientId)
        {
            return  PatientHandler.GetFavoriteDrugs(patientId);
        }



    }

    
}
