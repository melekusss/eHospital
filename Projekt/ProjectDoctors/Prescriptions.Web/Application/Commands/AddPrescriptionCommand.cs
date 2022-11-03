namespace Prescriptions.Web.Application.Commands
{
    using Prescriptions.Domain.PrescriptionsAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class AddPrescriptionCommand : ICommand
    {
        public string DateOfIssue { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public IList<string> Drugs { get; set; }
        public string ExpirationDate { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }

    }
}
