namespace WebApplication1.Application.Commands
{
    using Solution1.ClassLibrary1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class DoctorsCommandsHandler : ICommandHandler<AddDoctorCommand>
    {
        private readonly IDocotorRepository doctorsRepository;

        public DoctorsCommandsHandler(IDocotorRepository doctorsRepository)
        {
            this.doctorsRepository = doctorsRepository;
        }

        public void Handle(AddDoctorCommand command)
        {
            var specializations = new List<Specialization>();

            foreach (var specialization in command.Specialization)
                specializations.Add(new Specialization(0, specialization));

            doctorsRepository.AddDoctorAsync(new Doctor(0, command.Salary, command.MainSpecialization,command.YearsOfWork,command.Name,command.Surname ,command.Age, specializations));
         
        }
    }
}
