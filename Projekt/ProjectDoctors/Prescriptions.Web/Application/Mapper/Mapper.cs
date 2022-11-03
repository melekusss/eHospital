namespace Prescriptions.Web.Application.Mapper
{
    using Prescriptions.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Prescriptions.Domain.PrescriptionsAggregate;

    public static class Mapper
    {
        public static PrescriptionDto Map(this Prescription prescription)
        {
            if (prescription == null)
                return null;

            return new PrescriptionDto
            {
                DateOfIssue = prescription.DateOfIssue,
                DoctorId = prescription.Doctor.Id,
                DoctorName = prescription.Doctor.Name,
                DoctorSurname = prescription.Doctor.Surname,
                Drugs = prescription?.Drugs.Select(s => s.DrugName),
                ExpirationDate = prescription.ExpirationDate,
                PatientId = prescription.Patient.Id,
                PatientName = prescription.Patient.Name,
                PatientSurname = prescription.Patient.Surname,

            };
        }
    }
}
