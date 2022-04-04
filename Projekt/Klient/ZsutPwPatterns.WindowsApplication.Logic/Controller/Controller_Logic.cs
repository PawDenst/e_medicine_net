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

namespace ZsutPw.Patterns.WindowsApplication.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.Windows.Input;

    public partial class Controller : IController
    {
        public ApplicationState CurrentState
        {
            get { return this.currentState; }
            set
            {
                this.currentState = value;

                this.RaisePropertyChanged("CurrentState");
            }
        }
        private ApplicationState currentState = ApplicationState.List;


        public ICommand ShowListCommand { get; private set; }

        public ICommand ShowMapCommand { get; private set; }
        public ICommand ShowViewCommand { get; private set; }
        public ICommand ShowAdditionCommand { get; private set; }

        public ICommand ShowVisitListCommand { get; private set; }
        public ICommand ShowDrugsListCommand { get; private set; }
        public ICommand ShowDrugsCommand { get; private set; }
        public ICommand ShowEveryVisitListCommand { get; private set; }

        public ICommand ShowPrescriptionListCommand { get; private set; }
        public ICommand AddVisitCommand { get; private set; }

        private void ShowPresciptionList()
        {
            this.Model.LoadPrescriptionList();
        }
        private void ShowVisitList()
        {
            this.Model.LoadVistList();
        }
        private void ShowDrugsList()
        {
            this.Model.LoadDrugsList();
        }
        private void AddVisit()
        {
            this.Model.ReserveVisit();
        }

        private void ShowEveryVisitList()
        {
            this.Model.LoadEveryVisitList();
        }
        private void ShowList()
        {
            switch (this.CurrentState)
            {
                case ApplicationState.List:
                    break;

                default:
                    this.CurrentState = ApplicationState.List;
                    break;
            }
        }

        private void ShowMap()
        {
            switch (this.CurrentState)
            {
                case ApplicationState.Map:
                    break;

                default:
                    this.CurrentState = ApplicationState.Map;
                    break;
            }
        }

        private void ShowAddition()
        {
            switch (this.CurrentState)
            {
                case ApplicationState.Addition:
                    break;

                default:
                    this.CurrentState = ApplicationState.Addition;
                    break;
            }
        }
        private void ShowView()
        {
            switch (this.CurrentState)
            {
                case ApplicationState.View:
                    break;

                default:
                    this.CurrentState = ApplicationState.View;
                    break;
            }
        }

        private void ShowDrugs()
        {
            switch (this.CurrentState)
            {
                case ApplicationState.Drugs:
                    break;

                default:
                    this.CurrentState = ApplicationState.Drugs;
                    break;
            }
        }
    }
}
