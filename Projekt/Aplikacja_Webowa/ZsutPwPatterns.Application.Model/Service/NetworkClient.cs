//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.Application.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.Net.Http;
    using System.Text.Json;

    public class NetworkClient : INetwork
    {
        private readonly ServiceClient serviceClient;

        public NetworkClient(string serviceHost, int servicePort)
        {
            Debug.Assert(condition: !String.IsNullOrEmpty(serviceHost) && servicePort > 0);

            this.serviceClient = new ServiceClient(serviceHost, servicePort);
        }

        public void ReserveVisit(VisitData visit)
        {
            string callUri = string.Format("reserveVisit");
            var body = JsonSerializer.Serialize(visit);
            this.serviceClient.PostCallWebService(HttpMethod.Post, callUri, body);
        }

        public List<PrescriptionData> GetPrescriptionByPationIdList(string patientId)

        {
            string callUri = string.Format("patientsPrescriptions" + "?patientId=" + patientId);
            List<PrescriptionData> result = this.serviceClient.CallWebService<List<PrescriptionData>>(HttpMethod.Get, callUri);
            return result;
        }


        public List<VisitData> GetVisitByPationIdList(string patientId)
        {
            string callUri = string.Format("visitsCalendar" + "?patientId=" + patientId);
            List<VisitData> result = this.serviceClient.CallWebService<List<VisitData>>(HttpMethod.Get, callUri);
            return result;
        }

        public List<VisitData> GetAllVisits()
        {
            string callUri = string.Format("visits");
            List<VisitData> result = this.serviceClient.CallWebService<List<VisitData>>(HttpMethod.Get, callUri);
            return result;
        }

        public List<string> GetPatientsFavoriteDrug(string patientId)
        {
            string callUri = string.Format("favoriteDrugs" + "?patientId=" + patientId);
            List<string> result = this.serviceClient.CallWebService<List<string>>(HttpMethod.Get, callUri);
            return result;
        }
    }
}
