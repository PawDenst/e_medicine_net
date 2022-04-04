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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.ComponentModel;
    

    public interface IData : INotifyPropertyChanged
    {
        List<PrescriptionData> PrescriptionList { get; }

        PrescriptionData SelectedPrescriptionData { get; set; }

        List<VisitData> VisitList { get; }
        List<DrugData> DrugsList { get; }

        List<VisitData> EveryVisitList { get; }

        VisitData SelectedVisitData { get; set; }

        VisitData ReservationVisitData { get; set; }

        string SearchPrescriptionPatientId { get; set; }
        string SearchVisitPatientId { get; set; }
        string SearchDrugsPatientId { get; set; }
    }
}
