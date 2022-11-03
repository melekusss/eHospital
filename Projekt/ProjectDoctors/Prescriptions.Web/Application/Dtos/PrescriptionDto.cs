namespace Prescriptions.Web.Application.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Prescriptions.Domain.PrescriptionsAggregate;
    public class PrescriptionDto
    {
        public string DateOfIssue { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public IEnumerable<string> Drugs { get; set; }
        public string ExpirationDate { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
    }
}
