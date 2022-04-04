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
    

    public interface INetwork
    {
        List<VisitData> GetVisitByPationIdList(string id);
        List<string> GetPatientsFavoriteDrug(string id);

        List<PrescriptionData> GetPrescriptionByPationIdList(string id);

        void ReserveVisit(VisitData visit);

        List<VisitData> GetAllVisits();
    }
}
