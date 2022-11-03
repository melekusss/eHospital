namespace Doctor.Web.Application.Queries
{
    using Doctor.Web.Application.Commands;
    using Doctor.Web.Application.DataServiceClients;
    using Doctor.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DoctorQueryHandler : IDoctorHandler
    {
        private readonly IVisitsServiceClient visitsServiceClient;
        private readonly IPrescriptionsServiceClient prescriptionsServiceClient;

        public DoctorQueryHandler(IVisitsServiceClient visitsServiceClient, IPrescriptionsServiceClient prescriptionsServiceClient)
        {
            this.visitsServiceClient = visitsServiceClient;
            this.prescriptionsServiceClient = prescriptionsServiceClient;
        }

        public DoctorQueryHandler()
        {
        }

        public void AddNewPrescription(AddPrescriptionCommand prescriptionCommand)
        {
            prescriptionsServiceClient.PostPrescription(prescriptionCommand);
        }

        public async Task<IEnumerable<VisitDto>> GetVisitsByDoctortId(int doctorId)
        {
            return (await visitsServiceClient.GetVisitsByDoctorId(doctorId));
        }

        public async Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByDoctorId(int doctorId)
        {
            return (await prescriptionsServiceClient.GetPrescriptionsByDoctorId(doctorId));
        }


        public async Task<Dictionary<string, int>> FavouritePatients(int doctorId)
        {
            var doctorVisits = await visitsServiceClient.GetVisitsByDoctorId(doctorId);
            Dictionary<string, int> patienVisitCount = new Dictionary<string, int>();
            Dictionary<string, int> favouritePatients = new Dictionary<string, int>();

            foreach (var visit in doctorVisits) 
            {
                string patientSimpleData = "";

                if (visit.DoctorName.Equals("") || visit.DoctorSurname.Equals("") || visit.PatientName.Equals("") || visit.PatientSurname.Equals("") || visit.RoomNumber.Equals("") || visit.VisitDate.Equals(""))
                    throw new ArgumentException();
                if (!Object.ReferenceEquals(visit.PatientName.GetType(), patientSimpleData.GetType()) || !Object.ReferenceEquals(visit.PatientSurname.GetType(), patientSimpleData.GetType()))
                    throw new ArgumentException();

                patientSimpleData = visit.PatientName + " " + visit.PatientSurname;
                if (!patienVisitCount.ContainsKey(patientSimpleData))
                {
                    patienVisitCount.Add(patientSimpleData, 1);
                }
                else
                {
                    patienVisitCount[patientSimpleData] = patienVisitCount.GetValueOrDefault(patientSimpleData) + 1; 
                }
            }

            var max = patienVisitCount.Values.Max();

            foreach (KeyValuePair<string, int> patient in patienVisitCount) 
            {
                if (patient.Value == max)
                {
                    favouritePatients.Add(patient.Key, patient.Value);
                }
            }
            
        
            return favouritePatients;
        }

        public Dictionary<string, int> FavouritePatients(IEnumerable<VisitDto> doctorVisits)
        {
            Dictionary<string, int> patienVisitCount = new Dictionary<string, int>();
            Dictionary<string, int> favouritePatients = new Dictionary<string, int>();
         
            foreach (var visit in doctorVisits)
            {
                string patientSimpleData = "";
            
                if (visit.DoctorName.Equals("") || visit.DoctorSurname.Equals("") || visit.PatientName.Equals("") || visit.PatientSurname.Equals("") || visit.RoomNumber.Equals("") || visit.VisitDate.Equals(""))
                    throw new ArgumentException();
                if (!Object.ReferenceEquals(visit.PatientName.GetType(), patientSimpleData.GetType()) || !Object.ReferenceEquals(visit.PatientSurname.GetType(), patientSimpleData.GetType()))
                    throw new ArgumentException();

                patientSimpleData = visit.PatientName + " " + visit.PatientSurname;
                if (!patienVisitCount.ContainsKey(patientSimpleData))
                {
                    patienVisitCount.Add(patientSimpleData, 1);
                }
                else
                {
                    patienVisitCount[patientSimpleData] = patienVisitCount.GetValueOrDefault(patientSimpleData) + 1;
                }
            }

            var max = patienVisitCount.Values.Max();

            foreach (KeyValuePair<string, int> patient in patienVisitCount)
            {
                if (patient.Value == max)
                {
                    favouritePatients.Add(patient.Key, patient.Value);
                }
            }


            return favouritePatients;
        }




    }
}
