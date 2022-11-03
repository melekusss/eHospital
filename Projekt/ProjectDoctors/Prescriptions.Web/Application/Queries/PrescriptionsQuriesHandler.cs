namespace Prescriptions.Web.Application.Queries
{
    using Prescriptions.Domain.PrescriptionsAggregate;
    using Prescriptions.Web.Application.Dtos;
    using Prescriptions.Web.Application.Mapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class PrescriptionsQuriesHandler : IPrescriptionsQuriesHandler
    {
        private readonly IPrescriptionsRepository prescriptionsRepository;

        public PrescriptionsQuriesHandler(IPrescriptionsRepository prescriptionsRepository)
        {
            this.prescriptionsRepository = prescriptionsRepository;
        }
        public async Task<IEnumerable<PrescriptionDto>> GetByDoctorIdAsync(int doctorId)
        {
            return (await prescriptionsRepository.GetByDoctorIdAsync(doctorId))?.Select(ld => ld.Map());
        }
        public async Task<IEnumerable<PrescriptionDto>> GetByPatientIdAsync(int patientId)
        {
            return (await prescriptionsRepository.GetByPatientIdAsync(patientId))?.Select(ld => ld.Map());
        }





    }



}
