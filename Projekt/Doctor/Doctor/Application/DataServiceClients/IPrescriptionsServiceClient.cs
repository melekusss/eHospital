namespace Doctor.Web.Application.DataServiceClients
{
    using Doctor.Web.Application.Commands;
    using Doctor.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IPrescriptionsServiceClient
    {
        Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByDoctorId(int doctorId);

        public void PostPrescription(AddPrescriptionCommand command);
    }
}