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

    public class VisitData
    {
        public string doctorName { get; set; }
        public string doctorSurname { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }
        public string visitDate { get; set; }
        public string roomNumber { get; set; }
    }
}
