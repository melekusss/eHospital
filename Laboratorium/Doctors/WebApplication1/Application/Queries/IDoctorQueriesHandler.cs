namespace WebApplication1.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Application.DoctorDto;


    public interface IDoctorQueriesHandler
    {
        Task <IEnumerable<DoctorDto>> GetAllAsync();
        //IEnumerable<DoctorDto> GetByCertificationType(int certificationType);
    }
}
