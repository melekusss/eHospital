namespace Prescriptions.Domain.PrescriptionsAggregate
{
    using Prescriptions.Domain.SeedWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Prescription : Entity
    {
        public string DateOfIssue { get; private set; }
        public Doctor Doctor { get; private set; }
        public IList<Drug> Drugs { get; private set; } = new List<Drug>();
        public string ExpirationDate { get; private set; }
        public Patient Patient { get; private set; }


        public Prescription(int id, string dateOfIssue, int doctorId, string expirationDate, int patientId) : base(id)
        {
            DateOfIssue = dateOfIssue;
            Doctor = new Doctor(doctorId);
            ExpirationDate = expirationDate;
            Patient = new Patient(patientId);
        }


        public Prescription(int id, string dateOfIssue, Doctor doctor, IList<Drug> drugs, string expirationDate, Patient patient) : base(id)
        {
            DateOfIssue = dateOfIssue;
            Doctor = doctor;
            Drugs = drugs;
            ExpirationDate = expirationDate;
            Patient = patient;
        }

        public void AddDrug(Drug drug)
        {
            Drugs.Add(drug);
        }
        public void AddDrugs(IEnumerable<Drug> drugs)
        {
            foreach (var drug in drugs)
                Drugs.Add(drug);
        }

        public void SetDoctor(Doctor doctor)
        {
            Doctor = doctor;
        }
        public void SetPatient(Patient patient)
        {
            Patient = patient;
        }

    }
}
