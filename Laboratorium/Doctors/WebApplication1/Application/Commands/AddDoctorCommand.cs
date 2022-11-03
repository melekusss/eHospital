
namespace WebApplication1.Application.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class AddDoctorCommand: ICommand
    {
        public int Salary { get; set; }
        public string MainSpecialization { get; set; }
        public int YearsOfWork { get; set; }

        public int Age { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public IEnumerable<int> Specialization { get; set; }
    }
}
