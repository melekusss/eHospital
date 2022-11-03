namespace Prescriptions.Web.Application.Queries
{
    using Prescriptions.Web.Application.Dtos;
    using Prescriptions.Domain.PrescriptionsAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public interface IPrescriptionsQuriesHandler
    {

        Task<IEnumerable<PrescriptionDto>> GetByDoctorIdAsync(int doctorId);
        Task<IEnumerable<PrescriptionDto>> GetByPatientIdAsync(int patientId);



    }
}
