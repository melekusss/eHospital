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
  using ZsutPwPatterns.Application.Model.Data;

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


        public void LoadFavouritePatientsList()
        {
            Task.Run(() => this.LoadFavouritePatientsListTask());
        }

        public void AssignPrescription()
        {
            Task.Run(() => this.AssignPrescriptionTask());
        }



        private void LoadPrescriptionListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetDoctorClient();

            try
            {
                List<PrescriptionData> resultPrescriptionData = networkClient.GetPrescriptionByDoctorIdList(this.SearchPrescriptionDoctorId);

                this.PrescriptionList = resultPrescriptionData;
            }
            catch (Exception)
            {
            }
        }
        private void LoadVisitListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetDoctorClient();

            try
            {
                List<VisitData> resultVisitData = networkClient.GetVisitByDoctorIdList(this.SearchVisitDoctorId);

                this.VisitList = resultVisitData;
            }
            catch (Exception)
            {
            }
        }

        private void LoadFavouritePatientsListTask()
        {
            INetwork networkClient = NetworkClientFactory.GetDoctorClient();

            try
            {
                List<FavouritePatientData> selectionList = networkClient.GetFavouritePatients(this.SearchFavouritePatientDoctorId);

                this.FavouritePatientsList = selectionList;
            }
            catch (Exception)
            {
            }
        }

        

        public PrescriptionToSendData AssignPrescriptionTask(TemporaryPrescriptionData prescriptionData)
        {
            PrescriptionToSendData prescription = new PrescriptionToSendData();

            try
            {
                IEnumerable<string> tmpDrugs = prescriptionData.drugs.Split(',');

                prescription = new PrescriptionToSendData()
                {
                    dateOfIssue = prescriptionData.dateOfIssue,
                    doctorName = prescriptionData.doctorName,
                    doctorSurname = prescriptionData.doctorSurname,
                    drugs = tmpDrugs,
                    expirationDate = prescriptionData.expirationDate,
                    patientName = prescriptionData.patientName,
                    patientSurname = prescriptionData.patientSurname
                };

                return prescription;

            }
            catch (Exception)
            {
                return prescription;
            }

        }
        
        private void AssignPrescriptionTask()
        {
            INetwork networkClient = NetworkClientFactory.GetDoctorClient();

            try
            {
                IEnumerable<string> tmpDrugs = this.AssignedPrescriptionData.drugs.Split(',');

                PrescriptionToSendData prescription = new PrescriptionToSendData()
                {
                    dateOfIssue = this.AssignedPrescriptionData.dateOfIssue,
                    doctorName = this.AssignedPrescriptionData.doctorName,
                    doctorSurname = this.AssignedPrescriptionData.doctorSurname,
                    drugs = tmpDrugs,
                    expirationDate = this.AssignedPrescriptionData.expirationDate,
                    patientName = this.AssignedPrescriptionData.patientName,
                    patientSurname = this.AssignedPrescriptionData.patientSurname
                };




                networkClient.AssignPrescription(prescription);
                TemporaryPrescriptionData emptyPrescription = new TemporaryPrescriptionData();
                this.AssignedPrescriptionData = emptyPrescription;
            }
            catch (Exception)
            {
            }

        }
        
    }
}
