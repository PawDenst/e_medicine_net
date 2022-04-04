using Patient.Web.Application.Commands;
using Patient.Web.Application.DataServiceClients;
using Patient.Web.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Web.Application.Queries
{
    public class PatientQueryHandler : IPatientHandler
    {
        private readonly IVisitsServiceClient visitsServiceClient;
        private readonly IPrescriptionsServiceClient prescriptionsServiceClient;

        public PatientQueryHandler(IVisitsServiceClient visitsServiceClient, IPrescriptionsServiceClient prescriptionsServiceClient)
        {
            this.visitsServiceClient = visitsServiceClient;
            this.prescriptionsServiceClient = prescriptionsServiceClient;
        }

        public PatientQueryHandler()
        {
        }

        public void AddNewVisit(AddVisitCommand visitCommand)
        {
            visitsServiceClient.PostVisit(visitCommand);
        }

        public async Task<IEnumerable<VisitDto>> GetVisitsByPatientId(int patientId)
        {
            return (await visitsServiceClient.GetVisitsByPatientId(patientId));
        }

        public async Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByPatientId(int patientId)
        {
            return (await  prescriptionsServiceClient.GetPrescriptionsByPatientId(patientId));
        }

        public async Task<IEnumerable<VisitDto>> GetAllVisits()
        {
            return await visitsServiceClient.GetAllVisits();
        }

        public List<string> GetFavoriteDrugs(int patientid)
        {
            IEnumerable<PrescriptionDto> prescriptionList = GetPrescriptionsByPatientId(patientid).Result;
            var result = FavoriteDrugs(prescriptionList);
            return result;
        }

       public  List<string> FavoriteDrugs(IEnumerable<PrescriptionDto> prescriptionList)
        {
            List<string> favoriteDrugsList = new List<string>();
            Dictionary<string, int> drugCounter = new Dictionary<string, int>();
            foreach ( var prescription in prescriptionList)
            {
                foreach( var drug in prescription.Drugs)
                {
                    if (drugCounter.ContainsKey(drug))
                    {
                        drugCounter[drug] = drugCounter[drug]+1;
                    }
                    else {
                        drugCounter.Add(drug, 1);
                    }
                }
            }
            foreach (KeyValuePair<string,int> drugs in drugCounter)
            {
                if (drugs.Value == drugCounter.Values.Max())
                {
                    favoriteDrugsList.Add(drugs.Key);
                }
            }
            return favoriteDrugsList;
        }
    }
}
