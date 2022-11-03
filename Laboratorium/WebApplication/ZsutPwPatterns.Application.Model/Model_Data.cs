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

        public List<DoctorRoomData> SelectionList
        {
            get { return this.selectionList; }
            private set
            {
                this.selectionList = value;

                this.RaisePropertyChanged("SelectionList");
            }
        }

        private List<DoctorRoomData> selectionList = new List<DoctorRoomData>();


        public DoctorRoomData SelectedDoctorRoomData
        {
            get { return this.selectedDoctorRoomData; }
            set
            {
                this.selectedDoctorRoomData = value;

                this.RaisePropertyChanged("SelectedDoctorRoomData");
            }
        }
        private DoctorRoomData selectedDoctorRoomData;

    }
}
