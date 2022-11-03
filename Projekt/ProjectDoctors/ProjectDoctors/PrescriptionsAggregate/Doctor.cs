namespace Prescriptions.Domain.PrescriptionsAggregate
{
    using Prescriptions.Domain.SeedWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Doctor : Entity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Doctor(int DoctorId, string name, string surname) : base(DoctorId)
        {
            Name = name;
            Surname = surname;
        }

        public Doctor(int DoctorId) : base(DoctorId)
        {

        }
    }
}

