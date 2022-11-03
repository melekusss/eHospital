namespace ZsutPw.Patterns.WindowsApplication.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using ZsutPw.Patterns.WindowsApplication.Model;
    using ZsutPw.Patterns.WindowsApplication.Utilities;

    public partial class Controller : PropertyContainerBase, IController
    {
        public IModel Model { get; private set; }



        public Controller(IEventDispatcher dispatcher, IModel model) : base(dispatcher)
        {
            this.Model = model;


            this.ShowListCommand = new ControllerCommand(this.ShowList);
            this.ShowMapCommand = new ControllerCommand(this.ShowMap);
            this.ShowAdditionCommand = new ControllerCommand(this.ShowAddition);
            this.ShowViewCommand = new ControllerCommand(this.ShowView);


            this.ShowVisitListCommand = new ControllerCommand(this.ShowVisitList);
            this.ShowFavouritePatientsCommand = new ControllerCommand(this.ShowFavouritePatientsList);
            this.ShowPrescriptionListCommand = new ControllerCommand(this.ShowPresciptionList);
            this.AddPrescriptionCommand = new ControllerCommand(this.AddPrescription);
        }

       
    }
}
