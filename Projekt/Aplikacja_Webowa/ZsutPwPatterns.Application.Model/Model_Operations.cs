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
    

    public partial class Model : IOperations
    {
        public void LoadPrescriptionList()
        {
            Task.Run(() => this.LoadPrescriptionListTask());
        }


        public void LoadVistList()
        {
            Task.Run(() => this.LoadVisitListTask());
        }


        public void LoadEveryVisitList()
        {
            Task.Run(() => this.LoadEveryVisitListTask());
        }

        public void LoadDrugsList()
        {
            Task.Run(() => this.LoadDrugsListTask());
        }

        public void ReserveVisit()
        {
            Task.Run(() => this.ReserveVisitTask());
        }

        private void LoadPrescriptionListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                List<PrescriptionData> resultPrescriptionData = networkClient.GetPrescriptionByPationIdList(this.SearchPrescriptionPatientId);

                this.PrescriptionList = resultPrescriptionData;
            }
            catch (Exception)
            {
            }
        }
        private void LoadVisitListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                List<VisitData> resultVisitData = networkClient.GetVisitByPationIdList(this.SearchVisitPatientId);

                this.VisitList = resultVisitData;
            }
            catch (Exception)
            {
            }
        }

        private void LoadEveryVisitListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                List<VisitData> resultVisitData = networkClient.GetAllVisits();

                this.EveryVisitList = resultVisitData;
            }
            catch (Exception)
            {
            }
        }

        private void ReserveVisitTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();

            try
            {
                networkClient.ReserveVisit(this.ReservationVisitData);
                VisitData emptyVisit = new VisitData();
                this.ReservationVisitData = emptyVisit;
            }
            catch (Exception)
            {
            }

        }
        private void LoadDrugsListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetNetworkClient();
            List<DrugData> empty = new List<DrugData>();
            this.DrugsList = empty;
            try
            {
                foreach (var drug in networkClient.GetPatientsFavoriteDrug(this.SearchDrugsPatientId))
                {
                    var newDrug = new DrugData { Drug = drug };
                    this.DrugsList.Add(newDrug);
                }   

            }
            catch (Exception)
            {
            }

        }
    }
}
