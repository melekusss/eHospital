namespace Patient.Web.Controllers
{
    using Doctor.Web.Application.Commands;
    using Doctor.Web.Application.Dtos;
    using Doctor.Web.Application.Queries;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ILogger<DoctorController> logger;
        private readonly IDoctorHandler DoctorHandler;


        public DoctorController(ILogger<DoctorController> logger, IDoctorHandler DoctorHandler)
        {
            this.logger = logger;
            this.DoctorHandler = DoctorHandler;
        }

        [HttpPost("assign-prescription")]
        public void AddVisit([FromBody] AddPrescriptionCommand prescriptionCommand)
        {
            DoctorHandler.AddNewPrescription(prescriptionCommand);
        }

        [HttpGet("visits-calendar")]
        public async Task<IEnumerable<VisitDto>> GetVisitsByDoctorId([FromQuery] int doctorId)
        {
            return (await DoctorHandler.GetVisitsByDoctortId(doctorId));

        }

        [HttpGet("doctors-prescriptions")]
        public async Task<IEnumerable<PrescriptionDto>> GetPresciptionsByDoctorId([FromQuery] int doctorId)
        {
            return (await DoctorHandler.GetPrescriptionsByDoctorId(doctorId));
        }

        [HttpGet("doctors-favourite-patients")]
        public async Task<Dictionary<string, int>> FavouritePatients([FromQuery] int doctorId)
        {
            return (await DoctorHandler.FavouritePatients(doctorId));
        }




    }


}