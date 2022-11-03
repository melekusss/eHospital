namespace Prescriptions.Web.Application.Commands
{
    using Prescriptions.Domain.PrescriptionsAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class PrescriptionsCommandsHandler : ICommandHandler<AddPrescriptionCommand>
    {
        private readonly IPrescriptionsRepository prescriptionRepository;

        public PrescriptionsCommandsHandler(IPrescriptionsRepository prescriptionsRepository)
        {
            this.prescriptionRepository = prescriptionsRepository;
        }

        public void Handle(AddPrescriptionCommand command)
        {
            var Drugs = new List<Drug>();
            int exampleId = 0;
            foreach (var drug in command.Drugs)
                Drugs.Add(new Drug(exampleId, drug));

            Doctor doctor = new Doctor(exampleId, command.DoctorName, command.DoctorSurname);
            Patient patient = new Patient(exampleId, command.PatientName, command.PatientSurname);

            prescriptionRepository.AddPrescriptionAsync(new Prescription(exampleId, command.DateOfIssue, doctor, Drugs, command.ExpirationDate, patient));

        }
    }
}
