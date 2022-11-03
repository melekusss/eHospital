namespace Doctor.Web.Application.Queries
{
    using Doctor.Web.Application.Commands;
    using Doctor.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IDoctorHandler
    {
        public void AddNewPrescription(AddPrescriptionCommand prescriptionCommand);
        Task<IEnumerable<VisitDto>> GetVisitsByDoctortId(int doctorId);
        Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByDoctorId(int doctorId);
        Task<Dictionary<string, int>> FavouritePatients(int doctorId);
    }
}
