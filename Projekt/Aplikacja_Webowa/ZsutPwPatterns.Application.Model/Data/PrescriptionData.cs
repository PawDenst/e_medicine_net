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

    public class PrescriptionData
    {
        public string dateOfIssue { get; set; }
        public int doctorId { get; set; }
        public string doctorName { get; set; }
        public string doctorSurname { get; set; }
        public IEnumerable<string> drugs { get; set; }
        public string expirationDate { get; set; }
        public int patientId { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }

    }
}
