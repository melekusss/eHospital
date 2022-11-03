namespace Doctor.Web.Application.DataServiceClients
{
    using Doctor.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IVisitsServiceClient
    {
        Task<IEnumerable<VisitDto>> GetVisitsByDoctorId(int doctorId);
    }
}

