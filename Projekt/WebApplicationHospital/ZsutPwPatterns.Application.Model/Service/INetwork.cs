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
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using ZsutPwPatterns.Application.Model.Data;
    public interface INetwork
    {
        List<FavouritePatientData> GetFavouritePatients(string doctorId);
        List<VisitData> GetVisitByDoctorIdList(string id);

        List<PrescriptionData> GetPrescriptionByDoctorIdList(string id);

        void AssignPrescription(PrescriptionToSendData prescription);
    }
}
