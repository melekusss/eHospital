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
        public ICommand ShowFavouritePatientsCommand { get; private set; }
        public ICommand ShowPrescriptionListCommand { get; private set; }
        public ICommand AddPrescriptionCommand { get; private set; }




        private void ShowPresciptionList()
        {
            this.Model.LoadPrescriptionList();
        }
        private void ShowVisitList()
        {
            this.Model.LoadVistList();
        }

        private void AddPrescription()
        {
            this.Model.AssignPrescription();
        }

        private void ShowFavouritePatientsList()
        {
            this.Model.LoadFavouritePatientsList();
        }

        public async Task ShowListAsync()
        {
            await Task.Run(() => this.ShowList());
        }

        public async Task ShowMapAsync()
        {
            await Task.Run(() => this.ShowMap());
        }

        public async Task ShowAdditionAsync()
        {
            await Task.Run(() => this.ShowAddition());
        }

        public async Task ShowViewAsync()
        {
            await Task.Run(() => this.ShowView());
        }

        public async Task ShowVisitListAsync()
        {
            await Task.Run(() => this.ShowVisitList());
        }

        public async Task ShowPrescriptionListAsync()
        {
            await Task.Run(() => this.ShowPresciptionList());
        }

        public async Task ShowFavouritePatientsAsync()
        {
            await Task.Run(() => this.ShowFavouritePatientsList());
        }

        public async Task AddPrescriptionAsync()
        {
            await Task.Run(() => this.AddPrescription());
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
        public void ShowList(ApplicationState applicationState)
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
    }
}
