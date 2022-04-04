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
    

    public partial class Model : IData
    {
        public string SearchPrescriptionPatientId
        {
            get { return this.searchPrescriptionPatientId; }
            set
            {
                this.searchPrescriptionPatientId = value;

                this.RaisePropertyChanged("SearchPrescriptionPatientId ");
            }
        }
        private string searchPrescriptionPatientId;


        public string SearchVisitPatientId
        {
            get { return this.searchVisitPatientId; }
            set
            {
                this.searchVisitPatientId = value;

                this.RaisePropertyChanged("SearchVisitPatientId ");
            }
        }
        private string searchVisitPatientId;
        public string SearchDrugsPatientId
        {
            get { return this.searchDrugsPatientId; ; }
            set
            {
                this.searchDrugsPatientId = value;

                this.RaisePropertyChanged("SearchDrugsPatientId");
            }
        }
        private string searchDrugsPatientId;

        public List<VisitData> VisitList
        {
            get { return this.visitList; }
            private set
            {
                this.visitList = value;

                this.RaisePropertyChanged("VisitList");
            }
        }

        private List<VisitData> visitList = new List<VisitData>();

        public List<DrugData> DrugsList
        {
            get { return this.drugsList; }
            private set
            {
                this.drugsList = value;

                this.RaisePropertyChanged("DrugsList");
            }
        }

        private List<DrugData> drugsList = new List<DrugData>();

        public List<VisitData> EveryVisitList
        {
            get { return this.everyVisitList; }
            private set
            {
                this.everyVisitList = value;

                this.RaisePropertyChanged("EveryVisitList");
            }
        }

        private List<VisitData> everyVisitList = new List<VisitData>();

        public List<PrescriptionData> PrescriptionList
        {
            get { return this.prescriptionList; }
            private set
            {
                this.prescriptionList = value;

                this.RaisePropertyChanged("PrescriptionList");
            }
        }

        private List<PrescriptionData> prescriptionList = new List<PrescriptionData>();

        public VisitData SelectedVisitData
        {
            get { return this.selectedVisitData; }
            set
            {
                this.selectedVisitData = value;

                this.RaisePropertyChanged("SelectedVisitData");
            }
        }
        private VisitData selectedVisitData;

        public PrescriptionData SelectedPrescriptionData
        {
            get { return this.selectedPrescriptionData; }
            set
            {
                this.selectedPrescriptionData = value;

                this.RaisePropertyChanged("SelectedPrescriptionData");
            }
        }
        private PrescriptionData selectedPrescriptionData;


        public VisitData ReservationVisitData
        {
            get { return this.reservationVisitData; }
            set
            {
                this.reservationVisitData = value;

                this.RaisePropertyChanged("ReservationVisitData");
            }
        }
        private VisitData reservationVisitData = new VisitData();
    }
}
