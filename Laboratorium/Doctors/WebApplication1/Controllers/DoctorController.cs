namespace WebApplication1.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Application.Commands;
    using WebApplication1.Application.DoctorDto;
    using WebApplication1.Application.Queries;

    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ILogger<DoctorController> logger;
        private readonly IDoctorQueriesHandler doctorQueriesHandler;
        private readonly ICommandHandler<AddDoctorCommand> addDoctorCommandHandler;

        public DoctorController(ILogger<DoctorController> logger, IDoctorQueriesHandler doctorHandler, ICommandHandler<AddDoctorCommand> addDoctorCommandHandler)
        {
            this.logger = logger;
            this.doctorQueriesHandler = doctorHandler;
            this.addDoctorCommandHandler = addDoctorCommandHandler;
        }

        [HttpGet("Doctors")]
        public async Task <IEnumerable<DoctorDto>> GetAll()
        {
            return await doctorQueriesHandler.GetAllAsync();
        }

      

        [HttpPost("Doctor")]
        public void AddDoctor([FromBody] AddDoctorCommand doctorCommand)
        {
            addDoctorCommandHandler.Handle(doctorCommand);
        }


    }
}
