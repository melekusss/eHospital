using ExaminationRoomsSelector.Web.Application.Commands;
using ExaminationRoomsSelector.Web.Application.Dtos;
using ExaminationRoomsSelector.Web.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationRoomsSelector.Web.Controllers
{
    [ApiController]
    public class ExaminationRoomsSelectorController : ControllerBase
    {
        private readonly ILogger<ExaminationRoomsSelectorController> logger;
        private readonly IExaminationRoomsSelectorHandler examinationRoomsSelectorHandler;
        private readonly AddDoctorsCommandHandler addDoctorsCommandHandler;

        public ExaminationRoomsSelectorController(ILogger<ExaminationRoomsSelectorController> logger, IExaminationRoomsSelectorHandler examinationRoomsSelectorHandler, AddDoctorsCommandHandler addDoctorsCommandHandler)
        {
            this.logger = logger;
            this.examinationRoomsSelectorHandler = examinationRoomsSelectorHandler;
            this.addDoctorsCommandHandler = addDoctorsCommandHandler;
        }

        [HttpGet("examination-rooms-selection")]
        public async Task<List<PairDto>> GetLaboratoryDiagnosticiansDetails()
        {
            return await examinationRoomsSelectorHandler.GetExaminationRoomsSelectionAsync();
        }

       

        [HttpPost("Doctor")]
        public void AddDoctor([FromBody] AddDoctorCommand doctorCommand)
        {
            addDoctorsCommandHandler.HandleAsync(doctorCommand);
        }
    }
}
