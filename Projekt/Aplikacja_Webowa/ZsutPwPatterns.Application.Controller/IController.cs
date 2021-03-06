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

namespace ZsutPw.Patterns.Application.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.ComponentModel;
    using System.Windows.Input;

    using ZsutPw.Patterns.Application.Model;

    public interface IController : INotifyPropertyChanged
    {
        IModel Model { get; }

 

        ApplicationState CurrentState { get; }
        ICommand ShowListCommand { get; }
        ICommand ShowMapCommand { get; }
        ICommand ShowAdditionCommand { get; }
        ICommand ShowViewCommand { get; }
        ICommand ShowDrugsCommand { get; }
        ICommand ShowVisitListCommand { get; }
        ICommand ShowDrugsListCommand { get; }
        ICommand ShowPrescriptionListCommand { get; }
        ICommand ShowEveryVisitListCommand { get; }
        ICommand AddVisitCommand { get; }

       

        Task ShowMapAsync();
        Task ShowListAsync();
        Task ShowDrugsListAsync();
        Task ShowVisitListAsync();
        Task ShowEveryVisitListAsync();
        Task AddVisitAsync();
        Task ShowPrescriptionListAsync();
    }

}
