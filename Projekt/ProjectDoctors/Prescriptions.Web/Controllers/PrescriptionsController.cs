namespace Prescriptions.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Prescriptions.Web.Application.Commands;
    using Prescriptions.Web.Application.Dtos;
    using Prescriptions.Web.Application.Queries;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    public class PrescriptionsController : ControllerBase
    {
        private readonly ILogger<PrescriptionsController> logger;
        private readonly IPrescriptionsQuriesHandler prescriptionQueriesHandler;
        private readonly ICommandHandler<AddPrescriptionCommand> addPrescriptionHandler;

        public PrescriptionsController(ILogger<PrescriptionsController> logger, IPrescriptionsQuriesHandler prescriptionsQueriesHandler, ICommandHandler<AddPrescriptionCommand> addPrescriptionCommandHandler)
        {
            this.logger = logger;
            this.prescriptionQueriesHandler = prescriptionsQueriesHandler;
            this.addPrescriptionHandler = addPrescriptionCommandHandler;
        }

        [HttpGet("prescriptions-by-doctor-id")]
        public async Task<IEnumerable<PrescriptionDto>> GetByDoctorIdAsync([FromQuery] int doctorId)
        {
            return await prescriptionQueriesHandler.GetByDoctorIdAsync(doctorId);
        }

        [HttpGet("prescriptions-by-patient-id")]
        public async Task<IEnumerable<PrescriptionDto>> GetByPatientIdAsync([FromQuery] int patientId)
        {
            return await prescriptionQueriesHandler.GetByPatientIdAsync(patientId);
        }

        [HttpPost("prescription-add")]
        public void AddExaminationRoom([FromBody] AddPrescriptionCommand prescriptionCommand)
        {
            addPrescriptionHandler.Handle(prescriptionCommand);
        }
    }
}