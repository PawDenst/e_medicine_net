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
 

    public class FakeNetworkClient : INetwork
    {
        private static readonly List<VisitData> fakeVisits = new List<VisitData> { new VisitData { doctorName = "Jan", doctorSurname = "Kowalski", patientName = "Jakub", patientSurname = "Nowak", roomNumber = "1", visitDate = "21/10/2021" }, new VisitData { doctorName = "John", doctorSurname = "Smith", patientName = "Jake", patientSurname = "Green", roomNumber = "2", visitDate = "10/11/2021" } };
        private static readonly List<PrescriptionData> fakePrescriptions = new List<PrescriptionData> { new PrescriptionData { doctorName = "Jan", doctorSurname = "Kowalski", patientName = "Jakub", patientSurname = "Nowak", drugs = new string[] { "Paracetamol", "Kodeina" }, patientId = 1, doctorId = 2, dateOfIssue = "10/06/2021", expirationDate = "11/09/2021" }, new PrescriptionData { doctorName = "Stefan", doctorSurname = "Testowy", patientName = "Maciek", patientSurname = "Zapasowy", drugs = new string[] { "Kofeina", "Viagra" }, patientId = 2, doctorId = 3, dateOfIssue = "10/06/2021", expirationDate = "29/07/2021" } };
        private static readonly List<string> fakeDrugs = new List<string> { "Paracetamol", "testowy" };
        public void ReserveVisit(VisitData visit)
        {
            var test = "1";
        }



        public List<PrescriptionData> GetPrescriptionByPationIdList(string id)
        {
            return FakeNetworkClient.fakePrescriptions;
        }


        public List<VisitData> GetVisitByPationIdList(string id)
        {
            return FakeNetworkClient.fakeVisits;
        }

        public List<VisitData> GetAllVisits()
        {
            return FakeNetworkClient.fakeVisits;
        }

        public List<string> GetPatientsFavoriteDrug(string id)
        {
            return FakeNetworkClient.fakeDrugs;
        }
    }
}
