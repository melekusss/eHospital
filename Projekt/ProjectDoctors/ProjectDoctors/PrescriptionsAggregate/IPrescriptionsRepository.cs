namespace Prescriptions.Domain.PrescriptionsAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IPrescriptionsRepository
    {
        Task<IEnumerable<Prescription>> GetByDoctorIdAsync(int doctorId);
        Task<IEnumerable<Prescription>> GetByPatientIdAsync(int patientId);
        Task AddPrescriptionAsync(Prescription prescription);
    }
}
