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

namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Model.Data;

    public partial class Model : IData
    {
        public string SearchText
        {
            get { return this.searchText; }
            set
            {
                this.searchText = value;

                this.RaisePropertyChanged("SearchText");
            }
        }
        private string searchText;


        public List<FavouritePatientData> SelectionList
        {
            get { return this.SelectionList; }
            private set
            {
                this.selectionList = value;

                this.RaisePropertyChanged("SelectionList");
            }
        }
        private List<FavouritePatientData> selectionList = new List<FavouritePatientData>();

        public FavouritePatientData SelectedDoctorRoomData
        {
            get { return this.selectedDoctorRoomData; }
            set
            {
                this.selectedDoctorRoomData = value;

                this.RaisePropertyChanged("SelectedDoctorRoomData");
            }
        }
        private FavouritePatientData selectedDoctorRoomData;



    }
}
