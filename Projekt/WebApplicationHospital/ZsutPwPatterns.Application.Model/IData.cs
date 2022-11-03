﻿//===============================================================================
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
  using ZsutPwPatterns.Application.Model.Data;

    public interface IData : INotifyPropertyChanged
  {
        string SearchText { get; set; }

        List<FavouritePatientData> FavouritePatientsList { get; }

        FavouritePatientData SelectedFavouritePatientData { get; set; }

        List<PrescriptionData> PrescriptionList { get; }

        PrescriptionData SelectedPrescriptionData { get; set; }

        List<VisitData> VisitList { get; }

        VisitData SelectedVisitData { get; set; }

        TemporaryPrescriptionData AssignedPrescriptionData { get; set; }

        string SearchPrescriptionDoctorId { get; set; }
        string SearchVisitDoctorId { get; set; }
        string SearchFavouritePatientDoctorId { get; set; }
    }
}
