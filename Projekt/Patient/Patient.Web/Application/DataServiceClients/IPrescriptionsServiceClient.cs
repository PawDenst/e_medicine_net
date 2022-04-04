using Patient.Web.Application.Commands;
using Patient.Web.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Web.Application.DataServiceClients
{
    public interface IPrescriptionsServiceClient
    {
        Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByPatientId(int patientId);
    }
}
