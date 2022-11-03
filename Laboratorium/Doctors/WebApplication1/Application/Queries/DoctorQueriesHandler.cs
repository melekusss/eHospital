
namespace WebApplication1.Application.Queries
{
    
    using Solution1.ClassLibrary1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Application.DoctorDto;
    using WebApplication1.Application.Mapper;

    public class DoctorQueriesHandler : IDoctorQueriesHandler
    {
        private readonly IDocotorRepository docotorRepository;

        public DoctorQueriesHandler(IDocotorRepository doctorRepository)
        {
            this.docotorRepository = doctorRepository;
        }

        public async Task <IEnumerable<DoctorDto>> GetAllAsync()
        {
            return (await docotorRepository.GetAllAsync()).Select(r => r.Map());
        }

        /*public IEnumerable<DoctorDto> GetByCertificationType(int certificationType)
        {
            return docotorRepository.GetByCertificationType(certificationType)?.Select(ld => ld.Map());
        }*/
    }
}
