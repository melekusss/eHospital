namespace Prescriptions.Domain.PrescriptionsAggregate
{
    using Prescriptions.Domain.SeedWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Patient : Entity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Patient(int patientId, string name, string surname) : base(patientId)
        {
            Name = name;
            Surname = surname;
        }

        public Patient(int patientId) : base(patientId)
        {

        }
    }
}
