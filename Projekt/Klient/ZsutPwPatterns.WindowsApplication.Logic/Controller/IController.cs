namespace ZsutPw.Patterns.WindowsApplication.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using System.ComponentModel;
    using System.Windows.Input;

    using ZsutPw.Patterns.WindowsApplication.Model;

    public interface IController : INotifyPropertyChanged
    {
        IModel Model { get; }

        ApplicationState CurrentState { get; }


        ICommand ShowListCommand { get; }
        ICommand ShowMapCommand { get; }
        ICommand ShowAdditionCommand { get; }
        ICommand ShowViewCommand { get; }

        ICommand ShowVisitListCommand { get; }
        ICommand ShowPrescriptionListCommand { get; }
        ICommand ShowFavouritePatientsCommand { get; }
        ICommand AddPrescriptionCommand { get; }
    }
}

